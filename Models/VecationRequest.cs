public class VacationRequest
{
    private StudentSchedule StudentSchedule;
    private VacationSettings VacationSettings;
    private DateTime StartDate;
    private DateTime EndDate;
    private DateTime CreateVacationDate;
    private Student Student;
    private int RequestVacationID;
    private StatusEnum Status;

    public enum StatusEnum
    {
        NewRequest,
        Approved,
        Rejected
    }

    public void CreateVacationRequest()
    {
         }

    public VacationRequest GetVacationRequest()
    {
        return this;
        }

    public void DeleteVacationRequest()
    {
        }

    public void CancelVacationRequest()
    {
       
    }
}