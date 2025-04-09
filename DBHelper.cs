using System;
using System.Data.SqlClient;


namespace WindowsFormsApp2
{
    internal class DBHelper
    {
        // внести данные в БД
        public void Set_auth_data_in_database(string contacr_fullname, string profileDetails, string access_token, string refresh_token)
        {
            SqlDataReader reader = SendRequest($"UPDATE Table1 SET username = N'{contacr_fullname}', organization_name = N'{profileDetails}', access_token = '{access_token}', refresh_token = '{refresh_token}' WHERE Id = 1");
            reader.Close();
        }

        // очистить данные в БД
        public void Clear_data_in_db()
        {
            SqlDataReader reader = SendRequest("UPDATE Table1 SET username = NULL, organization_name = NULL, access_token = NULL, refresh_token = NULL WHERE Id = 1");
            reader.Close();
        }

        public (string, string) Get_fullname_and_orgname_from_db()
        {
            using (SqlDataReader reader = SendRequest("SELECT username, organization_name FROM Table1 WHERE Id = 1"))
            {
                if (reader.Read())
                {
                    return (reader["username"].ToString(), reader["organization_name"].ToString());
                }
                else
                {
                    return ("", "");
                }
            }
        }

        // авторизован ли пользователь
        public bool Is_user_auth()
        {
            using (SqlDataReader reader = SendRequest("SELECT * FROM Table1 WHERE id = 1 AND refresh_token IS NOT NULL"))
            {
                // Проверяем, наличие записей в таблице
                if (reader.HasRows)
                {
                    reader.Close();
                    return true;
                }
                else
                {
                    reader.Close();
                    return false;
                }
            }
        }

        // получить список данных из БД
        public string Get_data_from_db()
        {
            using (SqlDataReader reader = SendRequest("SELECT * FROM Table1 WHERE Id = 1"))
            {
                string allData = "";

                // Читаем данные из базы и добавляем их в строку
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        allData += reader[i].ToString() + ";;; "; // Добавляем данные из каждой колонки
                    }
                    allData += Environment.NewLine; // Перенос строки между записями
                }
                return allData;
            }
        }

        // получить refresh_token
        public string Get_refresh_token_from_db()
        {
            using (SqlDataReader reader = SendRequest("SELECT refresh_token FROM Table1 WHERE Id = 1"))
            {
                if (reader.Read()) // Проверяем, есть ли строки в результате
                {
                    return reader.GetString(0); // Извлекаем значение из колонки refresh_token
                }
                else
                {
                    return null; // Если строки нет, возвращаем null или обрабатываем иначе
                }
            }
        }

        public void Set_refresh_token_from_db(string access_token, string refresh_token)
        {
            using (SqlDataReader reader = SendRequest($"UPDATE Table1 SET access_token = '{access_token}', refresh_token = '{refresh_token}' WHERE Id = 1"))
            {
                if (reader.Read())
                {
                    reader.Close();
                }
            }
        }


        // выполнение запроса
        private SqlDataReader SendRequest(string query)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            return reader;
        }
    }
}
