using System;
using System.Collections.Generic;
using System.Linq;

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
    public Year(string code, int group, string desc, string hijri, string gregorian, DateTime start, DateTime end, bool active)
    {
        this.yearCode = code;
        this.group = group;
        this.description = desc;
        this.hijriDate = hijri;
        this.gregorianDate = gregorian;
        this.startDate = start;
        this.endDate = end;
        this.isActive = active;
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

    public static List<Year> GetYear()
    {

    }

    public static Year GetYear(string code)
    {
        return yearList.FirstOrDefault(x => x.yearCode == code);
    }
}











