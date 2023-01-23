﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FITNESSGYM.Models
{
    public class FavoriteTrainingProgram
    {
        [Key]
        public int Id { get; set; }
        public int IdClient { get; set; }
        public int IdTrainingProgram { get; set; }

        //ForeignKey - relations properties

        [ForeignKey("IdClient")]
        public virtual Client? Client { get; set; }
       
        [ForeignKey("IdTrainingProgram")]
        public virtual TrainingProgram? TrainingProgram { get; set; }
    }
}
