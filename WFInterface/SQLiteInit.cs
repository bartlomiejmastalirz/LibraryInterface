using System;
using System.Data.SQLite;
using System.IO;

public class SQLiteInit
{
    public static void InitializeDatabase(string dbPath)
    {
        if (!File.Exists(dbPath))
        {
            SQLiteConnection.CreateFile(dbPath);

            using (var connection = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
            {
                connection.Open();

                string userTable = @"CREATE TABLE Users (
                                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                    Login TEXT NOT NULL,
                                    Password TEXT NOT NULL,
                                    UserName TEXT NOT NULL,
                                    UserSurname TEXT NOT NULL,
                                    IsAdmin INTEGER NOT NULL,
                                    BooksRented TEXT
                                    );";

                string bookTable = @"CREATE TABLE Books (
                                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                    Title TEXT NOT NULL,
                                    Author TEXT NOT NULL,
                                    Year INTEGER NOT NULL,
                                    IsRented INTEGER NOT NULL
                                    );";

                using (var command = new SQLiteCommand(userTable, connection))
                {
                    command.ExecuteNonQuery();

                    Console.WriteLine("Users table created.");
                }

                using (var command = new SQLiteCommand(bookTable, connection))
                {
                    command.ExecuteNonQuery();

                    Console.WriteLine("Books table created.");
                }
            }
        }
    }
}