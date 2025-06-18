
    public class EvaluateStudent
    {
        // === Attributes ===
        private int score;
        private EvaluationRequest evaluationRequest;
        private string comment;
        private DateTime requestDate;
        private string evaluator;

        // === Constructor ===
        public EvaluateStudent(EvaluationRequest request, int score, string comment, string evaluator)
        {
            this.evaluationRequest = request;
            this.score = score;
            this.comment = comment;
            this.evaluator = evaluator;
            this.requestDate = DateTime.Now;
        }

        // === Method 1: Add Evaluation ===
        // This corresponds to step (2) in the process: sending the evaluation
        public void AddEvaluatorStudent()
        {
            // Logic to save evaluation to database can go here
            Console.WriteLine("Evaluation has been submitted successfully.");
            Console.WriteLine($"Request ID: {evaluationRequest.RequestIDEvaluation}");
            Console.WriteLine($"Evaluator: {evaluator}");
            Console.WriteLine($"Score: {score}");
            Console.WriteLine($"Comment: {comment}");
            Console.WriteLine($"Submitted on: {requestDate:yyyy-MM-dd}");
        }

        // === Method 2: Retrieve Evaluation Information ===
        // This corresponds to steps (5, 6): viewing an existing evaluation
        public static EvaluateStudent GetEvaluationInfo(EvaluationRequest request)
        {
            // Logic to retrieve from database
            Console.WriteLine($"Retrieving evaluation details for request ID: {request.RequestIDEvaluation}");

            // Sample static return for UI display
            return new EvaluateStudent(
                request,
                88,                           // Sample score
                "Good understanding of concepts", // Sample comment
                "Dr. Huda"                    // Sample evaluator
            );
        }
    }

