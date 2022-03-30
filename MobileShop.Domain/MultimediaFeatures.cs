using System.ComponentModel.DataAnnotations;

namespace MobileShop.Domain
{
    public class MultimediaFeatures
    {
        [Key]
        [Required]
        public Guid Id { get; set; }
        public int NumberOfCameras { get; set; }
        public string Cameras { get; set; }
        public string Flash { get; set; }
        public string FrontCamera { get; set; }
        public string AudioSupport { get; set; }
    }
}