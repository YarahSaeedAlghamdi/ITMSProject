

public class DocumentRequest : IapprovalStatus {
//------------------------------------------------------------------------------------------------
    private Student studentObj;
    private int documentRequestID;
    private DocumentSettings documentSettingObj;
    private DocumentStatus documentStatus;
    private DateTime createDate;
    private string uploadedDocumentPath;
    private bool isDeleted;


    //------------------------------------------------------------------------------------------------

    public enum DocumentStatus
    {
        Rejected,
        Approved,
        NewRequest
    }

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
    public void createDocumentRequest(string filePath)
    {
        documentStatus = DocumentStatus.NewRequest;
        createDate = DateTime.Now;
        uploadedDocumentPath = filePath;

        Console.WriteLine($"[Created] Document Request ID: {documentRequestID} | Status: {documentStatus} | File: {filePath}");
    }
    //------------------------------------------------------------------------------------------------

    public void updateDocumentRequest(string newFilePath, DocumentSetting newSetting)
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

    public void deleteDocumentRequest(List<DocumentRequest> allRequests)
    {
        isDeleted = true;
        allRequests.Remove(this);
        Console.WriteLine($"[Deleted] Request ID: {documentRequestID} has been removed.");
    }

    //------------------------------------------------------------------------------------------------

    public int getDocumentRequestID()
    {
        return documentRequestID;
    }

    public DocumentRequest getDocumentRequest()
    {
        return this;
    }


    // ---------- IapprovalStatus Interface Method Implementations ----------
    public void approveRequest()
    {
        documentStatus = DocumentStatus.Approved;
        Console.WriteLine($"[Approved] Request ID: {documentRequestID} | Status: {documentStatus}");
    }

    public void rejectRequest()
    {
        documentStatus = DocumentStatus.Rejected;
        Console.WriteLine($"[Rejected] Request ID: {documentRequestID} | Status: {documentStatus}");
    }

    public void returnRequest()
    {
    }

    public void inProgress()
    {
    }


    public void newRequest()
    {
        documentStatus = DocumentStatus.NewRequest;
        Console.WriteLine($"[New] Request ID: {documentRequestID} | Status: {documentStatus}");
    }
//-----------------------------------------------------------------------------------------------------


}
