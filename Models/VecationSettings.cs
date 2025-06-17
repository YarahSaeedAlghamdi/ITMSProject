public class VacationSettings
{
    private int MaxDays; 
    private int MinDays;  
    private string VacationName;  
    private int NumberOfVacations; 
    private bool IsRepeatVacationPeriod; 
    private bool IsActiveVacation; 

    // إنشاء نوع إجازة جديد
    public void CreateVacation()
    {
        Console.WriteLine(" تم إنشاء إجازة جديدة: " + VacationName + 
                          " (من " + MinDays + " إلى " + MaxDays + " يوم)");
    }

    // تعديل نوع الإجازة
    public void UpdateVacation()
    {
        Console.WriteLine(" تم تعديل الإجازة: " + VacationName);
    }

    // حذف نوع الإجازة
    public void DeleteVacation()
    {
        Console.WriteLine(" تم حذف الإجازة: " + VacationName);
    }
}