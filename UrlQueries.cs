using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Windows.Forms;

// using Newtonsoft.Json;


namespace WindowsFormsApp2
{
    internal class UrlQueries
    {
        private readonly DBHelper dBHelper = new DBHelper();

        // Обновить токен
        public (int, string) RefreshToken(string refresh_token)
        {
            //ендпоинт
            string address = "https:///jwt-auth/connect/token";

            Dictionary<string, string> Params = new Dictionary<string, string>()
            {
                {"grant_type", "refresh_token" },
                {"refresh_token",  refresh_token},
            };

            // создать клиент запроса
            HttpClient client = new HttpClient();

            //отправить запрос
            return (PostRequest(client, address, Params));
        }
        
        // Получить токен
        public (int, string) AuthGetAccessToken(string login, string password)
        {
            //ендпоинт
            string address = "https:///jwt-auth/connect/token";

            Dictionary<string, string> Params = new Dictionary<string, string>()
            {
                {"grant_type", "password" },
                {"scope", "frontend offline_access" },
                {"username", login },
                {"password", password }
            };

            // создать клиент запроса
            HttpClient client = new HttpClient();

            //отправить запрос
            return(PostRequest(client, address, Params));
        }

        public (int, string) GetMe(string access_token)
        {
            string url = "https:///api/native/v2.0/users/me";

            // создать клиент запроса
            HttpClient client = new HttpClient();

            // Добавить header с авторизацией
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + access_token);

            var response = client.GetAsync(url);
            return ((int)response.Result.StatusCode, response.Result.Content.ReadAsStringAsync().Result);

            

        }

        // Отправить запрос в ЭО
        public (int, string) SendQuerry(string access_token, string dateTimeUTC)
        {
            //errorlable.Text = "Выполняется отправка запроса";

            string url = "https://api./api/terminal/v1/Export/ParameterInfo";

            var Params = new
            {
                TerminalTimeslotVehicleId = 31421423, //TerminalTimeslotVehicleId.Text,
                terminalWeightUnloadedNetto = 21.3, // Double.Parse(terminalWeightUnloadedNetto.Text),
                terminalWeightUnloadedBrutto = 12.3, // Double.Parse(terminalWeightUnloadedBrutto.Text),
                terminalHadLeftDateTime = dateTimeUTC
            };

            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + access_token);

            return PostRequestEQ(client, url, Params);

           
        }

        // Авторизация


        // Отправить запрос при авторизации
        static (int, string) PostRequest(HttpClient client, string address, Dictionary<string, string> Params)
        {
            try
            {
                Uri uri = new Uri(address);
                FormUrlEncodedContent content = new FormUrlEncodedContent(Params);
                // отправка запроса
                var response = client.PostAsync(address, content);

                return ((int)response.Result.StatusCode, response.Result.Content.ReadAsStringAsync().Result);
            }
            catch (Exception x)
            {
                Console.WriteLine("Error " + x.ToString());
            }
            finally
            {
                client.Dispose();
            }
            return (0, "Ошибка отправки запроса. Проверьте интернет-соединение.");
        }


        

        // Отправить запрос в ЭО
        static (int, string) PostRequestEQ(HttpClient client, string address, object Params)
        {
            try
            {
                // Uri uri = new Uri(address);
                var jsonPayload = JsonSerializer.Serialize(Params);
                var httpContent = new StringContent(jsonPayload, Encoding.UTF8, "application/json");
                // отправка запроса
                var response = client.PostAsync(address, httpContent);

                return ((int)response.Result.StatusCode, response.Result.Content.ReadAsStringAsync().Result);
            }
            catch (Exception x)
            {
                Console.WriteLine("Error " + x.ToString());
            }
            finally
            {
                client.Dispose();
            }
            return (0, "Ошибка отправки запроса. Проверьте интернет-соединение.");
        }
    }
}
