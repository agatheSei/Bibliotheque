using System.ComponentModel.DataAnnotations;

namespace BibliothekV1.Domain.DataModel
{
    public class EditionModel
    {
        [Key]
        public int EditionId { get; set; }
        public string Edition { get; set; }
    }
}