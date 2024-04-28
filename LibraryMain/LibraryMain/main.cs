// To-Do list
// Make a login screen for the user to provide his credentials (login and password) - DONE (scuffed for now)
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
using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace LibraryMain
{
    //This is the Book class containing all book data
    public class Book
    {
        public int BookID { get; set; }
        public string Author { get; set; } = "";
        public string Title { get; set; } = "";
        public int Year { get; set; }  
        public bool Rented { get; set; }
    }
    //This is the User class containing all user data
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
 

        //Just ASCII art of the menu top, will be using this a lot
        static void MenuScreen()
        {
            Console.WriteLine(@"
              _      _ _                            _____       _             __               
             | |    (_) |                          |_   _|     | |           / _|              
             | |     _| |__  _ __ __ _ _ __ _   _    | |  _ __ | |_ ___ _ __| |_ __ _  ___ ___ 
             | |    | | '_ \| '__/ _` | '__| | | |   | | | '_ \| __/ _ \ '__|  _/ _` |/ __/ _ \
             | |____| | |_) | | | (_| | |  | |_| |  _| |_| | | | ||  __/ |  | || (_| | (_|  __/
             |______|_|_.__/|_|  \__,_|_|   \__, | |_____|_| |_|\__\___|_|  |_| \__,_|\___\___|
                                             __/ |                                             
                                            |___/                                              
            ");
        }

        //Method to initiate the login screen
        static void LoginScreen()
        {
            Console.Clear();
            MenuScreen();
            Console.WriteLine("Please input your login credentials: ");

            //Feels like a really slow way of searching for a user login but will do for now
            try
            {
                if (File.Exists("users.csv"))
                {
                    using (var reader = new StreamReader("users.csv"))
                    using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                    {
                        var records = csv.GetRecords<User>();

                        Console.WriteLine("Login: ");
                        string login = Console.ReadLine();

                        foreach (User user in records)
                        {
                            if (user.Login == login)
                            {
                                Console.WriteLine("Password: ");
                                string password = Console.ReadLine();

                                if (user.Password == password)
                                {
                                    LoginComplete(user.UserName, user.UserSurname, user.IsAdmin);
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Invalid Password");
                                    Thread.Sleep(2000);
                                    LoginScreen();
                                }
                            }

                        }
                        //GET THIS OUT OF HERE, SO IT CHECKS WHEN THE USER ACTUALLY ENTERED WRONG LOGIN
                        Console.WriteLine("Invalid Login");
                        Thread.Sleep(2000);
                        LoginScreen();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Initiates after succesful user login
        static void LoginComplete(string userName, string userSurname, bool isAdmin)
        {
            Console.Clear();
            MenuScreen();
            Console.WriteLine("Good day to you " + userName + " " + userSurname + "!\nWhat do you want to do?\n" +
                "(Search)Search for a book | (Rent)Rent a book with provided ID | (Check)Check your rented books");

            if (isAdmin==true)
            {
                Console.WriteLine("\nYou are logged in as an Admin user. What do you want to do? \n" +
                    "(AddBook)Add a book | (DelBook)Delete a book | (AddUser)Add a user | (DelUser)Delete a user"); 
            }
        }

        static void Main(string[] args)
        {



            //!!!!!!!!!!!
            //DO NOT UNCOMMENT UNLESS THERE IS A "DUPLICATE CHECKER" METHOD and Admin functionality is added
            //!!!!!!!!!!!
            //var bookObjects = new List <Book> ()
            //{
            //    new Book
            //    {
            //        BookID = 1, Author = "testName", Title = "goodBook", Year = 2024, Rented = false    
            //    }
            //};

            //var userObjects = new List<User>()
            //{
            //    new User
            //    {
            //        Login = "login", Password = "password", UserName = "AdminTest", UserSurname = "Number1", IsAdmin = true
            //    }
            //};

            //This will be used when Admin functionality is added
            //using var userWriter = new StreamWriter(@"users.csv", true);
            //using var userCsv = new CsvWriter(userWriter, CultureInfo.InvariantCulture);
            //{
            //    userCsv.WriteRecords(userObjects);
            //}

            //using var bookWriter = new StreamWriter(@"books.csv", true);
            //using var bookCsv = new CsvWriter(bookWriter, CultureInfo.InvariantCulture);
            //{
            //    bookCsv.WriteRecords(userObjects);
            //}
            LoginScreen();
            Console.ReadKey();
        }
    }
}