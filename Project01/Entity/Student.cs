namespace Project01.Entity
{
    public class Student
    {
        public Student()
        {
            TestPoints = new HashSet<TestPoint>();
        }
        public int S_Id { get; set; }

        public string S_FName { get; set; }

        public string S_LName { get; set; }

        public string S_Phone { get; set; }

        public string S_Address { get; set; }

        public string S_Email { get; set; }

        public int ACC_Id { get; set; }
        public int C_Id { get; set; }
        public Account Accountt { get; set; }

        public Class Class { get; set; }

        public ICollection<TestPoint> TestPoints { get; set; }  
    }
}
