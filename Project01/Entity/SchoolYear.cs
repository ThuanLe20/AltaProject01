namespace Project01.Entity
{
    public class SchoolYear
    {
        public SchoolYear()
        {
            Semesters = new HashSet<Semester>();
        }
        public int SY_Id { get; set; }

        public string SY_Year { get; set; }

        public int C_Id { get; set; }

        public Class Class { get; set; }

        public ICollection<Semester> Semesters { get; set; }
    }
}
