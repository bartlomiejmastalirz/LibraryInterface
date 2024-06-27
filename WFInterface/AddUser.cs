using System;
using System.Data.SQLite;
using System.Security.Cryptography;
using System.Text;

namespace WFInterface
{
    public class AddUser
    {
        private static string dbPath = "Library.db";

        public static void InitializeDatabase()
        {
            if (!File.Exists(dbPath))
            {
                SQLiteConnection.CreateFile(dbPath);

                using (var connection = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
                {
                    connection.Open();

                    string createUsersTable = @"
                    CREATE TABLE IF NOT EXISTS Users (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Login TEXT NOT NULL,
                        Password TEXT NOT NULL,
                        UserName TEXT NOT NULL,
                        UserSurname TEXT NOT NULL,
                        IsAdmin INTEGER NOT NULL
                    );";

                    using (var command = new SQLiteCommand(createUsersTable, connection))
                    {
                        command.ExecuteNonQuery();
                    }

                    connection.Close();
                }
            }
        }

        public static void AddUserToDatabase(string login, string password, string userName, string userSurname, bool isAdmin)
        {
            string connectionString = $"Data Source={dbPath};Version=3;";

            // Hash the password
            string hashedPassword = HashPassword(password);

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string insertQuery = @"
                INSERT INTO Users (Login, Password, UserName, UserSurname, IsAdmin)
                VALUES (@Login, @Password, @UserName, @UserSurname, @IsAdmin)";

                using (var command = new SQLiteCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@Login", login);
                    command.Parameters.AddWithValue("@Password", hashedPassword);
                    command.Parameters.AddWithValue("@UserName", userName);
                    command.Parameters.AddWithValue("@UserSurname", userSurname);
                    command.Parameters.AddWithValue("@IsAdmin", isAdmin ? 1 : 0);

                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
        }

        private static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}