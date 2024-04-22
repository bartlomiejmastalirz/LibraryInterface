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

namespace LibraryMain
{
    public class Book
    {
        public string Author { get; set; }
        public string Title { get; set; }
        public string Year { get; set; }
        public string BookID { get; set; }
        public bool Rented { get; set; }
    }

    class Library
    {
        static void Main(string[] args)
        {

        }
    }
}