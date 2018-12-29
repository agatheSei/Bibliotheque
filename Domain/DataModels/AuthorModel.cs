using System.ComponentModel.DataAnnotations;

namespace BibliothekV1.Domain.DataModel
{
    public class AuthorModel
    {
        [Key]        
        public int AuthorId { get; set; }
        public string AuthorName { get; set; }
    }
}