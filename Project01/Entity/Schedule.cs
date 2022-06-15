namespace Project01.Entity
{
    public class Schedule
    {
        public Schedule()
        {
            ScheduleCourses = new HashSet<ScheduleCourse>();
        }
        public int SD_Id { get; set; }

        public string SD_Name { get; set; }

        public int C_Id { get; set; }

        public DateTime SD_Date { get; set; }

        public bool SD_Status { get; set; }

        public int CR_Id { get; set; }

        public ICollection<ScheduleCourse> ScheduleCourses { get; set; }

        public Class Class { get; set; }
    }
}
