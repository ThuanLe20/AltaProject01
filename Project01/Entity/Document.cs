namespace Project01.Entity
{
    public class Document
    {
        public int D_Id { get; set; }

        public string D_Name { get; set; }

        public int SJ_Id { get; set; }
        public Subject Subjectt { get; set; }
    }
}
