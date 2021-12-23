using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace CartoonMVC.Models
{
    public class Monster
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Range(1, 10000)]
        public int Age { get; set; }

        [Range(1,10000)]
        public int IQ { get; set; }

        [DataType(DataType.Date)]
        public DateTime SeenLastTime { get; set; }

        public string? Element { get; set; }
        public string? Warning { get; set; }
        public string? Weaknesses { get; set; }
        public int Strength { get; set; }
        public int Speed { get; set; }
        public int Naughtiness { get; set; }
        public int DegreeOfDanger { get; set; }
        public string? Information { get; set; }
        public string? ImageUrl { get; set; }
        
    }
}
