using System.ComponentModel.DataAnnotations;

namespace ConnectPOC.Blazor.Models
{
    public class UserProfile
    {
        public long UserId { get; set; }
        public required string FullName { get; set; }
        public required string EmailAddress { get; set; }
        public required string MobileNumber { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public bool? IsDeleted { get; set; }
        public string? OTP { get; set; }
        public DateTime? OTPGeneratedTime { get; set; }
        public string? OTPHash { get; set; }
        public string? Email { get; set; }
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


    }
}
