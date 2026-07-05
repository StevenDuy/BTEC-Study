namespace Lab2._1;

public class DVD : LibraryItem
{
    private int runtime; // in minutes

    public DVD(string title, string author, string publication_date, int runtime) 
        : base(title, author, publication_date)
    {
        this.runtime = runtime;
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