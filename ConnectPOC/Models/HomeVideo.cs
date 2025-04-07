using System.ComponentModel.DataAnnotations;

namespace ConnectPOC.Models
{
    public class HomeVideo
    {
        [Key]
        public long VideoLinkId { get; set; }
        public string? VideoLink { get; set; }
        public string? VideoThumbnailLink { get; set; }
        public string? Title { get; set; }

    }
}
