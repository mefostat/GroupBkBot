using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuateDi
{
    class Overlay
    {
        public string EnText(string str)
        {
            Int32 k = 75;
            Int32 s = str.Length;
            int end = str.Substring(0, k).LastIndexOf(' ');
            str = str.Substring(0, end) + Environment.NewLine + str.Substring(k - 1, s - k + 1);
            return str;
        }
        
        
        /// <summary>
        ///  Рисуем текст на изображении, текст с фоном 
        /// </summary>
        /// <param name="img"></param>
        /// <param name="text"></param>
        /// <param name="dfont"></param>
        public void DrawText(Graphics img, string text, Font dfont)
        {

            SizeF size = new SizeF();
            size = img.MeasureString(text, dfont);
            if (size.Width > 860)
            {
                text = EnText(text);
                size = img.MeasureString(text, dfont);
                size.Width = 800;
            }
            Brush br = new SolidBrush(Color.White);
            Brush rc = new SolidBrush(Color.FromArgb(220, 0, 40, 77));
       


            img.FillRectangle(rc, 50, 50, size.Width+10, size.Height+10);

            img.DrawString(text, dfont, br, new PointF(50, 50));



        }
        public void SaveAlt(string url, string dirImg)
        {
            using (var client = new System.Net.WebClient())
            {
                
                try
                {
                    client.DownloadFile(new Uri(url), dirImg + @"\Img.png");
                }
                catch (WebException ex)
                {
                    MessageBox.Show(ex.ToString());

                }
            }  
           

        }


    }
}
