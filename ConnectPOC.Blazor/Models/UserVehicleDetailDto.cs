namespace ConnectPOC.DTOs
{
    public class UserVehicleDetailDto
    {
        public int VehicleId { get; set; }
        public int VehicalTypeId { get; set; }
        public string FrameNo { get; set; }
        public string VehicleName { get; set; }
        public string ContactNo { get; set; }
        public string UserId { get; set; }
        public string Series { get; set; }
        public string IOT { get; set; }
        public DateTime InsertDate { get; set; }
        public string NickName { get; set; }
        public int TotalRides { get; set; }
        public decimal TotalDistanceTravelled { get; set; }
        public decimal TopSpeed { get; set; }
        public decimal? OdometerReading { get; set; }
        public int Theme { get; set; }
    }
}
