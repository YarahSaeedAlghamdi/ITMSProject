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

    // دالة تقديم طلب إجازة
    public void CreateVacationRequest()
    {
        Console.WriteLine("تم تقديم طلب إجازة من " + 
                          StartDate.ToShortDateString() + 
                          " إلى " + 
                          EndDate.ToShortDateString());
        Status = StatusEnum.NewRequest; 
    }

    // دالة تعرض معلومات الطلب
    public VacationRequest GetVacationRequest()
    {
        Console.WriteLine(" طلب إجازة: رقم " + RequestVacationID + 
                          " للطالب " + Student.Name + 
                          "، الحالة: " + Status);
        return this; 
    }

    // دالة لحذف طلب الإجازة
    public void DeleteVacationRequest()
    {
        Console.WriteLine("تم حذف طلب الإجازة رقم " + RequestVacationID +
                          " للطالب " + Student.Name);
    }

    // دالة لإلغاء الطلب (بس ما تقدر تلغي لو تم الموافقة عليه)
    public void CancelVacationRequest()
    {
        if (Status == StatusEnum.Approved)
        {
            Console.WriteLine("لا يمكن إلغاء الطلب بعد الموافقة عليه");
        }
        else
        {
            Status = StatusEnum.Rejected; // نغير الحالة إلى مرفوض
            Console.WriteLine("تم إلغاء طلب الإجازة رقم " + RequestVacationID);
        }
    }
}