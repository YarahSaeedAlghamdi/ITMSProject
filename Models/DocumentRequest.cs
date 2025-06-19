
namespace Models
{
    

public class DocumentRequest : IApprovalStatus {
//------------------------------------------------------------------------------------------------
    private Student studentObj;
    private int documentRequestID;
    private DocumentSettings documentSettingObj;
    private Status documentStatus;
    private DateTime createDate;
    private string uploadedDocumentPath;
    private bool isDeleted = false;


    //------------------------------------------------------------------------------------------------

    public enum Status
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

    public DocumentSettings DocumentSettingObj
    {
        get => documentSettingObj;
        set => documentSettingObj = value;
    }

    public Status DocumentStatus
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
    public void createDocumentRequest(string filePath , DocumentSettings newSetting)
    {
        documentStatus = Status.NewRequest;
        createDate = DateTime.Now;
        documentSettingObj = newSetting;
        uploadedDocumentPath = filePath;

        Console.WriteLine($"[Created] Document Request ID: {documentRequestID} | Status: {documentStatus} | File: {filePath}");
    }
    //------------------------------------------------------------------------------------------------

    public void updateDocumentRequest(string newFilePath, DocumentSettings newSetting)
    {
        if (!string.IsNullOrEmpty(newFilePath))
        {
            uploadedDocumentPath = newFilePath;
            Console.WriteLine($"[Updated File] Document Request ID: {documentRequestID} | New File: {newFilePath}");
        }

        if (newSetting != null)
        {
            documentSettingObj = newSetting;
            Console.WriteLine($"[Updated Setting] Document Request ID: {documentRequestID} | New Type: {newSetting.DocumentTypeID}");
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
        documentStatus = Status.Approved;
        Console.WriteLine($"[Approved] Request ID: {documentRequestID} | Status: {documentStatus}");
    }

    public void rejectRequest()
    {
        documentStatus = Status.Rejected;
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
        documentStatus = Status.NewRequest;
        Console.WriteLine($"[New] Request ID: {documentRequestID} | Status: {documentStatus}");
    }
//-----------------------------------------------------------------------------------------------------


}

}
