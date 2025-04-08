using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConnectPOC.Models
{
    [Table("Cities")]
    public class City
    {
        [Key]
        public long? CityId { get; set; }

        [Required]
        [StringLength(100)]
        public string CityName { get; set; } = string.Empty;
    }
}
