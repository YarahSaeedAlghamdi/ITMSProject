public enum DocumentStatus
{
    Rejected,
    Approved,
    NewRequest
}
public class DocumentRequest
{
//------------------------------------------------------------------------------------------------
    private Student StudentObj;
    private int DocumentRequestID;
    private DocumentSetting DocumentSettingObj;
    private DocumentStatus DocumentStatus;
    private DateTime CreateDate;
    private string UploadedFilePath;
    bool IsDeleted;
    

//------------------------------------------------------------------------------------------------
    public void CreateDocumentRequest(string filePath)
    {
        DocumentStatus = DocumentStatus.NewRequest;
        CreateDate = DateTime.Now;
	    ploadedFilePath = filePath;

        Console.WriteLine("Document request with ID : {DocumentRequestID} has been created and your file has been uploaded successfully .");
    }
//------------------------------------------------------------------------------------------------

    public void UpdateDocumentRequest(string newFilePath, DocumentSetting newSetting)
    {
        if (newFilePath != null)
        {
            UploadedFilePath = newFilePath;
            Console.WriteLine($"Your file has been changed to: {newFilePath}");
        }

        if (newSetting != null)
        {
            DocumentSettingObj = newSetting;
            Console.WriteLine($"Your new Document setting has been updated to: {newSetting.DocumentType}");
        }

        Console.WriteLine($" Document request with ID: {DocumentRequestID} has been updated and Your new file has been uploaded successfully .");
    }
//------------------------------------------------------------------------------------------------
    public void DeleteDocumentRequest_1()
    {
        // Logic to delete: simulate by clearing fields
        StudentObj = null;
        DocumentSettingObj = null;
        DocumentStatus = default;
        CreateDate = default;
        Console.WriteLine($" Your Document request with ID : {DocumentRequestID} has been deleted successfully.");
    }

   public void DeleteDocumentRequest_2(List<DocumentRequest> allRequests)
   {
    allRequests.Remove(this);
    Console.WriteLine($" Your Document request with ID : {DocumentRequestID} has been deleted successfully.");
   }

   public void DeleteDocumentRequest_3(List<DocumentRequest> allRequests)
   {
    IsDeleted = true;
    Console.WriteLine($" Your Document request with ID : {DocumentRequestID} has been deleted successfully.");
   }

//------------------------------------------------------------------------------------------------

    public int GetDocumentRequestID()
    {
        return DocumentRequestID;
    }
//------------------------------------------ i am not sure: ------------------------------------------------------

    public void ApproveRequest()
    {
        DocumentStatus = DocumentStatus.Approved;
        Console.WriteLine($"[Approved] Document Request ID: {DocumentRequestID}, Status: {DocumentStatus}");

    }

    public void RejectRequest()
    {
        DocumentStatus = DocumentStatus.Rejected;
        Console.WriteLine($"[Rejected] Document Request ID: {DocumentRequestID}, Status: {DocumentStatus}");

    }

    public void InProgress()
    {
        DocumentStatus = DocumentStatus.Rejected;
        Console.WriteLine($"[In Progress] Document Request ID: {DocumentRequestID} is being processed. Current Status: {DocumentStatus}");

    }

//------------------------------------------------------------------------------------------------
}