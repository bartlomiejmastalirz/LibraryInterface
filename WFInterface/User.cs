using System.Collections.Generic;

public class User
{
    public string Login { get; set; }
    public string Password { get; set; }
    public string UserName { get; set; }
    public string UserSurname { get; set; }
    public bool IsAdmin { get; set; }
    public List<int> BooksRented { get; set; }
    public string BooksRentedString { get; set; }
}

public class Books
{
    public int BookID { get; set; } = 0;
    public string Title { get; set; } = "";
    public string Author { get; set; } = "";
    public string Year { get; set; } = "";
    public bool Rented { get; set; } = false;
}