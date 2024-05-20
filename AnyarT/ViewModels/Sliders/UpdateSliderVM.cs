using System.ComponentModel.DataAnnotations;

namespace AnyarT.ViewModels.Sliders
{
    public class UpdateSliderVM
    {
        [MaxLength(32, ErrorMessage = "uzunluq 32den cox ola bilmez"), Required]
        public string FullName { get; set; }


        [MaxLength(64), Required]
        public string Subtitle1 { get; set; }


        [MaxLength(64), Required]
        public string Subtitle2 { get; set; }

        public string ImageUrl { get; set; }
    }
}
