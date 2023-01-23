using System.ComponentModel.DataAnnotations;

namespace FITNESSGYM.Models
{
    public class Location
    {
        [Key]
        public int ID { get; set; }
        public string? Name { get; set; }
        
        [StringLength(160)]
        public string? Address { get; set; }
        public string? City { get; set; }

        [DataType(DataType.PostalCode)]
        [Display(Name = "Postal Code")]
        public int? PostalCode { get; set; }
         
        [Display(Name = "Maximum number of active Participants at this location")]
        public int? MaxParticipants { get; set; }
        public virtual ICollection<MachineLocation>? MachineLocation { get; set; }
    }
}

