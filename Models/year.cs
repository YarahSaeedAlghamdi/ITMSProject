using System;

namespace Models
{
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
        public Year()
        {

        }


        // Public Methods

        public void CreateYear()
        {

        }

        public void UpdateYear()
        {

        }

        public void DeleteYear()
        {

        }

        public List<Year> GetYear(List<Year> yearList)
        {
            return yearList;
        }


        public Year GetYear(List<Year> yearList, string code)
        {
            foreach (Year y in yearList)
            {
                if (y.yearCode == code)
                    return y;
            }
            return null;
        }

    }
}











