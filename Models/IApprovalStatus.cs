public interface IApprovalStatus{


    public void approveRequest() {
        // Logic to approve the request
    }

    public void rejectRequest() {
        // Logic to reject the request
    }

    public void returnRequest() {
        // Logic to return request for revision
    }

    public void inProgress() {
        // Logic to set status as in progress
    }

    public void newRequest() {
        // Logic to initialize a new request
    }
}


