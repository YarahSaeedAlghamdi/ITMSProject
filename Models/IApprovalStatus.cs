namespace Models
{
    public interface IApprovalStatus
    {
        void ApproveRequest();
        void RejectRequest();
        void ReturnRequest();
        void InProgress();
        void NewRequest();
    }
}


