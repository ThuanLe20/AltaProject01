namespace Project01.Entity
{
    public class ScheduleCourse
    {
        public int SC_Id { get; set; }

        public int SD_Id { get; set; }

        public int CR_Id { get; set; }

        public Schedule Schedules { get; set; }

        public Course Courses { get; set; }
    }
}
