namespace Project01.Entity
{
    public class Semester
    {
        public int SMT_Id { get; set; }

        public string SMT_Name { get; set; }
        
        public int SY_Id { get; set; }

        public SchoolYear SchoolYears { get; set; }
    }
}
