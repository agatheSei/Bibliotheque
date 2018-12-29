using System.ComponentModel.DataAnnotations;

namespace BibliothekV1.Domain.DataModel
{
    public class CountryModel
    {
        [Key]
        public int CountryId { get; set; }
        public int Country { get; set; }

    }
}