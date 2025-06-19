
using System;
using System.Collections.Generic;
using System.Linq;


namespace Models
{
    public class StudentSchedule : IApprovalStatus
    {
        private DateTime scheduleRequestDate;

        private int scheduleRequestID;

        private Student student;

        private TrainingPeriod trainingPeriod;

        private StudentScheduleStatus studentScheduleStatus;


        /// ///////////////////////////////////////////////////////////////////////////////////////

        public enum StudentScheduleStatus
        {
            Approved,
            Rejected,
            InProgress
        }

        public void CreateStudentSchedule()
        {

        }

        public void UpdateStudentSchedule()
        {

        }

        public void DeleteStudentSchedule()
        {

        }

        public List<StudentSchedule> GetStudentSchedule(List<StudentSchedule> studentSchedulList)
        {
            return studentSchedulList;
        }

        // ميثودات الانترفيس

        public void approveRequest()
        {

        }

        public void rejectRequest()
        {

        }

        public void inProgress()
        {

        }

        public void returnRequest()
        {

        }

        public void newRequest()
        {


        }
    }

}