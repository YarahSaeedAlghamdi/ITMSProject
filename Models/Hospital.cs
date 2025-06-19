using System;
using System.Collections.Generic;
using System.Linq;


namespace Models
{
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


        public List<Hospital> GetYear(List<Hospital> hospitalList)
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
}