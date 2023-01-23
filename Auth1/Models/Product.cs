using System.ComponentModel.DataAnnotations;

namespace FITNESSGYM.Models
{
    public class Product
    {
        public int Id { get; set; }
        
        [MaxLength(50), MinLength(3)]
        public string? Name { get; set; }
        
        [MaxLength(500)]
        public string? Description { get; set; }

        [DataType(DataType.Upload)]
        [Display(Name = "Upload File")]
        //[Required(ErrorMessage = "Please choose file to upload.")]
        public string? Photo { get; set; }
        public int Price { get; set; }
    }
}
