namespace Project01.Entity
{
    public class Course
    {
        public Course()
        {
            ScheduleCourses = new HashSet<ScheduleCourse>();
        }
        public int CR_Id { get; set; }

        public string CR_Name { get; set; }

        public DateTime CR_StartDate { get; set; }

        public DateTime CR_EndDate { get; set; }

        public string CR_Link { get; set; }

        public bool CR_Status   { get; set; }

        public int SJ_Id { get; set; }

        public Subject Subjectt { get; set; }
       
        public ICollection<ScheduleCourse> ScheduleCourses { get; set; }
    }
}
