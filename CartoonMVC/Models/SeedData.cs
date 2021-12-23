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
                        Name = "Harry",
                        Age = 33,
                        IQ = 98,
                        SeenLastTime = DateTime.Parse("1989-2-12"),
                        Element = "Water",
                        Warning = "Bad As",
                        Weaknesses = "Flowers",
                        Strength = 5,
                        Speed = 3,
                        Naughtiness = 7,
                        DegreeOfDanger = 8,
                        Information = "Nästan inget",
                        ImageUrl = "https://drive.google.com/file/d/1jaEKIHSY7pNtDxcQPRfAKk6mqMG43TfP/view?usp=sharing"
                    }
                    
                );
                context.SaveChanges();
            }
        }
    }
}
