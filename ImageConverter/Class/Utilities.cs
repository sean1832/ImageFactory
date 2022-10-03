using System.Diagnostics;
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

    public static (int height, int width) ScaleToTarget(int baseHeight, int baseWidth, int maxTargetSize)
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
}