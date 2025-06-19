//Razan Saud
namespace Models
{
    public class EvaluationRequest : IApprovalStatus
    {
        private int RequestIDEvaluation { get; set; }
        public Student Student { get; init; } = new Student();
        public StudentSchedule StudentSchedule { get; init; } = new StudentSchedule();
        public EvaluationSetting EvaluationSetting { get; init; } = new EvaluationSetting();
        private DateTime EvaluationPeriodFrom { get; set; }
        private DateTime EvaluationPeriodTo { get; set; }
        public Admin Evaluator { get; set; } = new Admin();
        public string FileUpload { get; set; } = string.Empty;
        public enum StatusEnum
        {
            NewRequest,
            Approved,
            Rejected

        }

        public EvaluationRequest(
              int requestId,
              Student student,
              StudentSchedule studentSchedule,
              EvaluationSetting evaluationSetting,
              DateTime evaluationPeriodFrom,
              DateTime evaluationPeriodTo,
              Admin evaluator,
              string fileUpload)
        {
            RequestIDEvaluation = requestId;
            Student = student;
            StudentSchedule = studentSchedule;
            EvaluationSetting = evaluationSetting;
            EvaluationPeriodFrom = evaluationPeriodFrom;
            EvaluationPeriodTo = evaluationPeriodTo;
            Evaluator = evaluator;
            FileUpload = fileUpload;
           
        }




        public void CreateEvaluationRequest()
        {

        }


        public static void DeleteEvaluationRequest(int id)
        {

        }

        public void PrintEmptyEvaluationForm()
        {
        }


        public void PrintEvaluationResult(int requestId)
        {
        }


        public List<string> GetEvaluationResult(List<string> result)
{
    return result;
}



        public static EvaluationRequest GetEvaluationRequest(StudentSchedule scheduleFrom)
        {
            return null;
        }






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

