using System.Diagnostics;
using ImageMagick;

namespace ImageConverter.Class;

public class Actions
{
    public static void ConvertImage(string? inputDir, string outputDir, string? outputName, string outExt, TextBox outputTextBox)
    {
        string outputPath = outputDir + @"\" + outputName + "." + outExt;
        ImageMagick.MagickFormat format = new OutputExtension().GetFormatVal(outExt);
        Directory.CreateDirectory(outputTextBox.Text);
        using (var image = new MagickImage(inputDir))
        {
            image.Format = format;
            image.Write(outputPath);
        }
    }

    public static void UpdateInputExtension(DataGridView dataGridView, ComboBox comboFrom)
    {
        comboFrom.Items.Clear();
        comboFrom.Items.Add("ALL");
        string[] items = Utilities.GetExtensions(dataGridView);
        foreach (string item in items)
        {
            comboFrom.Items.Add(item);
        }

        // default value
        comboFrom.Text = comboFrom.Items[0].ToString();
    }

    public static void OpenFolder(string path)
    {
        if (Directory.Exists(path))
        {
            ProcessStartInfo startInfo = new ProcessStartInfo()
            {
                Arguments = path,
                FileName = "explorer.exe"
            };

            Process.Start(startInfo);
        }
        else
        {
            MessageBox.Show($@"{path} Directory does not exist!", @"Warning", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
        }
    }

    public static void CustomTableStyle(DataGridView dataGridView)
    {
        DataGridViewColumn nameColumn = dataGridView.Columns[0];
        DataGridViewColumn extColumn = dataGridView.Columns[1];
        DataGridViewColumn pathColumn = dataGridView.Columns[2];

        nameColumn.Width = 150;
        extColumn.Width = 100;
        pathColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
    }
}