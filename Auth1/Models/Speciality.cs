using System.ComponentModel.DataAnnotations;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FITNESSGYM.Models
{
    public class Speciality
    {
        public int Id { get; set; }
        
        [MaxLength(50)]
        public string? Name { get; set; }
        //public override string ToString()
        //{
        //    return $"{Name}";
        //}
    }
}
