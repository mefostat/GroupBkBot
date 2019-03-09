using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Drawing;
using xNet;
using HtmlAgilityPack;
using Newtonsoft.Json;
using System.Text.RegularExpressions;
using System.Net;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace QuateDi
{
    class ImgAd
    {
        public static string SplitToLines(string str)
        {

            return Regex.Replace(str, ",", "\r\n");

        }
        public void DrawText(Graphics g, string text, PointF location,Image img)
        {
           
            // Получаем текст 
            string measureString = text;
            Font FontText = new Font("Swanky and Moo Moo Cyrillic", 24);
           
            // Размер строки
            SizeF measure = new SizeF();
            measure = g.MeasureString(text, FontText);
            // Если ширина строки больше ширины изображения, уменьшить шрифт и поменять расположение 
            if (measure.Width > img.Width)
            {
                FontText = new Font("Swanky and Moo Moo Cyrillic", 10);
                location = new PointF(100, 200);
            }
            
            Brush brush = new SolidBrush(Color.White); // Цвет кисти 
            
            g.DrawString(SplitToLines(measureString), FontText, brush, location); // Рисуем текст на картинке

        }

        public string  GetPicture(string text,Boolean bol)
        {
           
             Random rand = new Random();
             Int32 randompage;
            
            //string order = rand.Next(1,2)== 1 ? "popular" : "latest";
            string Answer = string.Empty;
            if (bol == true)
            {
                
                randompage = rand.Next(3, 20);
            }
            else
            {
                
                randompage = 1;
            }



            WebRequest request =  WebRequest.Create("https://pixabay.com/api/?key=9617284-4942555aaddc46639052e164d&q=" + text + "&image_type=all&page=" + Convert.ToString(randompage - 2));
            request.Method = "POST";
            request.ContentType = "application/x-www-urlencoded";

            WebResponse response = request.GetResponse();

           

             using (Stream s = response.GetResponseStream())
            {
                using (StreamReader reader = new StreamReader(s))
                {
                    Answer =  reader.ReadToEnd();

                }
             
            }
           
            return Answer; 
          
        }

        public string LoadPicture(string JsonOb)
        {
            Random rand = new Random();
            Int32 random = rand.Next(1, 19);
            var img = JsonConvert.DeserializeObject<ImgAd>(JsonOb);

            return img.hits[random].largeImageURL;
            
            

        }
        public hits[] hits { get; set; }
        static string LoadPage(string url)
        {

            var result = "";
            var request = (HttpWebRequest)WebRequest.Create(url);
            var response = (HttpWebResponse)request.GetResponse();

            
                var receiveStream = response.GetResponseStream();
                if (receiveStream != null)
                {
                    StreamReader readStream;
                    if (response.CharacterSet == null)
                        readStream = new StreamReader(receiveStream);
                    else
                        readStream = new StreamReader(receiveStream, Encoding.GetEncoding(response.CharacterSet));
                    result = readStream.ReadToEnd();
                    readStream.Close();
                }
                response.Close();
            
            return result;
        }
        public  string s;
        public string RandomDoubleQuote()
        {
            string Answer = string.Empty;
            Random rand = new Random();
            Int64 i = rand.Next(1,3);
           s = i.ToString();
            if (i == 1)
            {
                Answer = GetQuote();
                dynamic js = JObject.Parse(Answer);
                return js.quoteText;
            }
            else if (i == 2)
            {

                return GetAltQuote();
            }
            else
            {
                Answer = GetQOver();
                dynamic js = JObject.Parse(Answer);
                return js.content;
            }

        }
        public string GetAltQuote()
        {
            string qut = string.Empty;
            while (true)
            {
                // var pageContent = LoadPage(@"https://quote-citation.com/random");
                var pageContent = LoadPage(@"https://genword.ru/generators/winged/");
                var document = new HtmlAgilityPack.HtmlDocument();
                document.LoadHtml(pageContent);
                //HtmlNodeCollection links = document.DocumentNode.SelectNodes(@".//div[@class='quote-text-inner']");
                HtmlNodeCollection links = document.DocumentNode.SelectNodes(@".//span[@class='result']");
                //DocumentNode.SelectNodes(".//div[@class="produnctName"]/text()");
                foreach (HtmlNode link in links)
                    //Console.WriteLine( + "\r\n");
                    return qut = link.InnerText;
            }

        }

        public string GetQuote() // ПОлучаем JSON с цитатой. 
        {
            string Answer = string.Empty;
            try
            {
                WebRequest request = WebRequest.Create("http://api.forismatic.com/api/1.0/?method=getQuote&key=2566&format=json&lang=ru");
                request.Method = "POST";
                request.ContentType = "application/x-www-urlencoded";

                WebResponse response = request.GetResponse();

               

                using (Stream s = response.GetResponseStream())
                {
                    using (StreamReader reader = new StreamReader(s))
                    {
                        Answer = reader.ReadToEnd();

                    }
                }

                response.Close();
                return Answer;
            }
            catch { return Answer; }

        }
        public void savePhoto(string url) // Метод сохранения фотографии на компьютер для дальнейшего использования
        {
            
                using (var load = new HttpRequest())
                {
               
                    load.Get(url).ToFile("Img.png");

                }
           
            

        }
        public string GetQOver() // Метод для получения цитаты с другого цитатника для наложения на текст
        {
            string Answer = string.Empty;
            try
            {
                using (var request = new HttpRequest())
                {
                    Answer = request.Get("http://rzhunemogu.ru/RandJSON.aspx?CType=4").ToString();
                    return Answer;
                }
            }
            catch
            {
                return Answer = "error";

            }


        }
    }

    class hits
    {
        public string largeImageURL { get; set; }

        public Int64 webformatHeight { get; set; }
        public Int64 webformatWidth { get; set; }
        public string webformatURL { get; set; }
        public Int64 imageWidth { get; set; }
        public Int64 imageHeight { get; set; }
        public string ImageUrl { get; set; }

    }
}
