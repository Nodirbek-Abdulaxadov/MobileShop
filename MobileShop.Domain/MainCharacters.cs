using System.ComponentModel.DataAnnotations;

namespace MobileShop.Domain
{
    public class MainCharacters
    {
        [Key]
        [Required]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string OSVersion { get; set; }
        public string TypeOfFrame { get; set; }
        public Confirm IsDual { get; set; }
        public double Weight { get; set; }
        public string Dimensions { get; set; }
        public Confirm HasFingerPrintScanner { get; set; }
        public string Model { get; set; }
        public string SimCardType { get; set; }
    }


    public enum Confirm
    {
        No,
        Yes
    }
}
