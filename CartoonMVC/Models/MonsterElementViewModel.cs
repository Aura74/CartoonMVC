using Microsoft.AspNetCore.Mvc.Rendering;

namespace CartoonMVC.Models
{
    public class MonsterElementViewModel
    {
        public List<Monster>? Monsters { get; set; }
        public SelectList? Elements { get; set; }
        public string? MonsterElement { get; set; }
        public string? SearchString { get; set; }
    }
}
