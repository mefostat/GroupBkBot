using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xNet;

namespace QuateDi
{
    class ApiQuery
    { // ОБЯЗАТЕЛЬНО ДОБАВИТЬ ОБРАБОТКУ ИСКЛЮЧЕНИЙ
        public string GetUrlServer(string token, Int32 group_id) // Url для загрузки фото
        {
            var JsUr = string.Empty;
            using (var request = new HttpRequest())
            {
                var param = new RequestParams();

                param["group_id"] = group_id;
                param["access_token"] = token;
                param["v"] = "5.80";

                JsUr = request.Post("https://api.vk.com/method/photos.getWallUploadServer?", param).ToString();
             }
            JsUr = Pars(JsUr, "upload_url\":\"", "\"", 0).Replace("\\", ""); // Вырываем из JSON upload_url
            return JsUr; 
           }
        // Костыль для парса
        private string Pars(string strSource, string strStart, string strEnd, int startPos)
        {
            try
            {
                int length = strStart.Length;
                string str = "";
                int num1 = strSource.IndexOf(strStart, startPos);
                int num2 = strSource.IndexOf(strEnd, num1 + length);
                if (num1 != -1 & num2 != -1)
                    str = strSource.Substring(num1 + length, num2 - (num1 + length));
                return str;
            }
            catch { return ""; }
        }
        // Загрузка изображения на полученный сервер в методе GetUrlServer
        public string LoadPhoto(string url, string dirPhoto) 
        {
            string Answer = string.Empty;
            using (var load = new HttpRequest())
            {
                load.AddField("photo").AddFile("file", dirPhoto);

                Answer = load.Post(url).ToString();
            }

            return Answer;
        }
        // Сохранение фото на сервере 
        public string SavePhoto(Int32 user_id,string photo,Int32 group_id,string server,string hash,string token)
        {
            string Answer = string.Empty;
            using (var save = new HttpRequest())
            {
                var param = new RequestParams();
                param["group_id"] = group_id;
                param["user_id"] = user_id;
                param["photo"] = photo;
                param["server"] = server;
                param["hash"] = hash;
                param["access_token"] = token;
                param["v"] = "5.80";

                Answer = save.Post("https://api.vk.com/method/photos.saveWallPhoto?", param).ToString();
            }

            return Answer; // Json объект 
        }
        
        // Создание и отправка поста с изображением 
        public string WallPost(Int32 owner_id, string query, string token) 
        {
            string Answer = string.Empty;
            try
            {
                using (var loadpost = new HttpRequest())
                {

                    var param = new RequestParams();
                    param["owner_id"] = "-" + owner_id;
                    param["from_group"] = 1;
                    param["attachments"] = query;
                   
                    param["access_token"] = token;
                    param["v"] = "5.80";

                    Answer = loadpost.Post("https://api.vk.com/method/wall.post?attachments=", param).ToString();


                }
            }
            catch
            {
                return Answer = "error";
            }
            return Answer;
        }
        public string WallPostandMess(Int32 owner_id, string query, string token, string quate)
        {
            string Answer = string.Empty;
            try
            {
                using (var loadpost = new HttpRequest())
                {
                    
                    var param = new RequestParams();
                    param["owner_id"] = "-" + owner_id;
                    param["from_group"] = 1;
                    param["attachments"] = query;
                    param["message"] = quate;
                    param["access_token"] = token;
                    param["v"] = "5.80";

                    Answer = loadpost.Post("https://api.vk.com/method/wall.post?attachments=", param).ToString();


                }
            }
            catch
            {
                return Answer = "error";
            }
            return Answer;
        }

        /*public string GetGroup(Int32 user_id,string token)
        {
            string Answer = string.Empty;
            try
            {
                using (var loadpost = new HttpRequest())
                {

                    var param = new RequestParams();
                    param["user_id"] = user_id;
                    param["filter"] = "moder";
                    param["access_token"] = token;
                    param["v"] = "5.80";

                    Answer = loadpost.Post("https://api.vk.com/method/groups.get?", param).ToString();


                }
            }
            catch
            {
                return Answer = "error";
            }
            return Answer;

        } */
    
    }
 

}
     
    



