
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace FITNESSGYM.Models
{
    public class Coach
    {
        public int ID { get; set; }
        [Required]
        [MaxLength(10)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(10)]
        public string LastName { get; set; }

        public string? Photo { get; set; }
        [NotMapped]

        public IFormFile? File { get; set; }

        [Display(Name = "Speciality")]
        public int? IdSpeciality { get; set; }

        [ForeignKey("IdSpeciality")]
        public virtual Speciality? Speciality { get; set; }


    }
}
