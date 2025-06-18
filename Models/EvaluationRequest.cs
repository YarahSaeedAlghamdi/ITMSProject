using System;
using System.Collections.Generic;

namespace EvaluationSystem
{
    public class EvaluationRequest : IApprovalStatus
    {
        public int               RequestIDEvaluation  { get; set; }
        public Student           Student              { get; init; } = new Student();
        public StudentSchedule   StudentSchedule      { get; init; } = new StudentSchedule();
        public EvaluationSetting EvaluationSetting    { get; init; } = new EvaluationSetting();
        public DateTime          EvaluationPeriodFrom { get; set; }
        public DateTime          EvaluationPeriodTo   { get; set; }
        public Admin             Evaluator            { get; set; } = new Admin();
        public string            FileUpload           { get; set; } = string.Empty;
        public EvaluationStatus  Status               { get; private set; }
            = EvaluationStatus.NewRequest;

        // مخزن مؤقت
        private static readonly List<EvaluationRequest> _all
            = new List<EvaluationRequest>();

        public void CreateEvaluationRequest()
        {
            _all.Add(this);
            Student.EvaluationRequests.Add(this);
            StudentSchedule.EvaluationRequests.Add(this);
        }

        public static EvaluationRequest? GetEvaluationRequest(int id) =>
            _all.Find(r => r.RequestIDEvaluation == id);

        public static void DeleteEvaluationRequest(int id) =>
            _all.RemoveAll(r => r.RequestIDEvaluation == id);

        // ==== IApprovalStatus Implementation ====
        public void ApproveRequest()   => Status = EvaluationStatus.Approved;
        public void RejectRequest()    => Status = EvaluationStatus.Rejected;
        public void ReturnRequest()    => Status = EvaluationStatus.NewRequest;
        public void InProgress()       => Status = EvaluationStatus.InProgress;
        public void NewRequest()       => Status = EvaluationStatus.NewRequest;

        // Helpers للطباعة
        public void PrintEmptyEvaluationForm() =>
            Console.WriteLine("[Empty Evaluation Form]");

        public void PrintEvaluationResult() =>
            Console.WriteLine($"Req {RequestIDEvaluation} → {Status}");
    }
}

