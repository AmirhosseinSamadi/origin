namespace library
{
    public class BookDefenition
    {
        public Author Author { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int ISBN { get; set; }
        public bool IsAvailable { get; set; }
        public List<Book> Books { get; set; }
        public int Quantity { get; set; }
        public List<Category> categort { get; set; }
    }
}
