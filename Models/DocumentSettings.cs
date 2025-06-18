public class DocumentSettings
{
    private int DocumentTypeID;
    private List<string> DocumentFormat = new List<string>();
    private int DocumentSize;
    private string ArabicDocumentName;
    private string EnglishDocumentName;
    private string FormURL;
    private bool IsActiveDocument;

    public void CreateNewDocument()
    {
        Console.WriteLine("A new document has been created.");
    }

    public void GetDocument()
    {
        Console.WriteLine("Document has been retrieved.");
    }

    public void GetDocument(int id)
    {
        Console.WriteLine($"Document with ID {id} has been retrieved.");
    }

    public void DeleteDocument()
    {
        Console.WriteLine("Document has been deleted.");
    }

    public void UpdateDocument()
    {
        Console.WriteLine("Document has been updated.");
    }
}