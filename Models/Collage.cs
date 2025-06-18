namespace EvaluationSystem.Models
{
    public class College
    {
        // === Private attributes ===
        private int collegeID;
        private string collegeName;

        // === Public method to set college info ===
        public void SetCollege(int id, string name)
        {
            collegeID = id;
            collegeName = name;
        }

        // === Public method to get college info ===
        public string GetCollege()
        {
            return $"College ID: {collegeID}, College Name: {collegeName}";
        }
    }
}
