using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CartoonMVC.Data;
using System;
using System.Linq;

namespace CartoonMVC.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new CartoonMVCContext(
                       serviceProvider.GetRequiredService<
                           DbContextOptions<CartoonMVCContext>>()))
            {
                // Look for any movies.
                if (context.Monster.Any())
                {
                    return;   // DB has been seeded
                }

                context.Monster.AddRange(
                    new Monster
                    {
                        Name = "Hemske Harry",
                        Age = 33,
                        IQ = 78,
                        SeenLastTime = DateTime.Parse("2016-2-22"),
                        Element = "Vatten",
                        Warning = "Han kan lipa så att blodet i dina ådror surnar. ",
                        Weaknesses = "Harry hatar blommor av alla de slag. ",
                        Strength = 50,
                        Speed = 30,
                        Naughtiness = 77,
                        DegreeOfDanger = 67,
                        Information = "Det enda som kan hindra honom från att sträcka ut sin tunga är citronpulver",
                        ImageUrl = "https://github.com/Aura74/Monsterbilder/blob/main/%E2%80%94Pngtree%E2%80%94bug%20tongue%20bacteria_4637904.png?raw=true"
                    },

                    new Monster
                    {
                        Name = "Sally den Sure",
                        Age = 44,
                        IQ = 55,
                        SeenLastTime = DateTime.Parse("1988-8-18"),
                        Element = "Jord",
                        Warning = "Bad As, har en personlighet som en gammal disktrasa",
                        Weaknesses = "Salt",
                        Strength = 29,
                        Speed = 43,
                        Naughtiness = 63,
                        DegreeOfDanger = 79,
                        Information = "Ful som stryk",
                        ImageUrl = "https://github.com/Aura74/Monsterbilder/blob/main/%E2%80%94Pngtree%E2%80%94pop%20style%20evil%20beauty%20manga_5892161.png?raw=true"
                    },

                    new Monster
                    {
                        Name = "Spöket Labans onde tvilling",
                        Age = 66,
                        IQ = 71,
                        SeenLastTime = DateTime.Parse("2001-9-2"),
                        Element = "Luft",
                        Warning = "Syns knapt",
                        Weaknesses = "Hårtorkar och Biden",
                        Strength = 14,
                        Speed = 23,
                        Naughtiness = 55,
                        DegreeOfDanger = 36,
                        Information = "Ganska så ofarlig, kan blåsas bort av exempelvis en hårtork. ",
                        ImageUrl = "https://github.com/Aura74/Monsterbilder/blob/main/pngwing.com%20(23).png?raw=true"
                    },

                    new Monster
                    {
                        Name = "Förvånade Cyklopen Bolle",
                        Age = 6,
                        IQ = 69,
                        SeenLastTime = DateTime.Parse("2021-4-12"),
                        Element = "Jord",
                        Warning = "Smartare än vad man kan tro",
                        Weaknesses = "Överraskningar som att en politiker håller vad den lovar. ",
                        Strength = 29,
                        Speed = 93,
                        Naughtiness = 55,
                        DegreeOfDanger = 78,
                        Information = "Blir lätt förvånad. ",
                        ImageUrl = "https://github.com/Aura74/Monsterbilder/blob/main/pngwing.com%20(45).png?raw=true"
                    },

                    new Monster
                    {
                        Name = "Bomben Explode",
                        Age = 87,
                        IQ = 68,
                        SeenLastTime = DateTime.Parse("2001-9-11"),
                        Element = "Eld",
                        Warning = "Rund",
                        Weaknesses = "Vatten",
                        Strength = 29,
                        Speed = 43,
                        Naughtiness = 44,
                        DegreeOfDanger = 100,
                        Information = "Kan explodera, sågs senat vi Norad",
                        ImageUrl = "https://github.com/Aura74/Monsterbilder/blob/main/pngwing.com%20(50).png?raw=true"
                    },

                    new Monster
                    {
                        Name = "Blå Tokig",
                        Age = 125,
                        IQ = 23,
                        SeenLastTime = DateTime.Parse("1958-5-25"),
                        Element = "Luft",
                        Warning = "Tokig",
                        Weaknesses = "Uppslagsböcker",
                        Strength = 88,
                        Speed = 12,
                        Naughtiness = 63,
                        DegreeOfDanger = 59,
                        Information = "Ful som stryk",
                        ImageUrl = "https://github.com/Aura74/Monsterbilder/blob/main/pngwing.com%20(53).png?raw=true"
                    },

                    new Monster
                    {
                        Name = "Blås-Fisken",
                        Age = 144,
                        IQ = 55,
                        SeenLastTime = DateTime.Parse("1874-3-22"),
                        Element = "Vatten",
                        Warning = "En fena på att simma",
                        Weaknesses = "Torra land",
                        Strength = 59,
                        Speed = 82,
                        Naughtiness = 8,
                        DegreeOfDanger = 69,
                        Information = "Hal som en ål",
                        ImageUrl = "https://github.com/Aura74/Monsterbilder/blob/main/%E2%80%94Pngtree%E2%80%94blue%20fish%20cartoon%20image%20clipart_5531417.png?raw=true"
                    },

                    new Monster
                    {
                        Name = "Mördarsnigeln Race",
                        Age = 1,
                        IQ = 22,
                        SeenLastTime = DateTime.Parse("2019-9-2"),
                        Element = "Jord",
                        Warning = "Liten",
                        Weaknesses = "Vitaminer",
                        Strength = 5,
                        Speed = 2,
                        Naughtiness = 7,
                        DegreeOfDanger = 18,
                        Information = "Kan under flera år förflytta sig flera meter.",
                        ImageUrl = "https://github.com/Aura74/Monsterbilder/blob/main/%E2%80%94Pngtree%E2%80%94phone%20bug%20commercial%20element_4083767.png?raw=truee"
                    },

                    new Monster
                    {
                        Name = "Dino-Fino",
                        Age = 10840,
                        IQ = 55,
                        SeenLastTime = DateTime.Parse("1224-2-1"),
                        Element = "Jord",
                        Warning = "Stor som ett hus",
                        Weaknesses = "Flowers",
                        Strength = 99,
                        Speed = 15,
                        Naughtiness = 70,
                        DegreeOfDanger = 89,
                        Information = "Gammal som gatan",
                        ImageUrl = "https://github.com/Aura74/Monsterbilder/blob/main/%E2%80%94Pngtree%E2%80%94cartoon%20dinosaur%20with%20headphones%20listening_6612212.png?raw=true"
                    },

                    new Monster
                    {
                        Name = "Death Pumpan",
                        Age = 95979,
                        IQ = 33,
                        SeenLastTime = DateTime.Parse("1795-8-18"),
                        Element = "Luft",
                        Warning = "Rör du honom så dör du",
                        Weaknesses = "Änglar",
                        Strength = 22,
                        Speed = 71,
                        Naughtiness = 60,
                        DegreeOfDanger = 78,
                        Information = "Kommer i luften",
                        ImageUrl = "https://github.com/Aura74/Monsterbilder/blob/main/%E2%80%94Pngtree%E2%80%94cartoon%20of%20death%20sitting%20in_6851209.png?raw=true"
                    },

                    new Monster
                    {
                        Name = "Vägra sova barnet",
                        Age = 4,
                        IQ = 87,
                        SeenLastTime = DateTime.Parse("2021-12-27"),
                        Element = "Jord",
                        Warning = "Gapa inte när han kommer i närheten",
                        Weaknesses = "Sängar, grönsaker och sovmornar",
                        Strength = 70,
                        Speed = 33,
                        Naughtiness = 22,
                        DegreeOfDanger = 41,
                        Information = "Tycker inte om när hon inte får som hon vill. ",
                        ImageUrl = "https://c.tenor.com/qsY750wZxAEAAAAd/angry-mad.gif"
                    },

                new Monster
                    {
                        Name = "Döda Draken",
                        Age = 4425694,
                        IQ = 55,
                        SeenLastTime = DateTime.Parse("1963-12-10"),
                        Element = "Eld",
                        Warning = "Hård fjäll",
                        Weaknesses = "Hobbitar",
                        Strength = 99,
                        Speed = 95,
                        Naughtiness = 98,
                        DegreeOfDanger = 100,
                        Information = "Jättefarlig",
                        ImageUrl = "https://github.com/Aura74/Monsterbilder/blob/main/%E2%80%94Pngtree%E2%80%94pop%20beauty%20man%20lollipop%20dragon_6653531.png?raw=true"
                }

                );
                context.SaveChanges();
            }
        }
    }
}
