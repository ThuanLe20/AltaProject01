namespace Project01.Entity
{
    public class Admin
    {
        public int AD_Id { get; set; }

        public string AD_FName { get; set; }

        public string AD_LName { get; set; }

        public DateTime AD_Birth { get; set; }

        public string AD_Address { get; set; }

        public string AD_Phone { get; set; }

        public string AD_Email { get; set; }

        public int ACC_Id { get; set; }

        public Account Account { get; set; }
    }
}
