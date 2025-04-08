namespace ConnectPOC.Models
{
    public class ICubeDealer
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string DelarCode { get; set; }
        public int CityId { get; set; }
        public string Url { get; set; }
        public string? CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public string? UpdatedBy { get; set; }
        public System.DateTime UpdatedOn { get; set; }
        public string Landmark { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public int CappingCount { get; set; }
        public int DistanceLimit { get; set; }
        public bool IsHTRAvailable { get; set; }
        public int DealerStartDate { get; set; }
        public int HTRStartDate { get; set; }
        public string WeeklyOffDays { get; set; }
        public bool IsDTRAvailable { get; set; }
        public string? DealerBranchCode { get; set; }
        public string? EMSDealerCode { get; set; }
        public Nullable<long> VehicleSeriesId { get; set; }
        public Nullable<int> PinCode { get; set; }
        public string? OldDealerCode { get; set; }
    }
}
