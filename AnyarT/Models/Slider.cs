using System.ComponentModel.DataAnnotations;

namespace AnyarT.Models
{
    public class Slider : BaseEntity
    {
        [MaxLength(32), Required]
        public string FullName { get; set; }


        [MaxLength(64), Required]
        public string Subtitle1 { get; set; }


        [MaxLength(64), Required]
        public string Subtitle2 { get; set; }

        public string ImageUrl { get; set; }
    }
}
