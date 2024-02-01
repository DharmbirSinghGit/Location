using System.ComponentModel.DataAnnotations;

namespace Location.Model
{
    public class LocationModel
    {
        [Required]
        public string Id {  get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public DateTime StartTime { get; set; }
        [Required]
        public DateTime EndTime { get; set; } 
    }
}

