using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Linq.Mapping;

namespace BibliothekV1.Domain.DataModel
{
    public class UserInformationModel
    {
        [Key]
        [System.Data.Linq.Mapping.Column(IsDbGenerated = true)]
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Pseudo { get; set; }
        public string BirthDate { get; set; }        
        public int CityId { get; set; }
        public int? DistrictId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool Active { get; set; }
        public string CreateDate { get; set; }
        public int? Fiability { get; set; }
        public int? NbVoting { get; set; }

        public virtual CityModel City { get; set; }
        public virtual DistrictModel District { get; set; }
    }
}