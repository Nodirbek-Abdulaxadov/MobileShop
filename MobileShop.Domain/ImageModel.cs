using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileShop.Domain
{
    public class ImageModel
    {
        [Key]
        public Guid Id { get; set; }
        public string Path { get; set; }
        public Guid ProductId { get; set; }
    }
}
