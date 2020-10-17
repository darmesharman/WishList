using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WishList.Models
{
    public class WishListContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Item> Items { get; set; }
        public WishListContext(DbContextOptions<WishListContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
