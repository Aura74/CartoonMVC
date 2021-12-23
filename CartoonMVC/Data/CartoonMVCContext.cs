#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CartoonMVC.Models;

namespace CartoonMVC.Data
{
    public class CartoonMVCContext : DbContext
    {
        public CartoonMVCContext (DbContextOptions<CartoonMVCContext> options)
            : base(options)
        {
        }

        public DbSet<CartoonMVC.Models.Monster> Monster { get; set; }
    }
}
