namespace Project01.Entity
{
    public class Account
    {
        public int ACC_Id { get; set; }

        public string ACC_Name { get; set; }

        public string ACC_Pw { get; set; }

        public int PST_Id { get; set; }

        public Position Positionn { get; set; }

        public Admin Admin { get; set; }    

        public Student Student { get; set; }
    }
}
