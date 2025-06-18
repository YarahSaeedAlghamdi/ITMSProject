

public class Year
{
    private string yearCode;
    private int group;
    private string description;
    private string hijriDate;
    private string gregorianDate;
    private DateTime startDate;
    private DateTime endDate;
    private bool isActive;


    // Constructor 
    public Year( )
    {

    }


    // الدوال العامة (Public Methods)

    public static void CreateYear()
    {

    }

    public static void UpdateYear()
    {

    }

    public static void DeleteYear()
    {

    }

    public static List<Year> GetYear(List<Year> yearList)
    {
        return yearList;
    }

    public static Year GetYear(string code)
    {
        List<Year> s = GetYear();

        return s.getYearCode();     
    }
    
    public static Year GetYear(List<Year> yearList, string code)
    {
    return yearList.FirstOrDefault(x => x.yearCode == code);
    }

}











