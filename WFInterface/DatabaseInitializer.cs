using System;
using System.Data.SQLite;
using System.Diagnostics;
using System.IO;

public class DatabaseInitializer
{
    private static readonly string dbPath = "Library.db";

    public static void InitializeDatabase()
    {
        if (!File.Exists(dbPath))
        {
            SQLiteConnection.CreateFile(dbPath);
            Debug.WriteLine($"Created database file: {dbPath}");

            using (var connection = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
            {
                connection.Open();
                Debug.WriteLine("Database connection opened.");

                string createUsersTable = @"
                    CREATE TABLE IF NOT EXISTS Users (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Login TEXT NOT NULL,
                        Password TEXT NOT NULL,
                        UserName TEXT NOT NULL,
                        UserSurname TEXT NOT NULL,
                        IsAdmin INTEGER NOT NULL,
                        BooksRented TEXT
                    );";

                string createBooksTable = @"
                    CREATE TABLE IF NOT EXISTS Books (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Title TEXT NOT NULL,
                        Author TEXT NOT NULL,
                        Year TEXT NOT NULL,
                        IsRented INTEGER NOT NULL
                    );";

                using (var command = new SQLiteCommand(createUsersTable, connection))
                {
                    command.ExecuteNonQuery();
                    Debug.WriteLine("Users table created.");
                }

                using (var command = new SQLiteCommand(createBooksTable, connection))
                {
                    command.ExecuteNonQuery();
                    Debug.WriteLine("Books table created.");
                }
            }
        }
    }
}