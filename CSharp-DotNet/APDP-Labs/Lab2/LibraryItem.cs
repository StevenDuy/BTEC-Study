namespace Lab2._1;

public abstract class LibraryItem
{
    public string title;
    public string author;
    public string publication_date;
    public bool available;

    public LibraryItem(string title, string author, string publication_date)
    {
        this.title = title;
        this.author = author;
        this.publication_date = publication_date;
        this.available = true;
    }

    public abstract bool checkout();
    public abstract bool return_item();
}