﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FITNESSGYM.Models
{
    public class FavoriteCoach
    {
        [Key]
        public int Id { get; set; }
        public int IdClient { get; set; }
        public int IdCoach { get; set; }

        //ForeignKey - relations properties

        [ForeignKey("IdClient")]
        public virtual Client? Client { get; set; }

        [ForeignKey("IdCoach")]
        public virtual Coach? Coach { get; set; }
        
    }
}
