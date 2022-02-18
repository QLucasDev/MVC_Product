using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MVC_Product.Models
{
    public class Product
    {
        public int ID { get; set; }

        [Display(Name ="Nome")]
        public string? Name { get; set; }   
        
        [Display(Name ="Data de fabricação")]
        [DataType(DataType.Date)]
        public DateTime MfgDate { get; set; }

        [Display(Name = "Preço")]
        public decimal Price { get; set; }
    }
}
