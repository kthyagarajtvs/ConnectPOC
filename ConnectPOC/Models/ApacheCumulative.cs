using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ConnectPOC.Models
{
    public class ApacheCumulative
    {
        [Key]
        public long ApacheCumulativeId { get; set; }

        [ForeignKey("UserProfile")]
        public long UserId { get; set; }

        [ForeignKey("UserVehicle")]
        public long UserVehicleId { get; set; }

        public decimal AnotherDataColumn { get; set; }

        public bool IsDeleted { get; set; }
           
        public long? BikeTotalDrivenTime { get; set; }
        public long? TotalRides { get; set; }
        public decimal? TotalDistanceTravelled { get; set; }
        public decimal? BikeBestShortestTime { get; set; }
        public decimal? BikeTopSpeed { get; set; }
        public decimal? BikeAverageSpeed { get; set; }
        public decimal? BikeMaxGforce { get; set; }
        public decimal? BikeMaxLeanAngle { get; set; }
        public decimal? FirstGearAvgSpeed { get; set; }
        public decimal? SecondGearAvgSpeed { get; set; }
        public decimal? ThirdGearAvgSpeed { get; set; }
        public decimal? FourthGearAvgSpeed { get; set; }
        public decimal? FifthGearAvgSpeed { get; set; }
        public decimal? FirstGearAvgRPM { get; set; }
        public decimal? SecondGearAvgRPM { get; set; }
        public decimal? ThirdGearAvgRPM { get; set; }
        public decimal? FourthGearAvgRPM { get; set; }
        public decimal? FifthGearAvgRPM { get; set; }
    
        // Navigation Properties
        public UserProfile UserProfile { get; set; }
        public UserVehicle UserVehicle { get; set; }
    }

}
