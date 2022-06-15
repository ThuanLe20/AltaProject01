namespace Project01.Entity
{
    public class Test
    {
        public Test()
        {
            TestDetails = new HashSet<TestDetail>();
        }
        public int T_Id { get; set; }

        public string T_Name { get; set; }

        public int TC_Id { get; set; }

        public int SJ_Id { get; set; }
        public TestCategory TestCategoryy { get; set; }

        public Subject Subjectt { get; set; }

        public ICollection<TestDetail> TestDetails { get; set; }
    }
}
