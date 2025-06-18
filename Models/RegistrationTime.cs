using System;

public class RegistrationTime
{
    
    public Year year;
    public int group;
    public string timeCode;
    private string timeDescription;
    private int choicesCount;
    private DateTime startDate;
    private DateTime endDate;
    private TimeSpan startTime;
    private TimeSpan endTime;
    private bool isActive;

    public RegistrationTime()
    {

    }


    public void CreateRegistrationTime()
    {

    }

    public void UpdateRegistrationTime()
    {

    }

    public DeleteRegistrationTime()
    {

    }

    public List<RegistrationTime> GetRegistrationTime(List<RegistrationTime> list)
    {
        return list;
    }

    public static RegistrationTime GetRegistrationTime(List<RegistrationTime> list, string timeCode, Year year, int group)
    {
        foreach (RegistrationTime r in list)
        {
            if (r.TimeCode == timeCode && r.Year == year && r.Group == group)
                return r;
        }
        return null;
    }

}
