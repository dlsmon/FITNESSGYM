using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FITNESSGYM.Models
{
    public class Goal
    {        
        public enum eFrequency
        {
            Zero,
            One,
            Two,
            Tree,
            Four,
            Five,
            Six,
            Seven,
        }

        [Key]
        public int Id { get; set; }
        public int? Weight { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Update date")]
        public DateTime? UpdateDate { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Goal date")]
        public DateTime? GoalDate { get; set; }

        // Fréquence de 0 à 7 fois par semaines
        public eFrequency Frequency { get; set; }

        [Display(Name = "Calories Burnt")]
        public int? CaloriesBurnt { get; set; }
        public int IdClient { get; set; }


        //ForeignKey - relations properties

        [ForeignKey("IdClient")]
        public virtual Client? Client { get; set; }
             
    }
}
