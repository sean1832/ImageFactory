using System.Diagnostics;
using ImageMagick;

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