// To-Do list
// Make two csv files - users and books, for testing purposes add like two users and books 
// Make a login screen for the user to provide his credentials (login and password)
// Make a main menu screen where the user sees his Name and Surname and can choose: Search|Check rented books status|Rent a book
// 
// Make an ADMIN account that can add users and books to csv files
// Book csv could be sorted by IDs, to make it easier to assign for renting - e.g. User1 rents Book1 with ID of 1; Book1 has its ID added to 
//      booksRented of User1.
//
// Try to avoid a problem with removing a book from the "library" that is already rented - make a flag for books, as in "isRented True/False"
//      if it's rented, then disable deleting it. Unless we want to do something with ADMIN being able to manually delete it from the User data.
//
// If a book is rented out, use the above flag to display till when it's unavailable. For added complexity add a "reservation" check for next user
//      to rent out a book when it's available.
//
//
// MORE IDEAS GO HERE, PROGRAMMING STARTS SOON, REMEMBER TO USE "live1" BRANCH FOR ANY PUSH REQUESTS AND DON'T PUSH DIRECTLY TO MAIN
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using System.Globalization;
using System.IO;
using System.Net.Http.Headers;

namespace LibraryMain
{
    //This is the Book class containing all the info for how it is put into the csv
    public class Book
    {
        public int BookID { get; set; }
        public string Author { get; set; } = "";
        public string Title { get; set; } = "";
        public int Year { get; set; }  
        public bool Rented { get; set; }
    }

    public class User
    {
        public string Login { get; set; } = "";
        public string Password { get; set; } = "";
        public string UserName { get; set; } = "";
        public string UserSurname { get; set; } = "";
        public bool IsAdmin { get; set; } = false;
    }

    class Library
    {
        static void Main(string[] args)
        {
            var bookObjects = new List <Book> ()
            {
                new Book
                {
                    BookID = 1, Author = "testName", Title = "goodBook", Year = 2024, Rented = false    
                }
            };

            var userObjects = new List<User>()
            {
                new User
                {
                    Login = "login", Password = "password", UserName = "AdminTest", UserSurname = "Number1", IsAdmin = true
                }
            };
            //
            //Console.WriteLine(Directory.GetCurrentDirectory().GetType());
            //
            using var writer = new StreamWriter(@"users.csv");
            using var csv = new CsvWriter(writer, CultureInfo.InvariantCulture);
            {
                csv.WriteRecords(userObjects);
            }

        }
    }
}