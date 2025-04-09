using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConnectPOC.Models
{
    public class UserProfile
    {
        [Key]
        public long UserId { get; set; }

        [Required, MaxLength(255)]
        public required string FullName { get; set; }

        [Required, MaxLength(320)]
        public required string EmailAddress { get; set; }

        [Required, MaxLength(15)]
        public required string MobileNumber { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public bool? IsDeleted { get; set; }

        public string? OTP { get; set; }

        public DateTime? OTPGeneratedTime { get; set; }

        public string? OTPHash { get; set; }

        public string? Email { get; set; }

        [ForeignKey("City")]
        public long? CityId { get; set; }
        public string? BloodGroup { get; set; }
        public string? ProfileImagePath { get; set; }
        public string? EmergencyNumber1 { get; set; }
        public string? EmergencyNumber2 { get; set; }
        public string? EmergencyNumber3 { get; set; }
        public string? AllergicContent { get; set; }
        public string? Token { get; set; }
        public bool? IsOTPVerified { get; set; }

        public DateTime? CreatedDate { get; set; }
        public DateTime? OTPGenerateTime { get; set; }
        public string? FacebookId { get; set; }
        public string? GooglePlusId { get; set; }
        public DateTime? CrashAlertDate { get; set; }
        public bool? IsRegistered { get; set; }
        public string? IosToken { get; set; }
        public string? AndroidToken { get; set; }
        public string? RegistrationId { get; set; }
        public string? AppleId { get; set; }
        public int? OTPFailedAttemptCount { get; set; }
        public DateTime? LastOTPFailedAttemptAt { get; set; }
        public string? DeleteReasonMessage { get; set; }
        public long? DeleteOTP { get; set; }
        public DateTime? DeleteOTPGenerateTime { get; set; }
        public bool? IsDeleteOTPVerified { get; set; }

        public DateTime? DeletedOn { get; set; }

        public bool? IsMasked { get; set; }
        public bool? IsMigrated { get; set; }
        public DateTime? MigrationTime { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? LastMobChangeDate { get; set; }
        public string? MobChangeStatus { get; set; }
        public string? MobChangeStatusMsg { get; set; }
        public long? ExistingICENumber { get; set; }
        public long? StateId { get; set; }
        public long? BillingCityId { get; set; }



        // Navigation Properties

        public City? City { get; set; }
        public ICollection<UserVehicle> UserVehicles { get; set; } = new List<UserVehicle>();
        public ICollection<N109Cumulative> N109Cumulatives { get; set; } = new List<N109Cumulative>();
        public ICollection<ApacheCumulative> ApacheCumulatives { get; set; } = new List<ApacheCumulative>();
        public ICollection<ApacheNONIOTCumulative> ApacheNONIOTCumulative { get; set; } = new List<ApacheNONIOTCumulative>();
        public ICollection<N251BLECumulative> N251BLECumulative { get; set; } = new List<N251BLECumulative>();

        public ICollection<U347Cumulative> U347Cumulative { get; set; } = new List<U347Cumulative>();

        public ICollection<RideCumulative> RideCumulative { get; set; } = new List<RideCumulative>();
    }

}
