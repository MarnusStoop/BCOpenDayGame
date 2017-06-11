using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace OpenDayGame
{
    public static class ImageHandler
    {

        public static Bitmap LoadImage(string path)
        {
            if(!File.Exists(path))
            {
                return null;
            }
            return (Bitmap)Bitmap.FromFile(path);
        }
    }
}