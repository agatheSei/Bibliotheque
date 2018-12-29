using System.ComponentModel.DataAnnotations;

namespace BibliothekV1.Domain.DataModel
{
    public class LangageModel
    {
        [Key]
        public int LangageId { get; set; }
        public string Langage { get; set; }
    }
}