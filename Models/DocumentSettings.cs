namespace Models
{
    public class DocumentSettings
    {
        private int documentTypeID;
        private List<string> DocumentFormat = new List<string>();
        private int DocumentSize;
        private string ArabicDocumentName;
        private string EnglishDocumentName;
        private string FormURL;
        private bool IsActiveDocument;
        private Collage UserCollege;

      public int DocumentTypeID
    {
        get => documentTypeID;
        set => documentTypeID = value;
    }

        public void createDocumentSettings()
        {
            Console.WriteLine("A new document has been created.");
        }

        public List<DocumentSettings> getDocument(List<DocumentSettings> List)
        {
            return new List<DocumentSettings>();
        }

        public DocumentSettings getDocument(int id)
        {
            return new DocumentSettings();
        }
        public void deleteDocument()
        {
            Console.WriteLine("Document has been deleted.");
        }

        public void updateDocument()
        {
            Console.WriteLine("Document has been updated.");
        }
    }
}