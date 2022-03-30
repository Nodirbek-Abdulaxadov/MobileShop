using System.ComponentModel.DataAnnotations;

namespace MobileShop.Domain
{
    public class Additionally
    {
        [Key]
        [Required]
        public Guid Id { get; set; }
        public string Equipment { get; set; }
        public string BatteryType { get; set; }
        public double BatteryCapacity { get; set; }
        public string ChargerType { get; set; }
    }
}