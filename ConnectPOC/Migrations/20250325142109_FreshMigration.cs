using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConnectPOC.Migrations
{
    /// <inheritdoc />
    public partial class FreshMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HomeVideo",
                columns: table => new
                {
                    VideoLinkId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VideoLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VideoThumbnailLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomeVideo", x => x.VideoLinkId);
                });

            migrationBuilder.CreateTable(
                name: "UserProfiles",
                columns: table => new
                {
                    UserId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(320)", maxLength: 320, nullable: false),
                    MobileNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    OTP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OTPGeneratedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OTPHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CityId = table.Column<long>(type: "bigint", nullable: true),
                    BloodGroup = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProfileImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmergencyNumber1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmergencyNumber2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmergencyNumber3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AllergicContent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Token = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsOTPVerified = table.Column<bool>(type: "bit", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OTPGenerateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FacebookId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GooglePlusId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CrashAlertDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsRegistered = table.Column<bool>(type: "bit", nullable: true),
                    IosToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AndroidToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegistrationId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AppleId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OTPFailedAttemptCount = table.Column<int>(type: "int", nullable: true),
                    LastOTPFailedAttemptAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteReasonMessage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeleteOTP = table.Column<long>(type: "bigint", nullable: true),
                    DeleteOTPGenerateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleteOTPVerified = table.Column<bool>(type: "bit", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsMasked = table.Column<bool>(type: "bit", nullable: true),
                    IsMigrated = table.Column<bool>(type: "bit", nullable: true),
                    MigrationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastMobChangeDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MobChangeStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MobChangeStatusMsg = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExistingICENumber = table.Column<long>(type: "bigint", nullable: true),
                    StateId = table.Column<long>(type: "bigint", nullable: true),
                    BillingCityId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserProfiles", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "VehicleType",
                columns: table => new
                {
                    VehicleTypeId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VehicleCategory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Series = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleType", x => x.VehicleTypeId);
                });

            migrationBuilder.CreateTable(
                name: "EmergencyContact",
                columns: table => new
                {
                    EmergencyContactId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    EmergencyContactNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmergencyContact", x => x.EmergencyContactId);
                    table.ForeignKey(
                        name: "FK_EmergencyContact_UserProfiles_UserId",
                        column: x => x.UserId,
                        principalTable: "UserProfiles",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserVehicles",
                columns: table => new
                {
                    UserVehicleId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    VehicleTypeId = table.Column<long>(type: "bigint", nullable: false),
                    REG_NO = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    SALE_DATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    FRAME_NO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CONTACT_NO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VehicleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ENGINE_NO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DEALER_ID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CUSTOMER_NAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TOV_PART_ID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TOV_MODEL_ID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EMAIL_ADDRESS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LAST_SERVICE_DATE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LAST_SERVICE_TYPE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DMP_PART_ID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DESCRIPTION = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DMP_MODEL_ID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ACTIVE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    COLOR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BRAND_CODE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BRAND_DESC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CONTACT_TYPE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CUSTOMER_ID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IOT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CONNECTED = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NickName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Theme = table.Column<int>(type: "int", nullable: true),
                    BookingId = table.Column<long>(type: "bigint", nullable: true),
                    OnGoingBooking = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsSelected = table.Column<bool>(type: "bit", nullable: true),
                    SelectedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    VehicleTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VehicleCategory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Series = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserVehicles", x => x.UserVehicleId);
                    table.ForeignKey(
                        name: "FK_UserVehicles_UserProfiles_UserId",
                        column: x => x.UserId,
                        principalTable: "UserProfiles",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserVehicles_VehicleType_VehicleTypeId",
                        column: x => x.VehicleTypeId,
                        principalTable: "VehicleType",
                        principalColumn: "VehicleTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ApacheCumulatives",
                columns: table => new
                {
                    ApacheCumulativeId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    UserVehicleId = table.Column<long>(type: "bigint", nullable: false),
                    AnotherDataColumn = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    BikeTotalDrivenTime = table.Column<long>(type: "bigint", nullable: true),
                    TotalRides = table.Column<long>(type: "bigint", nullable: true),
                    TotalDistanceTravelled = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    BikeBestShortestTime = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    BikeTopSpeed = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    BikeAverageSpeed = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    BikeMaxGforce = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    BikeMaxLeanAngle = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    FirstGearAvgSpeed = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    SecondGearAvgSpeed = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ThirdGearAvgSpeed = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    FourthGearAvgSpeed = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    FifthGearAvgSpeed = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    FirstGearAvgRPM = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    SecondGearAvgRPM = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ThirdGearAvgRPM = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    FourthGearAvgRPM = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    FifthGearAvgRPM = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApacheCumulatives", x => x.ApacheCumulativeId);
                    table.ForeignKey(
                        name: "FK_ApacheCumulatives_UserProfiles_UserId",
                        column: x => x.UserId,
                        principalTable: "UserProfiles",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApacheCumulatives_UserVehicles_UserVehicleId",
                        column: x => x.UserVehicleId,
                        principalTable: "UserVehicles",
                        principalColumn: "UserVehicleId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ApacheNONIOTCumulative",
                columns: table => new
                {
                    ApacheCumulativeId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserVehicleId = table.Column<long>(type: "bigint", nullable: true),
                    UserId = table.Column<long>(type: "bigint", nullable: true),
                    BikeTotalDrivenTime = table.Column<long>(type: "bigint", nullable: true),
                    TotalRides = table.Column<long>(type: "bigint", nullable: true),
                    TotalDistanceTravelled = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    BikeBestShortestTime = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    BikeTopSpeed = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    BikeAverageSpeed = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    BikeMaxGforce = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    BikeMaxLeanAngle = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    BikeMaxAltitude = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApacheNONIOTCumulative", x => x.ApacheCumulativeId);
                    table.ForeignKey(
                        name: "FK_ApacheNONIOTCumulative_UserProfiles_UserId",
                        column: x => x.UserId,
                        principalTable: "UserProfiles",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApacheNONIOTCumulative_UserVehicles_UserVehicleId",
                        column: x => x.UserVehicleId,
                        principalTable: "UserVehicles",
                        principalColumn: "UserVehicleId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "N109Cumulatives",
                columns: table => new
                {
                    N109CumulativeId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    UserVehicleId = table.Column<long>(type: "bigint", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Totalrides = table.Column<long>(type: "bigint", nullable: false),
                    TotalTime = table.Column<long>(type: "bigint", nullable: true),
                    RideTime = table.Column<long>(type: "bigint", nullable: true),
                    TotalTravelledDistance = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    BestShortestTime0to30 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TopSpeed = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AverageSpeed = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CO2Saved = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    LastFuelStatus = table.Column<int>(type: "int", nullable: true),
                    LastBatteryStatus = table.Column<int>(type: "int", nullable: true),
                    LastDistanceToEmpty = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    EcoModeTotalDistance = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PowerModeTotalDistance = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    EcoModeBatteryDistance = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    EcoModeEngineDistance = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PowerModeCombinedBEDistance = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PowerModeOnlyEngDistance = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_N109Cumulatives", x => x.N109CumulativeId);
                    table.ForeignKey(
                        name: "FK_N109Cumulatives_UserProfiles_UserId",
                        column: x => x.UserId,
                        principalTable: "UserProfiles",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_N109Cumulatives_UserVehicles_UserVehicleId",
                        column: x => x.UserVehicleId,
                        principalTable: "UserVehicles",
                        principalColumn: "UserVehicleId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "N251BLECumulative",
                columns: table => new
                {
                    N251BLECumulativeId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    UserVehicleId = table.Column<long>(type: "bigint", nullable: false),
                    TotalRides = table.Column<long>(type: "bigint", nullable: true),
                    TotalTime = table.Column<long>(type: "bigint", nullable: true),
                    RideTime = table.Column<long>(type: "bigint", nullable: true),
                    TotalDistanceOverAll = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TotalDistanceStreetMode = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    BestShortestTimeSportMode = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TopSpeedOverAll = table.Column<long>(type: "bigint", nullable: true),
                    TopSpeedSportMode = table.Column<long>(type: "bigint", nullable: true),
                    TopSpeedStreetMode = table.Column<long>(type: "bigint", nullable: true),
                    AverageSpeedSportMode = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AverageSpeedStreetMode = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AverageSpeedOverAll = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    LastFuelStatus = table.Column<int>(type: "int", nullable: true),
                    LapDistanceSportMode = table.Column<long>(type: "bigint", nullable: true),
                    StreetModeRides = table.Column<long>(type: "bigint", nullable: true),
                    SportModeRides = table.Column<long>(type: "bigint", nullable: true),
                    TotalDistanceSportMode = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    VehicleTypeId = table.Column<int>(type: "int", nullable: true),
                    OdometerReading = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TotalDistanceRaceMode = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TopSpeedRaceMode = table.Column<long>(type: "bigint", nullable: true),
                    AverageSpeedRaceMode = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    RaceModeRides = table.Column<long>(type: "bigint", nullable: true),
                    TopRPMRaceMode = table.Column<long>(type: "bigint", nullable: true),
                    Best0to60RaceMode = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TopRPMStreetMode = table.Column<long>(type: "bigint", nullable: true),
                    RideTimeStreetMode = table.Column<long>(type: "bigint", nullable: true),
                    RideTimeRaceMode = table.Column<long>(type: "bigint", nullable: true),
                    Best0to60StreetMode = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    TopRPM = table.Column<long>(type: "bigint", nullable: true),
                    IdleTime = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_N251BLECumulative", x => x.N251BLECumulativeId);
                    table.ForeignKey(
                        name: "FK_N251BLECumulative_UserProfiles_UserId",
                        column: x => x.UserId,
                        principalTable: "UserProfiles",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_N251BLECumulative_UserVehicles_UserVehicleId",
                        column: x => x.UserVehicleId,
                        principalTable: "UserVehicles",
                        principalColumn: "UserVehicleId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RideCumulative",
                columns: table => new
                {
                    RideCumulativeId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleTypeId = table.Column<long>(type: "bigint", nullable: false),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    UserVehicleId = table.Column<long>(type: "bigint", nullable: false),
                    TotalRides = table.Column<long>(type: "bigint", nullable: true),
                    TotalTime = table.Column<long>(type: "bigint", nullable: true),
                    RideTime = table.Column<long>(type: "bigint", nullable: true),
                    TotalTravelledDistance = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TopSpeed = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AverageSpeed = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    OtherRideParameters = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EcoModeDurationOverall = table.Column<long>(type: "bigint", nullable: true),
                    EcoModeDistanceOverall = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PowerModeDurationOverall = table.Column<long>(type: "bigint", nullable: true),
                    PowerModeDistanceOverall = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CumulativeFeOverall = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AverageMileage = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    FRAME_NO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CONTACT_NO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VehicleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    REG_NO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SALE_DATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ENGINE_NO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DEALER_ID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CUSTOMER_NAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TOV_PART_ID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TOV_MODEL_ID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EMAIL_ADDRESS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LAST_SERVICE_DATE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LAST_SERVICE_TYPE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DMP_PART_ID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DESCRIPTION = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DMP_MODEL_ID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ACTIVE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SERIES = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    COLOR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BRAND_CODE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BRAND_DESC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CONTACT_TYPE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CUSTOMER_ID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IOT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CONNECTED = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NickName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Theme = table.Column<int>(type: "int", nullable: true),
                    BookingId = table.Column<long>(type: "bigint", nullable: true),
                    OnGoingBooking = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsSelected = table.Column<bool>(type: "bit", nullable: true),
                    SelectedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RideCumulative", x => x.RideCumulativeId);
                    table.ForeignKey(
                        name: "FK_RideCumulative_UserProfiles_UserId",
                        column: x => x.UserId,
                        principalTable: "UserProfiles",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RideCumulative_UserVehicles_UserVehicleId",
                        column: x => x.UserVehicleId,
                        principalTable: "UserVehicles",
                        principalColumn: "UserVehicleId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RideCumulative_VehicleType_VehicleTypeId",
                        column: x => x.VehicleTypeId,
                        principalTable: "VehicleType",
                        principalColumn: "VehicleTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "U347Cumulative",
                columns: table => new
                {
                    U347CumulativeId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<long>(type: "bigint", nullable: true),
                    UserVehicleId = table.Column<long>(type: "bigint", nullable: true),
                    TotalRides = table.Column<long>(type: "bigint", nullable: true),
                    TotalTime = table.Column<long>(type: "bigint", nullable: true),
                    RideTime = table.Column<long>(type: "bigint", nullable: true),
                    TotalTravelledDistance = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    BestShortestTime0to30 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TopSpeed = table.Column<long>(type: "bigint", nullable: true),
                    AverageSpeed = table.Column<long>(type: "bigint", nullable: true),
                    CO2Saved = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    LastBatteryStatus = table.Column<int>(type: "int", nullable: true),
                    LstDistanceToEmpty = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    EcoModeTotalDistance = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PowerModeTotalDistance = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_U347Cumulative", x => x.U347CumulativeId);
                    table.ForeignKey(
                        name: "FK_U347Cumulative_UserProfiles_UserId",
                        column: x => x.UserId,
                        principalTable: "UserProfiles",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_U347Cumulative_UserVehicles_UserVehicleId",
                        column: x => x.UserVehicleId,
                        principalTable: "UserVehicles",
                        principalColumn: "UserVehicleId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApacheCumulatives_UserId",
                table: "ApacheCumulatives",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ApacheCumulatives_UserVehicleId",
                table: "ApacheCumulatives",
                column: "UserVehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_ApacheNONIOTCumulative_UserId",
                table: "ApacheNONIOTCumulative",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ApacheNONIOTCumulative_UserVehicleId",
                table: "ApacheNONIOTCumulative",
                column: "UserVehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_EmergencyContact_UserId",
                table: "EmergencyContact",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_N109Cumulatives_UserId",
                table: "N109Cumulatives",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_N109Cumulatives_UserVehicleId",
                table: "N109Cumulatives",
                column: "UserVehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_N251BLECumulative_UserId",
                table: "N251BLECumulative",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_N251BLECumulative_UserVehicleId",
                table: "N251BLECumulative",
                column: "UserVehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_RideCumulative_UserId",
                table: "RideCumulative",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_RideCumulative_UserVehicleId",
                table: "RideCumulative",
                column: "UserVehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_RideCumulative_VehicleTypeId",
                table: "RideCumulative",
                column: "VehicleTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_U347Cumulative_UserId",
                table: "U347Cumulative",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_U347Cumulative_UserVehicleId",
                table: "U347Cumulative",
                column: "UserVehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserVehicles_UserId",
                table: "UserVehicles",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserVehicles_VehicleTypeId",
                table: "UserVehicles",
                column: "VehicleTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApacheCumulatives");

            migrationBuilder.DropTable(
                name: "ApacheNONIOTCumulative");

            migrationBuilder.DropTable(
                name: "EmergencyContact");

            migrationBuilder.DropTable(
                name: "HomeVideo");

            migrationBuilder.DropTable(
                name: "N109Cumulatives");

            migrationBuilder.DropTable(
                name: "N251BLECumulative");

            migrationBuilder.DropTable(
                name: "RideCumulative");

            migrationBuilder.DropTable(
                name: "U347Cumulative");

            migrationBuilder.DropTable(
                name: "UserVehicles");

            migrationBuilder.DropTable(
                name: "UserProfiles");

            migrationBuilder.DropTable(
                name: "VehicleType");
        }
    }
}
