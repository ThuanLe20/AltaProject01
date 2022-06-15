namespace Project01.Entity
{
    public class TestCategory
    {
        public TestCategory()
        {
            Tests = new HashSet<Test>();
        }
        public int TC_Id { get; set; }

        public int TC_Name { get; set; }

        public ICollection<Test> Tests { get; set; }
    }
}
