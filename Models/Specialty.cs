using System;
using System.Collection.Generic;
using System.Linq;


public class Specialty
{
    private string specialtyCode;

    private string specialtyName;

    private string specialtyType;

    private string elective;


    /// ///////////////////////////////////////////////////////////////////////////////////////

    public void CreateSpecialty()
    {

    }

    public void UpdateSpecialty()
    {

    }

    public void DeleteSpecialty()
    {

    }

 public Specialty GetSpecialty(List<Specialty> specialtyList, string specialtyCode)
    {
        foreach (Specialty s in specialtyList)
        {
            if (s.SpecialtyCode == specialtyCode)
                return s;
        }
        return null;
    }


    public List<Specialty> GetSpecialty(List<Specialty> specialtyList)
    {
        return specialtyList;
    }

}
