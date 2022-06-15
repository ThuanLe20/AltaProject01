namespace Project01.Entity
{
    public class TestPoint
    {
        public int TP_Id { get; set; }

        public int SD_Id { get; set; }

        public int TD_Id { get; set; }

        public string TP_Name { get; set; }

        public float TP_Point { get; set; }

        public Student Students { get; set; }

        public TestDetail TestDetails { get; set; } 

        public Transcript Transcripts { get; set; }
    }
}
