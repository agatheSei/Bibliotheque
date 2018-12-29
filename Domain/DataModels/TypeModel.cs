using System.ComponentModel.DataAnnotations;

namespace BibliothekV1.Domain.DataModel
{
    public class TypeModel
    {
        [Key]
        public int TypeId { get; set; }
        public int Type { get; set; }
    }
}