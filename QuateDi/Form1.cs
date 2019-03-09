using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using xNet;
using Newtonsoft.Json.Linq;
using System.Text.RegularExpressions;
using System.Net;
using System.IO;
namespace QuateDi
{
    public partial class Form1 : Form
    {
        //Глоб.Переменные для обработки
        public string token;  // Токен для входа в Вк
        public Int32 user_id; // Id пользователя
        public Int32 group_id; // Id группы
        string quate = string.Empty;
        ApiQuery Answer = new ApiQuery();
        string dirImg = Application.StartupPath; // Директория с программой
        string date = string.Empty; // Время
        public void LoadSetting()
        {
            date = DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second; // Время
            string login = string.Empty;
            string pass = string.Empty;
            Int64 group;
            using (StreamReader text = new StreamReader(dirImg + @"\settings.json"))
            {
                dynamic settings = JObject.Parse(text.ReadToEnd());

                login = settings.login;
                pass = settings.password;
                group = settings.group_id;
            }
            string flag = Authorizator(login, pass);
            if (flag != "0")
            {
             
                dynamic pars = JObject.Parse(flag);
                token = pars.access_token; // Сохраняем токен для дальнейшего использования
                user_id = pars.user_id; // ID пользователя 
                Log.AppendText("Authorization succeeded  " + date + "\r\n"); // Авторизация удалась
                group_id = Convert.ToInt32(group);
                id.Text = "ID: " + user_id;

                textBox1.Text = "-" + group;



            }
            else
            {
                Log.AppendText("Authorization failed " + date + "\r\n"); // Авторизация не удалась
            }

        }
        public Form1()
        {
            InitializeComponent();
            select.SelectedIndexChanged += select_SelectedIndexChanged;
            
        }

        
        private void Connect_Click(object sender, EventArgs e)
        {

            LoadSetting();
            
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }


        private string Authorizator(string p1, string p2) // Метод авторизации
        {
            using (var AuthVk = new HttpRequest())
            {
                var Params = new RequestParams();
                string JsCode = string.Empty; // Строка в которую сохранится JSON
                // Параметры для авторизации
                Params["username"] = p1;
                Params["password"] = p2;
                try
                {
                    // Авторизация
                    JsCode = AuthVk.Post("https://oauth.vk.com/token?grant_type=password&client_id=3697615&client_secret=AlVXZFMUqyrnABp8ncuU", Params).ToString(); 
                }
                catch
                {
                    MessageBox.Show("ERROR Auth");
                    return JsCode = "0";
                }
                return JsCode;
            }
        }
        ImgAd Draw = new ImgAd();
        private void button1_Click(object sender, EventArgs e)
        {
            date = DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second; // Время
          /*  // Получаем JSON с цитатой
            string Jsonquate = Draw.GetQuote();
            dynamic Jq = JObject.Parse(Jsonquate); //Парсим
            string quate = Jq.quoteText;
            // Рисуем текст на изображении
            Quate.Text = quate;
            Img.ImageLocation = Draw.LoadPicture(Draw.GetPicture(category)); // Загружаем изображение в pictureBox

            /*
             Graphics img;
             img = Graphics.FromImage(Img.Image);
             Draw.DrawText(img, SplitToLines(quate), new PointF(120, 50), Img.Image);*/
            //Img.Image.Save("img.png", System.Drawing.Imaging.ImageFormat.Png);  // Сохраняем изображение

        /*
            var answer = new ApiQuery();
            string js_st = answer.LoadPhoto(Answer.GetUrlServer(token, group_id), @"C:\Users\YaK\Documents\Visual Studio 2012\Projects\QuateDi\QuateDi\bin\Debug\Img.png"); // Загрузка фото на полученный сервер

            dynamic js = JObject.Parse(js_st);
            string photo = js.photo;
            string server = js.server;
            string hash = js.hash;

            string id_photo = Answer.SavePhoto(user_id, photo, group_id, server, hash, token); // Сохраняем фото на сервере
            // Костыль для получения id, ибо не мог спарсить
            var id = Regex.Replace(id_photo, @"[^\d]+", "");
            string ss = string.Empty;
            for (int i = 0; i <= 8; i++) // Значение 8 может поменяться со временем следить за этим фактом. 
            {
                ss += id[i];
            }
            if (ss != null && id != "0")
            {
                Log.AppendText("Save Photo - Good" + "\r\n");
            }
            // Конец костыля || УБРАТЬ ПРИ ВОЗМОЖНОСТИ
            string query = "photo" + user_id + "_" + ss + ",photo" + textBox1.Text + "_" + ss;

            string resultWallPost = Answer.WallPostandMess(group_id, query, token, quate);

            if (resultWallPost != "error")
            {
                Log.AppendText("Post successfully added" + "\r\n");
            }
            else
            {
                Log.AppendText("Post failed to add" + "\r\n");
            }
             */ 

            timer1.Enabled = true;
            button1.Enabled = false;
            Log.AppendText("Starting  " + date + "\r\n");

        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            
        }
        public static string SplitToLines(string str)
        {

            return Regex.Replace(str, @"\.", "\r\n");

        }
        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }
        public string category ;
        private void select_SelectedIndexChanged(object sender, EventArgs e)
        {
            category = select.SelectedItem.ToString();
            Img.ImageLocation = dirImg + @"\Img.png";
        }
        Int32 count;
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            date = DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second;
            Random rand = new Random();
            Int32 random;
            if (checkCr1.Checked == true)
            {
                category = select.SelectedItem.ToString();
            }
            else
            {
                random = rand.Next(0, select.Items.Count); // Рандомный выбор категории фото
                Thread.Sleep(1000);
                category = select.Items[random].ToString(); 
            }


            if (randQ.Checked != true)
            {
                // Получаем JSON с цитатой
                string Jsonquate = Draw.GetQuote();
                dynamic Jq = JObject.Parse(Jsonquate); //Парсим
                quate = Jq.quoteText;
                
                Quate.Text = quate;
            }
            else
            {
                quate =
                    Draw.GetAltQuote();
               
                Quate.Text = quate;

            }
            if (RandomDouble.Checked == true)
            {
                quate = Draw.RandomDoubleQuote();
                Quate.Text = quate;
                
            }

            this.Text = Draw.s;

            
         
            Draw.savePhoto(Draw.LoadPicture(Draw.GetPicture(category,true))); // Решения для загрузки фотки в фоне. 
            Img.ImageLocation = dirImg + @"\Img.png";  // обновляем ImgBox
            var answer = new ApiQuery();
            string js_st = answer.LoadPhoto(Answer.GetUrlServer(token, group_id), dirImg + @"\Img.png"); // Загрузка фото на полученный сервер

            dynamic js = JObject.Parse(js_st);
            string photo = js.photo;
            string server = js.server;
            string hash = js.hash;
            
            string id_photo = Answer.SavePhoto(user_id, photo, group_id, server, hash, token); // Сохраняем фото на сервере
            // Костыль для получения id, ибо не мог спарсить
            var id = Regex.Replace(id_photo, @"[^\d]+", "");
            string ss = string.Empty;
            for (int i = 0; i <= 8; i++) // Значение 8 может поменяться со временем следить за этим фактом. 
            {
                ss += id[i];
            }
            if (ss != null && id != "0")
            {
                Log.AppendText("Save Photo - Good  " + date + "\r\n");
            }
            // Конец костыля || УБРАТЬ ПРИ ВОЗМОЖНОСТИ
            string query = "photo" + user_id + "_" + ss + ",photo" + textBox1.Text + "_" + ss;

            string resultWallPost = Answer.WallPostandMess(group_id, query, token, quate);

            if (resultWallPost != "error")
            {
                Log.AppendText("Post successfully added  " + date + "\r\n");
                count++;
                valPost.Text = "Post count: " + count;
                
            }
            else
            {
                Log.AppendText("Post failed to add" + "\r\n");
            }

            
            
            
        }

        private void five_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Interval = 300000;
            timer2.Interval = 300000;
        }

        private void tenn_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Interval = 600000;
            timer2.Interval = 600000;
        }

        private void there_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Interval = 1800000;
            timer2.Interval = 1800000;
        }

        

        private void OneMin_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Interval = 60000;
            timer2.Interval = 60000;
        }

        private void min20_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Interval = 1200000;
            timer2.Interval = 1200000;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }
        public static string SplitToLines2(string str)
        {

            string st = Regex.Replace(str, "/.", ",\r\n");
            return Regex.Replace(st, ";", ",\r\n");
        }
        Font font = new Font("Oswald", 18);
        Overlay overlay = new Overlay();
        private void button2_Click_2(object sender, EventArgs e)
        {
            button1.Enabled = false;
            timer2.Enabled = true;
            
           

        }
      
      
        /// Метод для обрезки изображения
        private static Image cropImage(Image img, Rectangle cropArea)
        {
            Bitmap bmpImage = new Bitmap(img);

            return bmpImage.Clone(cropArea, bmpImage.PixelFormat);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            date = DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second;
            Random rand = new Random();
            Int32 random;
            if (checkCr1.Checked == true)
            {
                category = select.Items[select.SelectedIndex].ToString();
            }
            else
            {
                random = rand.Next(0, select.Items.Count); // Рандомный выбор категории фото

                category = select.Items[random].ToString();
            }
           
            string GetPic = Draw.GetPicture(category, true);
            GetPic = Draw.LoadPicture(GetPic);
            Draw.savePhoto(GetPic);
           
            string jsAnswer = Draw.GetQOver();

            dynamic quote = JObject.Parse(jsAnswer);
            jsAnswer = quote.content;
            Quate.Text = quote.content;
            Image images = Image.FromFile("Img.png");

            Img.Image = images;
            Img.Image = cropImage(Img.Image, new Rectangle(0, 0, 800, 500));
            Graphics img = Graphics.FromImage(Img.Image);

            overlay.DrawText(img, SplitToLines(Quate.Text), font);
            Img.Image.Save("crop.png", System.Drawing.Imaging.ImageFormat.Png);
            images.Dispose();

            


            
            var answer = new ApiQuery();
            string js_st = answer.LoadPhoto(Answer.GetUrlServer(token, group_id), dirImg+@"\crop.png"); // Загрузка фото на полученный сервер

            dynamic js = JObject.Parse(js_st);
            string photo = js.photo;
            string server = js.server;
            string hash = js.hash;

            string id_photo = Answer.SavePhoto(user_id, photo, group_id, server, hash, token); // Сохраняем фото на сервере
            // Костыль для получения id, ибо не мог спарсить
            var id = Regex.Replace(id_photo, @"[^\d]+", "");
            string ss = string.Empty;
            for (int i = 0; i <= 8; i++) // Значение 8 может поменяться со временем следить за этим фактом. 
            {
                ss += id[i];
            }
            if (ss != null && id != "0")
            {
                Log.AppendText("Save Photo - Good  " + date + "\r\n");
            }
            // Конец костыля || УБРАТЬ ПРИ ВОЗМОЖНОСТИ
            string query = "photo" + user_id + "_" + ss + ",photo" + textBox1.Text + "_" + ss;

            string resultWallPost = Answer.WallPost(group_id, query, token);
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            date = DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second; // Время
            Log.AppendText("Stoping  " + date + "\r\n");
            timer1.Enabled = false;
            button1.Enabled = true;
        }

        private void RandomDouble_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void randQ_CheckedChanged(object sender, EventArgs e)
        {

        }
        
        
        
    }
}
