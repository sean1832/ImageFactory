using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImageMagick;
using static ImageMagick.MagickFormat;


namespace ImageConverter.Class
{
    internal class OutputExtension
    {
        public static object[] GetFormatKeys()
        {
            List<string> format = new List<string>();
            foreach (string item in ImgFormats.Keys)
            {
                format.Add(item);
            }
            return format.ToArray();
        }

        public static ImageMagick.MagickFormat GetFormatVal(string key)
        {
            return ImgFormats[key];
        }

        public static Dictionary<string, ImageMagick.MagickFormat> ImgFormats = new Dictionary<string, ImageMagick.MagickFormat>
        {
            {"png", Png},
            {"jpeg", Jpeg},
            {"exr", Exr},
            {"heic", Heic},
            {"tga", Tga},
            {"tiff", Tiff},
            {"psd", Psd},
            {"ico", Ico},
            {"pdf", Pdf},
            {"svg", Svg},
            {"bmp", Bmp},
            {"raw", Raw},
            {"html",Html},
            {"jxl", Jxl},
            {"rgb", Rgb},
            {"rgba", Rgba},
        };

    }
}
