namespace Project01.Entity
{
    public class Grade
    {
        public Grade()
        {
            Class = new HashSet<Class>();
        }
        public int G_Id { get; set; }

        public string G_Name { get; set; }

        public ICollection<Class> Class { get; set; }    
    }
}
