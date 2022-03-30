using System.ComponentModel.DataAnnotations;

namespace MobileShop.Domain
{
    public class MemoryAndProcessor
    {
        [Key]
        [Required]
        public Guid Id { get; set; }
        public string CPU { get; set; }
        public int NumberOfCores { get; set; }
        public string VideoProcessor { get; set; }
        public string RAM { get; set; }
        public string ROM { get; set; }
    }
}