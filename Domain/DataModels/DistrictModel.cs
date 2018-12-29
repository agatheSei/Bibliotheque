using System.ComponentModel.DataAnnotations;

namespace BibliothekV1.Domain.DataModel
{
    public class DistrictModel
    {
        [Key]
        public int DistrictId { get; set; }
        public string District { get; set; }
    }
}