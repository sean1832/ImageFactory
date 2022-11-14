using System.Diagnostics;
using System.Xml.Schema;
using ImageMagick;
using Microsoft.Win32.SafeHandles;

namespace ImageConverter.Class;

public static class Utilities
{
    public static bool IsDuplicated(DataGridView grid, string newPath)
    {

        List<int> dupCheck = new List<int>();

        if (grid.Rows.Count == 0) return dupCheck.Count > 0;
        for (int i = 0; i < grid.Rows.Count; i++)
        {
            var value = grid.Rows[i].Cells[2].Value?.ToString();

            if (value == newPath)
            {
                dupCheck.Add(i);
            }
        }
        return dupCheck.Count > 0;
    }
    /// <summary>
    /// scaled image to fit maximum target size.
    /// </summary>
    /// <param name="baseHeight">original image size</param>
    /// <param name="baseWidth">original image size</param>
    /// <param name="maxTargetSize">new maximum target size</param>
    /// <returns>dimensions of new image</returns>
    /// <exception cref="Exception"></exception>
    public static (int height, int width) ScaleToTargetFit(int baseHeight, int baseWidth, int maxTargetSize)
    {
        int max = Math.Max(baseHeight, baseWidth);
        double scaleFactor = (double)maxTargetSize / (double)max;

        // calculate ratio
        double scaleHeightD = Math.Floor((double)baseHeight * scaleFactor);
        double scaleWidthD = Math.Floor((double)baseWidth * scaleFactor);

        // exceptions
        if (Utilities.IsInvalidInt(scaleWidthD)) throw new Exception($"Invalid int value! = {scaleWidthD}");
        else if (Utilities.IsInvalidInt(scaleHeightD)) throw new Exception($"Invalid int value! = {scaleHeightD}");

        // convert
        int scaleHeight = Convert.ToInt32(scaleHeightD);
        int scaleWidth = Convert.ToInt32(scaleWidthD);

        return (scaleHeight, scaleWidth);
    }

    public static bool IsInvalidInt(double number)
    {
        return (number.ToString().Contains('.')) ;
    }


    public static string[] GetExtensions(DataGridView dataGridView)
    {
        List<string> extensions = new List<string>();


        if (dataGridView.Rows.Count != 0)
        {
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                string? value = dataGridView.Rows[i].Cells[1].Value?.ToString();
                if (value != null) extensions.Add(value);
            }
        }

        List<string> uniqueExtensions = extensions.Distinct().ToList();

        return uniqueExtensions.ToArray();
    }

    /// <summary>
    /// Get image base dimensions
    /// </summary>
    /// <param name="path">image full path</param>
    /// <returns></returns>
    public static (int x, int y) GetImageDimension(string path)
    {
        using (var image = new MagickImage(path))
        {
            return (image.BaseWidth, image.BaseHeight);
        }
    }

    #region ScaleImageDimensions
    public static (int x, int y) ScaleImageDimensions(string strInputX, string strInputY, string strScaleFactor)
    {
        if (strScaleFactor == string.Empty)
        {
            strScaleFactor = "1.0";
        }

        bool xParse = int.TryParse(strInputX, out int inputX);
        bool yParse = int.TryParse(strInputY, out int inputY);
        bool scaleParse = float.TryParse(strScaleFactor, out float scaleFactor);

        if (!xParse || !yParse || !scaleParse)
        {
            MessageBox.Show(@"Value Error: Enter a valid number", @"Error", MessageBoxButtons.RetryCancel,
                MessageBoxIcon.Error);
        }


        int outX = (int)Math.Round(inputX * scaleFactor);
        int outY = (int)Math.Round(inputY * scaleFactor);

        return (outX, outY);
    }

    public static (int x, int y) ScaleImageDimensions(string strInputX, string strInputY, float scaleFactor)
    {
        bool xParse = int.TryParse(strInputX, out int inputX);
        bool yParse = int.TryParse(strInputY, out int inputY);

        if (!xParse || !yParse)
        {
            MessageBox.Show(@"Value Error: Enter a valid number", @"Error", MessageBoxButtons.RetryCancel,
                MessageBoxIcon.Error);
        }

        int outX = (int)Math.Round(inputX * scaleFactor);
        int outY = (int)Math.Round(inputY * scaleFactor);

        return (outX, outY);
    }

    public static (int x, int y) ScaleImageDimensions(int inputX, int inputY, string strScaleFactor)
    {
        if (strScaleFactor == string.Empty)
        {
            strScaleFactor = "1.0";
        }

        bool scaleParse = float.TryParse(strScaleFactor, out float scaleFactor);

        if (!scaleParse)
        {
            MessageBox.Show(@"Value Error: Enter a valid number", @"Error", MessageBoxButtons.RetryCancel,
                MessageBoxIcon.Error);
        }

        int outX = (int)Math.Round(inputX * scaleFactor);
        int outY = (int)Math.Round(inputY * scaleFactor);

        return (outX, outY);
    }

    public static (int x, int y) ScaleImageDimensions(int inputX, int inputY, float scaleFactor)
    {
        int outX = (int)Math.Round(inputX * scaleFactor);
        int outY = (int)Math.Round(inputY * scaleFactor);

        return (outX, outY);
    }

    #endregion

    public static float ScrollScale(TrackBar trackBar, float minFactor, float maxFactor)
    {
        

        int scrollNum = trackBar.Value;
        int minCount = Math.Abs(trackBar.Minimum);
        int maxCount = Math.Abs(trackBar.Maximum);

        float positiveInterval = (float)maxFactor / (float)maxCount;
        float negativeInterval = (1 - (float)minFactor) / (float)minCount;

        float scaleFactor = 0.00f;

        if (scrollNum == 0)
        {
            scaleFactor = 1.00f;
        }
        else if (scrollNum > 0)
        {
            scaleFactor = 1 + ((float)scrollNum * positiveInterval);
        }
        else
        {
            scaleFactor = 1 + ((float)scrollNum * negativeInterval);
        }

        return scaleFactor;
    }
}