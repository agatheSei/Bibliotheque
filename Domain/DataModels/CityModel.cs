using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BibliothekV1.Domain.DataModel
{
    public class CityModel
    {
        [Key]
        public int CityId { get; set; }
        public int CountryId { get; set; }
        public string City { get; set; }

        public virtual ICollection<CountryModel> Countries { get; set; }
    }
}