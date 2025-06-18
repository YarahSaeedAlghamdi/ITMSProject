using System;
using System.Collection.Generic;
using System.Linq;


public class Hospital
{
    private string hospitalCode;
    private string hospitalName;


    /// ///////////////////////////////////////////////////////////////////////////////////////

    public void CreateHospital()
    {

    }

    public void UpdateHospital()
    {

    }

    public void DeleteHospital()
    {

    }


    public static List<Hospital> GetYear(List<Hospital> hospitalList)
    {
        return hospitalList;
    }
    
    
    public Hospital GetHospital(List<Hospital> hospitalList, string hospitalCode)
    {
        foreach (Hospital h in hospitalList)
        {
            if (h.HospitalCode == hospitalCode)
                return h;
        }
        return null;
    }

}