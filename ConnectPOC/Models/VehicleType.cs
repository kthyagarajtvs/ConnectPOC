using System.ComponentModel.DataAnnotations;

namespace ConnectPOC.Models
{
    public class VehicleType
    {
        [Key]
        public long  VehicleTypeId { get; set; }
        public string? VehicleTypeName { get; set; }
        public string? VehicleCategory { get; set; }
        public DateTime? InsertDate { get; set; }
        public string? Series { get; set; }

    }
}
