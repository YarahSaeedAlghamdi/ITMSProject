namespace Models
{
    public interface IApprovalStatus
    {
        void approveRequest();
        void rejectRequest();
        void returnRequest();
        void inProgress();
        void newRequest();
    }
}


