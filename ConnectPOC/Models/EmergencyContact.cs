using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConnectPOC.Models
{
    public class EmergencyContact
    {
        [Key]
        public long EmergencyContactId { get; set; }

        [ForeignKey("UserProfile")]
        public long UserId { get; set; }
        public string? EmergencyContactNumber { get; set; }
        public string? ContactImagePath { get; set; }
        public string? ContactName { get; set; }
        public bool? IsDeleted { get; set; }
        public string? Email { get; set; }

        // Navigation Properties
        public UserProfile UserProfile { get; set; }

    }
}
