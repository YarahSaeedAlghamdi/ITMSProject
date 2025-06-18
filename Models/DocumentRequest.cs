

public enum DocumentStatus
{
    Rejected,
    Approved,
    NewRequest
}

public class DocumentRequest : IapprovalStatus {
//------------------------------------------------------------------------------------------------
    private Student studentObj;
    private int documentRequestID;
    private DocumentSetting documentSettingObj;
    private DocumentStatus documentStatus;
    private DateTime createDate;
    private string uploadedDocumentPath;
    private bool IsDeleted;

    
//------------------------------------------------------------------------------------------------
public Student StudentObj
    {
        get => studentObj;
        set => studentObj = value;
    }

    public int DocumentRequestID
    {
        get => documentRequestID;
        set => documentRequestID = value;
    }

    public DocumentSetting DocumentSettingObj
    {
        get => documentSettingObj;
        set => documentSettingObj = value;
    }

    public DocumentStatus DocumentStatus
    {
        get => documentStatus;
        set => documentStatus = value;
    }

    public DateTime CreateDate
    {
        get => createDate;
        set => createDate = value;
    }

    public string UploadedDocumentPath
    {
        get => uploadedDocumentPath;
        set => uploadedDocumentPath = value;
    }

    public bool IsDeleted
    {
        get => isDeleted;
        set => isDeleted = value;
    }
//-----------------------------------------------------------------------------------------------------
    public void CreateDocumentRequest(string filePath)
    {
        documentStatus = DocumentStatus.NewRequest;
        createDate = DateTime.Now;
        uploadedDocumentPath = filePath;

        Console.WriteLine($"[Created] Document Request ID: {documentRequestID} | Status: {documentStatus} | File: {filePath}");
    }
    //------------------------------------------------------------------------------------------------

    public void UpdateDocumentRequest(string newFilePath, DocumentSetting newSetting)
    {
        if (!string.IsNullOrEmpty(newFilePath))
        {
            uploadedDocumentPath = newFilePath;
            Console.WriteLine($"[Updated File] Document Request ID: {documentRequestID} | New File: {newFilePath}");
        }

        if (newSetting != null)
        {
            documentSettingObj = newSetting;
            Console.WriteLine($"[Updated Setting] Document Request ID: {documentRequestID} | New Type: {newSetting.DocumentType}");
        }
    }
    //------------------------------------------------------------------------------------------------

    public void DeleteDocumentRequest(List<DocumentRequest> allRequests)
    {
        isDeleted = true;
        allRequests.Remove(this);
        Console.WriteLine($"[Deleted] Request ID: {documentRequestID} has been removed.");
    }

    //------------------------------------------------------------------------------------------------

    public int GetDocumentRequestID()
    {
        return documentRequestID;
    }

    // ---------- IapprovalStatus Interface Method Implementations ----------
    public void ApproveRequest()
    {
        documentStatus = DocumentStatus.Approved;
        Console.WriteLine($"[Approved] Request ID: {documentRequestID} | Status: {documentStatus}");
    }

    public void RejectRequest()
    {
        documentStatus = DocumentStatus.Rejected;
        Console.WriteLine($"[Rejected] Request ID: {documentRequestID} | Status: {documentStatus}");
    }

    public void ReturnRequest()
    {
    }

    public void cancelRequest()
    {
    }

    public void InProgress()
    {
    }


    public void NewRequest()
    {
        documentStatus = DocumentStatus.NewRequest;
        Console.WriteLine($"[New] Request ID: {documentRequestID} | Status: {documentStatus}");
    }
//-----------------------------------------------------------------------------------------------------


}
