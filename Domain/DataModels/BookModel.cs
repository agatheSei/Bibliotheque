using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BibliothekV1.Domain.DataModel
{
    public class BookModel
    {
        [Key]
        public int BookId { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public int LangageId { get; set; }
        public int? TypeId { get; set; }
        public int? EditionId { get; set; }
        public string Synopsis { get; set; }

        public virtual AuthorModel Author {get;set;}
        public virtual LangageModel Langage { get; set; }
        public virtual TypeModel Type { get; set; }
        public virtual EditionModel Edition { get; set; }
    }
}