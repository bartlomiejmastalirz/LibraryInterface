public class User
{
    public string Login { get; set; } = "";
    public string Password { get; set; } = "";
    public string UserName { get; set; } = "";
    public string UserSurname { get; set; } = "";
    public bool IsAdmin { get; set; } = false;
    public List<int> BooksRented { get; set; } = new List<int>(); // List of rented book IDs

    public void ParseBooksRented(string booksRented)
    {
        if (!string.IsNullOrEmpty(booksRented))
        {
            BooksRented = booksRented.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                                     .Select(int.Parse)
                                     .ToList();
        }
    }
}
public class Books
{
    public int BookID { get; set; } = 0;
    public string Title { get; set; } = "";
    public string Author { get; set; } = "";
    public string Year { get; set; } = "";
    public bool Rented { get; set; } = false;
}