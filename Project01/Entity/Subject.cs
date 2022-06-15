namespace Project01.Entity
{
    public class Subject
    {
        public Subject()
        {
            Course = new HashSet<Course>();
            Documents = new HashSet<Document>();
            Tests = new HashSet<Test>();
        }
        public int SJ_Id { get; set; }

        public string SJ_Name { get; set; }

        public int SJ_Lesson { get; set; }

        public Semester Semesterr { get; set; }

        public Admin Adminn { get; set; }

        public ICollection<Course> Course { get; set; }

        public ICollection<Document> Documents { get; set; }

        public ICollection<Test> Tests { get; set; }

    }
}
