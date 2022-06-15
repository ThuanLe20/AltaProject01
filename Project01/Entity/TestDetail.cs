namespace Project01.Entity
{
    public class TestDetail
    {
        public int TD_Id { get; set; }

        public int C_Id { get; set; }

        public int T_Id { get; set; }

        public DateTime T_Date { get; set; }

        public int TD_Time { get; set; }

        public Class Class { get; set; }

        public Test Test { get; set; }

        public TestPoint TestPoints { get; set; }
    }
}
