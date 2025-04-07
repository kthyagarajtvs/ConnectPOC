using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConnectPOC.Models
{
    public class RideCumulative
    {
        [Key]
        public long RideCumulativeId { get; set; }

        [ForeignKey("VehicleType")]
        public long VehicleTypeId { get; set; }
        [ForeignKey("UserProfile")]
        public long UserId { get; set; }

        [ForeignKey("UserVehicle")]
        public long UserVehicleId { get; set; }
        public long? TotalRides { get; set; }
        public long? TotalTime { get; set; }
        public long? RideTime { get; set; }
        public decimal? TotalTravelledDistance { get; set; }
        public decimal? TopSpeed { get; set; }
        public decimal? AverageSpeed { get; set; }
        public bool? IsDeleted { get; set; }
        public string? OtherRideParameters { get; set; }
        public long? EcoModeDurationOverall { get; set; }
        public decimal? EcoModeDistanceOverall { get; set; }
        public long? PowerModeDurationOverall { get; set; }
        public decimal? PowerModeDistanceOverall { get; set; }
        public decimal? CumulativeFeOverall { get; set; }
        public decimal? AverageMileage { get; set; }

        public string? FRAME_NO { get; set; }
        public string? CONTACT_NO { get; set; }
        public string? VehicleName { get; set; }
        public string? REG_NO { get; set; }
        public DateTime? SALE_DATE { get; set; }
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
        public string? SERIES { get; set; }
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


        // Navigation Properties
        public UserProfile UserProfile { get; set; }
        public UserVehicle UserVehicle { get; set; }

        public VehicleType VehicleType { get; set; }

    }
}
