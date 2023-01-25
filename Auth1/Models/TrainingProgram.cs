﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FITNESSGYM.Models
 
{
    public class TrainingProgram
    {
        public enum eIntensity
        {
            Soft,
            Easy,
            Medium,
            Hard, 
            Extreme
        }

        [Key]
        public int Id { get; set; }

        //Training Program Name
        [Display(Name = "Training Program Name")]
        public string? Name { get; set; }
        public string? Description { get; set; }

        //Training Program Intensity
        [Required]
        [Display(Name = "Intensity")]
        public eIntensity? Intensity { get; set; }

        //Training Program Duration
        [Display(Name = "Duration (Minutes)")]
        public int? Duration { get; set; }

        //Training Program Calories
        [Display(Name = "Calories (Kcal)")]
        public int? Calories { get; set; }

        public string? Photo { get; set; }
        [NotMapped]
        public IFormFile? File { get; set; }

        public virtual ICollection<Session>? Sessions { get; set; }

    }
}
