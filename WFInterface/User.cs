using CsvHelper;
using static System.Reflection.Metadata.BlobBuilder;
using System.Globalization;

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
public class Book
{
    public int BookID { get; set; } = 0;
    public string Title { get; set; } = "";
    public string Author { get; set; } = "";
    public string Year { get; set; } = "";
    public bool Rented { get; set; } = false;


    //Method that loads books from csv
    public static List<Book> LoadBooksFromCsv(string filePath)
    {
        List<Book> allBooks;

        using (var reader = new StreamReader(filePath))
        using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
        {
            allBooks = csv.GetRecords<Book>().ToList();
        }

        // Sort books by year in descending order
        allBooks = allBooks.OrderByDescending(book => int.Parse(book.Year)).ToList();

        return allBooks;
    }
}

public class Audiobook : Book
{
    public int lenMinutes { get; set; } = 0;

    public static List<Audiobook> LoadAudiobooksFromCsv(string filePath)
    {
        List<Audiobook> allAudiobooks;

        using (var reader = new StreamReader(filePath))
        using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
        {
            allAudiobooks = csv.GetRecords<Audiobook>().ToList();
        }

        // Sort audiobooks by year in descending order
        allAudiobooks = allAudiobooks.OrderByDescending(audiobook => int.Parse(audiobook.Year)).ToList();

        return allAudiobooks;
    }
}