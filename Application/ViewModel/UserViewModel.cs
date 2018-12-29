using System.ComponentModel.DataAnnotations;

namespace BibliothekV1.Application.ViewModel
{
    public class UserViewModel
    {
        public int UserId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Pseudo { get; set; }
        [Required]
        public string BirthDate { get; set; }
        public int CityId { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public int DistrictId { get; set; }
        public string District { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        public bool Active { get; set; }
        public string CreateDate { get; set; }
        public int Fiability { get; set; }
        public int NbVoting { get; set; }
    }
}