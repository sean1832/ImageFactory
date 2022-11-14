using System.Collections.Immutable;
using System.Diagnostics;
using ImageMagick;

namespace ImageConverter.Class;

public class Actions
{
    public static void ConvertImage(string? inputDir, string outputDir, string? outputName, string outExt, TextBox outputTextBox, string scaleX = "", string scaleY = "")
    {
        // set ghostScript directory
        string baseDir = AppDomain.CurrentDomain.BaseDirectory;
        MagickNET.SetGhostscriptDirectory(@$"{baseDir}\GS");


        string outputPath = outputDir + @"\" + outputName + "." + outExt;
        ImageMagick.MagickFormat format = OutputExtension.GetFormatVal(outExt);
        Directory.CreateDirectory(outputTextBox.Text);

        bool defaultMode = scaleX == "" && scaleY == "" || scaleX == "0" && scaleY == "0";

        using (var image = new MagickImage(inputDir))
        {
            image.Format = format;
            if (defaultMode)
            {
                if (format == MagickFormat.Ico)
                {
                    int height = image.BaseHeight;
                    int width = image.BaseWidth;

                    (int height, int width) newDimension = Utilities.ScaleToTargetFit(height, width, 256);

                    image.Resize(newDimension.width, newDimension.height);
                }
                image.Write(outputPath);
            }
            else
            {
                int width = int.Parse(scaleX);
                int height = int.Parse(scaleY);

                bool icoOversized = width >= 256 && height >= 256;

                if (format == MagickFormat.Ico && icoOversized)
                {
                    (int height, int width) newDimension = Utilities.ScaleToTargetFit(height, width, 256);
                    image.Resize(newDimension.width, newDimension.height);
                }
                else
                {
                    image.Resize(width, height);
                }
                image.Write(outputPath);
            }
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