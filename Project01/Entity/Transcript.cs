namespace Project01.Entity
{
    public class Transcript
    {
        public Transcript()
        {
            TestPoints = new HashSet<TestPoint>();
        }
        public int TS_Id { get; set; }

        public string TS_Name { get; set; }


        public int TP_Id { get; set; }

        public float TS_Point { get; set; }

        public float TS_Total  { get; set; }

        public ICollection<TestPoint> TestPoints { get; set; }
    }
}
