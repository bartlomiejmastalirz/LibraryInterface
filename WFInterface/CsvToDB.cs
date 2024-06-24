using CsvHelper;
using CsvHelper.Configuration;
using Dapper;
using System;
using System.Data.SQLite;
using System.Globalization;
using System.IO;
using System.Linq;

public class CsvToDB
{
    public static void ImportUsers(string csvFilePath, string dbPath)
    {
        using (var connection = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
        {
            connection.Open();

            using (var reader = new StreamReader(csvFilePath))
            using (var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture) { HasHeaderRecord = true }))
            {
                var records = csv.GetRecords<dynamic>().ToList();

                foreach (var record in records)
                {
                    string insertQuery = @"INSERT INTO Users (Login, Password, UserName, UserSurname, IsAdmin, BooksRented)
                                           VALUES (@Login, @Password, @UserName, @UserSurname, @IsAdmin, @BooksRented);";

                    connection.Execute(insertQuery, new
                    {
                        Login = record.Login,
                        Password = record.Password,
                        UserName = record.UserName,
                        UserSurname = record.UserSurname,
                        IsAdmin = bool.Parse(record.IsAdmin) ? 1 : 0,
                        BooksRented = record.BooksRented
                    });
                }
            }
        }
    }

    public static void ImportBooks(string csvFilePath, string dbPath)
    {
        using (var connection = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
        {
            connection.Open();

            using (var reader = new StreamReader(csvFilePath))
            using (var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture) { HasHeaderRecord = true }))
            {
                var records = csv.GetRecords<dynamic>().ToList();

                foreach (var record in records)
                {
                    string insertQuery = @"INSERT INTO Books (Title, Author)
                                           VALUES (@Title, @Author);";

                    connection.Execute(insertQuery, new
                    {
                        BookID = record.BookID,
                        Year = record.Year,
                        Rented = record.Rented,
                        Title = record.Title,
                        Author = record.Author
                    });
                }
            }
        }
    }
}