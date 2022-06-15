namespace Project01.Entity
{
    public class Position
    {
        public Position()
        {
            Accountt = new HashSet<Account>();
        }
        public int PST_Id { get; set; }

        public string PST_Name { get; set; }

        public ICollection<Account> Accountt { get; set; }
    }
}
