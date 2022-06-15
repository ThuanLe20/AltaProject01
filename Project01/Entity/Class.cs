namespace Project01.Entity
{
    public class Class
    {
        public Class()
        {
            Students = new HashSet<Student>();
            TestDetails = new HashSet<TestDetail>();
        }
        public int C_Id { get; set; }

        public string C_Name { get; set; }

        public int G_Id { get; set; }

        public int SY_Id { get; set; }

        public int SD_Id { get; set; }

        public Grade Grade { get; set; }    

        public SchoolYear SchoolYear { get; set; }  

        public ICollection<Student> Students { get; set; }

        public Schedule Schedule { get; set; }

        public ICollection<TestDetail> TestDetails { get; set; }
    }
}
