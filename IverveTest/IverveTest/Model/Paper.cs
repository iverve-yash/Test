namespace IverveTest.Model
{
    public class Paper
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public DateTime PublishedDate { get; set; }
        public int ReferenceCount { get; set; }
        public int NumberOfCitation { get; set; }
        public int CountClick { get; set; } = 0;
    }
}
