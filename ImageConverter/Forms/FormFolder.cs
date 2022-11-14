using System.Data;
using System.Diagnostics;
using System.Security.Cryptography;
using ImageConverter.Class;
using FolderBrowserDialog = System.Windows.Forms.FolderBrowserDialog;
using ImageMagick;

namespace ImageConverter.Forms
{
    public partial class FormFolder : Form
    {
        #region Initialisation

        private DataTable table;

        private readonly FolderBrowserDialog _browserDialog = new FolderBrowserDialog();
        private OpenFileDialog _openFileDialog = new OpenFileDialog();
        public FormFolder()
        {
            InitializeComponent();

            // initialise drag and drop
            this.dataGridView1.DragDrop += new DragEventHandler(this.dataGridView1_DragDrop);
            this.dataGridView1.DragEnter += new DragEventHandler(this.dataGridView1_DragEnter);
        }

        private void FormFolder_Load(object sender, EventArgs e) // double click form base
        {
            // table setup
            table = new DataTable();

            table.Columns.Add("FileName", typeof(string));
            table.Columns.Add("FileExt", typeof(string));
            table.Columns.Add("FilePath", typeof(string));

            dataGridView1.DataSource = table;
            Actions.CustomTableStyle(dataGridView1);

            // combo box setup
            object[] formatKeys = OutputExtension.GetFormatKeys();
            comboConvertTo.Items.AddRange(formatKeys);
        }
        #endregion

        #region drag and drop
        private void dataGridView1_DragEnter(object? sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }


        private void dataGridView1_DragDrop(object? sender, DragEventArgs e)
        {

            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            foreach (var filePath in files)

            {
                string fileName = Path.GetFileNameWithoutExtension(filePath);
                string fileExt = Path.GetExtension(filePath);

                if (Utilities.IsDuplicated(dataGridView1, filePath) == false)
                {
                    table.Rows.Add(fileName, fileExt, filePath);
                    dataGridView1.DataSource = table;
                    Actions.UpdateInputExtension(dataGridView1, comboConvertFrom);
                }
            }
            // update output path
            
        }
        #endregion

        #region buttons functions
        private void buttonBrowseInput_Click(object sender, EventArgs e)
        {
            if (_browserDialog.ShowDialog() != DialogResult.OK) return;
            textBoxInput.Text = _browserDialog.SelectedPath;

            if (textBoxInput.Text == String.Empty) return;
            string dirPath = textBoxInput.Text;
            string[] files = Directory.GetFiles(dirPath);

            foreach (var filePath in files)
            {
                string fileName = Path.GetFileNameWithoutExtension(filePath);
                string fileExt = Path.GetExtension(filePath);

                if (Utilities.IsDuplicated(dataGridView1, filePath) == false)
                {
                    table.Rows.Add(fileName, fileExt, filePath);
                    dataGridView1.DataSource = table;
                }
            }
            Actions.UpdateInputExtension(dataGridView1, comboConvertFrom);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (_browserDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxOutput.Text = _browserDialog.SelectedPath;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text = String.Empty;
            table.Rows.Clear();
            progressBar1.Value = 0;
        }

        private void comboConvertFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataView dv = table.DefaultView;

            if (comboConvertFrom.Text.ToString() != "ALL")
            {
                dv.RowFilter = "FileExt LIKE '" + comboConvertFrom.Text + "%'";
            }
            else
            {
                dv.RowFilter = "FileExt LIKE '" + "*" + "%'";
            }

            dataGridView1.DataSource = dv;
        }

        private void comboConvertFrom_TextUpdate(object sender, EventArgs e)
        {
            DataView dv = table.DefaultView;
            dv.RowFilter = "FileExt LIKE '" + comboConvertFrom.Text + "%'";

            dataGridView1.DataSource = dv;
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;

            if (comboConvertTo.Text.ToString() == string.Empty)
            {
                MessageBox.Show(@"Select a output file type to continue", @"warning", MessageBoxButtons.RetryCancel,
                    MessageBoxIcon.Error);
            }
            else if (textBoxOutput.Text.ToString() == string.Empty)
            {
                MessageBox.Show(@"Enter an output path continue", @"warning", MessageBoxButtons.RetryCancel,
                    MessageBoxIcon.Error);
            }

            else
            {
                string outputExt = comboConvertTo.Text;
                string outputDir = textBoxOutput.Text;

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    int totalNum = dataGridView1.Rows.Count;
                    string? fileName = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    string? inputPath = dataGridView1.Rows[i].Cells[2].Value.ToString();

                    if (checkOverride.CheckState == CheckState.Unchecked)
                    {
                        string newFileName = RenameDuplicateFiles(outputDir, fileName, outputExt);
                        Actions.ConvertImage(inputPath, outputDir, newFileName, outputExt, textBoxOutput, labelXVal.Text, labelYVal.Text);
                    }
                    else
                    {
                        // override allow
                        Actions.ConvertImage(inputPath, outputDir, fileName, outputExt, textBoxOutput);
                    }

                    int increment = 100 / totalNum;
                    progressBar1.Increment(increment);
                }

                // complete
                MessageBox.Show(@"Output Complete!", @"Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                /*
                if (MessageBox.Show(@"Open Output directory?", @"Open Directory", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // open directory in explore
                    OpenFolder(outputDir);
                }
                */
            }

        }
        private void comboConvertTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboConvertTo.Text == string.Empty) return;
            string? firstRowPath = dataGridView1.Rows[0].Cells[2].Value.ToString();
            if (string.IsNullOrEmpty(firstRowPath)) return;
            string? directory = Path.GetDirectoryName(firstRowPath);
            string folderName = comboConvertTo.Text;
            textBoxOutput.Text = $@"{directory}\{folderName}";
        }
        #endregion

        #region Private Functions

        private string RenameDuplicateFiles(string outputDir, string fileName, string outputExt)
        {
            // if duplicate file exist, rename accordingly 
            int count = 1;
            string fullOutPath = outputDir + @"\" + fileName + "." + outputExt;

            string newPath = fullOutPath;
            string? newFileName = fileName;
            while (File.Exists(newPath))
            {
                string? tempFileName = $"{fileName}_({count++})";
                newPath = outputDir + @"\" + tempFileName + "." + outputExt;
                newFileName = tempFileName;
            }

            return newFileName;
        }

        private void updateScaleLable()
        {
            labelXVal.Text = string.Empty;
            labelYVal.Text = string.Empty;

            string strScale = comboScale.Text;


            if (dataGridView1.Rows.Count == 0) return;

            string inputPath = dataGridView1.Rows[0].Cells[2].Value.ToString();
            (int x, int y) = Utilities.GetImageDimension(inputPath);
            (x, y) = Utilities.ScaleImageDimensions(x, y, strScale);
            labelXVal.Text = x.ToString();
            labelYVal.Text = y.ToString();
        }

        #endregion

        private void comboScale_TextUpdated(object sender, EventArgs e)
        {
            updateScaleLable();
        }

        private void trackBarScale_Scroll(object sender, EventArgs e)
        {
            float scale = Utilities.ScrollScale(trackBarScale, 0.1f, 2.5f);
            comboScale.Text = scale.ToString();
            updateScaleLable();
        }
    }
}
