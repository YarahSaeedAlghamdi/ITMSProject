
    public class EvaluateStudent
    {
        public int Score { get; set; }
        public EvaluationRequest EvaluationRequest { get; set; }
        public string Comment { get; set; } = string.Empty;
        public DateTime RequestDate { get; set; }
        public string Evaluator { get; set; } = string.Empty;

        // مخزن مؤقت لكل التقييمات
        private static readonly List<EvaluateStudent> _records
            = new List<EvaluateStudent>();

        /// <summary>
        /// يضيف هذا التقييم إلى القائمة
        /// </summary>
        public void AddEvaluateStudent()
        {
            _records.Add(this);
        }

        /// <summary>
        /// يبحث عن التقييم المطابق لكائن EvaluationRequest
        /// </summary>
        public static EvaluateStudent? GetEvaluationInfo(EvaluationRequest req) =>
            _records.Find(r => r.EvaluationRequest == req);
    }










