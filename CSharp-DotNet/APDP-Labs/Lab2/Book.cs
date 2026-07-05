namespace Lab2._1;

public class Book : LibraryItem
{
    private string genre;

    public Book(string title, string author, string publication_date, string genre) 
        : base(title, author, publication_date)
    {
        this.genre = genre;
    }

    public override bool checkout()
    {
        if (available)
        {
            available = false;
            return true;
        }
        return false;
    }

    public override bool return_item()
    {
        if (!available)
        {
            available = true;
            return true;
        }
        return false;
    }
}