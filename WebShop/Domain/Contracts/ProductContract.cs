using System.ComponentModel.DataAnnotations;

namespace Domain.Contracts
{
    public class ProductContract
    {
        [Required(ErrorMessage = "the field Description is required")]
        [Display(Name ="Description")]
        public string Description { get; set; }

        [Required(ErrorMessage = "the field Product Number is required")]
        [Display(Name = "Product Number")]
        public int ProductNumber { get; set; }

        [Required(ErrorMessage = "the field Price is required")]
        [Display(Name = "Price")]
        public decimal Price { get; set; }
    }
}
