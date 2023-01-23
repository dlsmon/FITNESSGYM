
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace FITNESSGYM.Models
{
    public class Coach
    {
        public int ID { get; set; }
        
        public string? Description { get; set; }
        
        //[Required(ErrorMessage = "Please choose file to upload.")]
        [DataType(DataType.Upload)]
        [Display(Name = "Upload File")]
        public string? Photo { get; set; }
        [Display(Name = "Speciality")]


        //foreign key
        public int? IdSpeciality { get; set; }
       
        [ForeignKey("IdSpeciality")]
        public virtual Speciality? Speciality { get; set; }


    }
}
