namespace BibliothekV1.Application.ViewModel
{
    public class BookViewModel
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public string Author { get; set; }
        public int LangageId { get; set; }
        public string Langage {get;set;}
        public int TypeId { get; set; }
        public string Type { get; set; }
        public int EditionId { get; set; }
        public string Edition { get; set; }
        public string Synopsis { get; set; }
    }
}