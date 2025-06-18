using System;
using System.Collection.Generic;
using System.Linq;


public class Period
{
    private string periodCode;

    private string periodName;

    private DateTime startDate = default;

    private DateTime endDate = default;

    private bool isActive;

    private int numberOfmunth;


    /// ///////////////////////////////////////////////////////////////////////////////////////

    public void CreatePeriod()
    {

    }

    public void UpdatePeriod()
    {

    }

    public void DeletePeriod()
    {

    }

    
    public Period GetPeriod(List<Period> periodList, string periodCode)
    {
        foreach (Period p in periodList)
        {
            if (p.PeriodCode == periodCode)
                return p;
        }
        return null;
    }


    public List<Period> GetPeriod(List<Period> periodList)
    {
        return periodList;
    }
}
