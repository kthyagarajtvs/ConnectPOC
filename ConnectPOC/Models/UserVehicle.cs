using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ConnectPOC.Models
{
    public class UserVehicle
    {
        [Key]
        public long UserVehicleId { get; set; }

        [ForeignKey("UserProfile")]
        public long UserId { get; set; }

        [ForeignKey("VehicleType")]
        public long VehicleTypeId { get; set; }

        [Required, MaxLength(20)]
        public required string REG_NO { get; set; }

        public DateTime? SALE_DATE { get; set; }

        public bool? IsDeleted { get; set; }

        public string? FRAME_NO { get; set; }
        public string? CONTACT_NO { get; set; }
        public string? VehicleName { get; set; }

        public DateTime? CreateDate { get; set; }

        public string? ENGINE_NO { get; set; }
        public string? DEALER_ID { get; set; }
        public string? CUSTOMER_NAME { get; set; }
        public string? TOV_PART_ID { get; set; }
        public string? TOV_MODEL_ID { get; set; }
        public string? EMAIL_ADDRESS { get; set; }
        public string? LAST_SERVICE_DATE { get; set; }
        public string? LAST_SERVICE_TYPE { get; set; }
        public string? DMP_PART_ID { get; set; }
        public string? DESCRIPTION { get; set; }
        public string? DMP_MODEL_ID { get; set; }
        public string? ACTIVE { get; set; }
        public string? COLOR { get; set; }
        public string? BRAND_CODE { get; set; }
        public string? BRAND_DESC { get; set; }
        public DateTime? InsertDate { get; set; }
        public string? CONTACT_TYPE { get; set; }
        public string? CUSTOMER_ID { get; set; }
        public string? IOT { get; set; }
        public string? CONNECTED { get; set; }
        public string? NickName { get; set; }
        public int? Theme { get; set; }
        public long? BookingId { get; set; }
        public string? OnGoingBooking { get; set; }
        public bool? IsSelected { get; set; }
        public DateTime? SelectedTime { get; set; }

        public string? VehicleTypeName { get; set; }
        public string? VehicleCategory { get; set; }

        public string? Series { get; set; }


        // Navigation Properties
        public UserProfile UserProfile { get; set; }

        public VehicleType VehicleType { get; set; }

        public ICollection<N109Cumulative> N109Cumulatives { get; set; } = new List<N109Cumulative>();
        public ICollection<ApacheCumulative> ApacheCumulatives { get; set; } = new List<ApacheCumulative>();
        public ICollection<N251BLECumulative> N251BLECumulative { get; set; } = new List<N251BLECumulative>();
        public ICollection<ApacheNONIOTCumulative> ApacheNONIOTCumulative { get; set; } = new List<ApacheNONIOTCumulative>();
        public ICollection<RideCumulative> RideCumulative { get; set; } = new List<RideCumulative>();
        public ICollection<U347Cumulative> U347Cumulative { get; set; } = new List<U347Cumulative>();
    }

}
