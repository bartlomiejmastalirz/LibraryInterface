using System;
using System.Data.SQLite;
using System.Security.Cryptography;
using System.Text;

namespace WFInterface
{
    public class AddUser
    {
        private static string dbPath = "Library.db";

        public static void AddUserToDatabase(string login, string password, string userName, string userSurname, bool isAdmin = false, string booksRented = "")
        {
            string hashedPassword = HashPassword(password);

            using (var connection = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
            {
                connection.Open();

                // Check if user already exists
                string checkQuery = "SELECT COUNT(*) FROM Users WHERE Login = @Login";
                using (var checkCommand = new SQLiteCommand(checkQuery, connection))
                {
                    checkCommand.Parameters.AddWithValue("@Login", login);
                    long userCount = (long)checkCommand.ExecuteScalar();

                    if (userCount > 0)
                    {
                        throw new Exception("User with this login already exists.");
                    }
                }

                // Insert new user
                string query = "INSERT INTO Users (Login, Password, UserName, UserSurname, IsAdmin, BooksRented) " +
                               "VALUES (@Login, @Password, @UserName, @UserSurname, @IsAdmin, @BooksRented)";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Login", login);
                    command.Parameters.AddWithValue("@Password", hashedPassword);
                    command.Parameters.AddWithValue("@UserName", userName);
                    command.Parameters.AddWithValue("@UserSurname", userSurname);
                    command.Parameters.AddWithValue("@IsAdmin", isAdmin);
                    command.Parameters.AddWithValue("@BooksRented", booksRented);

                    command.ExecuteNonQuery();
                }
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