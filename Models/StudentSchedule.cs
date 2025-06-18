
using System;
using System.Collection.Generic;
using System.Linq;

public enum StudentScheduleStatus: IApprovalStatus
{
    Approved,
    Rejected,
    InProgress
}

public class Period
{
    private DateTime scheduleRequestDate;

    private int scheduleRequestID;

    private Student student;

    private TrainingPeriod trainingPeriod;

    private StudentScheduleStatus studentScheduleStatus;


    /// ///////////////////////////////////////////////////////////////////////////////////////

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

    public void ApproveRequest()
    {

    }

    public void RejectRequest()
    {

    }

    public void InProgress()
    {

    }

    public void ReturnRequest()
    {

    }
    
    public void NewRequest()
    {


    }
}
