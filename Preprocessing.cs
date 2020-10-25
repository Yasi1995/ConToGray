using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenCvSharp;

namespace lab01
{
    class Preprocessing
    {
        IplImage scr,gray;
        public void LoadOriginalImage()
        {
            scr = Cv.LoadImage("apple1.jpg", LoadMode.Color);
            Cv.SaveImage("1.jpg", scr);

        }
        public void GrayScalelImage()
        {
            gray = Cv.CreateImage(scr.Size, BitDepth.U8, 1);
            Cv.CvtColor(scr, gray, ColorConversion.RgbaToGray);
            Cv.SaveImage("2.jpg", gray);
        }
        public void ExtractImage()
        {
            System.Windows.Forms.MessageBox.Show("Height :" + scr.Height + ", Width:" + scr.Width + " ,No of Channels:" + scr.NChannels);
        }


    }
}
