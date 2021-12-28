using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CartoonMVC.Models
{
    public class Monster
    {
        [Required]
        public int Id { get; set; }

        [StringLength(50, MinimumLength = 3)]
        [Display(Name = "Namn")]
        [Required(ErrorMessage = "Du måste skriva i ett namn på monstret")]
        public string Name { get; set; }

        [Display(Name = "Ålder")]
        [Range(1, 10000)]
        public int Age { get; set; }

        [Display(Name = "IQ 1-100")]
        [Range(1,100)]
        public int IQ { get; set; }

        [Display(Name = "Sågs senast:")]
        [DataType(DataType.Date)]
        public DateTime SeenLastTime { get; set; }

        [StringLength(50, MinimumLength = 2)]
        [Required(ErrorMessage = "Du måste skriva i ett Element för sökningens skull")]
        public string? Element { get; set; }

        [Display(Name = "VARNING")]
        public string? Warning { get; set; }

        [Display(Name = "Svaghet")]
        public string? Weaknesses { get; set; }

        [Range(1, 100)]
        [Display(Name = "Styrka 1-100")]
        public int Strength { get; set; }

        [Range(1, 100)]
        [Display(Name = "Snabbhet 1-100")]
        public int Speed { get; set; }

        [Range(1, 100)]
        [Display(Name = "Ilska 1-100")]
        public int Naughtiness { get; set; }

        [Range(1, 100)]
        [Display(Name = "Farlighet 1-100")]
        public int DegreeOfDanger { get; set; }
        
        public string? Information { get; set; }
        
        [Display(Name = "Bild")]
        public string? ImageUrl { get; set; }
    }
}
