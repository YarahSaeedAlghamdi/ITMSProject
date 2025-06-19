public class EvaluationSetting
{
    public int EvaluationID { get; set; }
    public string EvaluationName { get; set; } = string.Empty;
    public bool IsActive { get; set; }
    public string Competency { get; set; } = string.Empty;
    public string Definition { get; set; } = string.Empty;

    // ✅ Association with Admin
    public Admin CreatedBy { get; set; } = new Admin();

    // ✅ NEW: Association with College
    public College College { get; set; } = new College();

    // In-memory storage
    private static readonly List<EvaluationSetting> _all = new();

    // Optional constructor
    public EvaluationSetting(int id, string name, bool isActive, string competency, string definition, Admin createdBy, College college)
    {
        EvaluationID = id;
        EvaluationName = name;
        IsActive = isActive;
        Competency = competency;
        Definition = definition;
        CreatedBy = createdBy;
        College = college;
    }

        public void CreateEvaluationSetting() => _all.Add(this);

        public void UpdateEvaluationSetting()
        {
            var idx = _all.FindIndex(e => e.EvaluationID == EvaluationID);
            if (idx >= 0) _all[idx] = this;
        }

        public static void DeleteEvaluationSetting(int id) =>
            _all.RemoveAll(e => e.EvaluationID == id);

    public static EvaluationSetting? GetEvaluationSetting(int id) =>
        _all.Find(e => e.EvaluationID == id);
}

