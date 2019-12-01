using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Supermarket.MVC.Models;

namespace EtyReviews.MVC.Data
{
    public class ApplicationDbContext : IdentityDbContext<User, IdentityRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }

        public DbSet<Review> Reviews { get; set; }

        public override DbSet<User> Users { get => base.Users; set => base.Users = value; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Book>().HasMany(c => c.Reviews).WithOne(e => e.Book).HasForeignKey(k => k.BookId);
            builder.Entity<Review>().HasOne(c => c.User).WithMany(c => c.Reviews).HasForeignKey(k => k.UserId);
            builder.Entity<User>().HasMany(u => u.Reviews).WithOne(r => r.User).HasForeignKey(k => k.UserId);
        }
    }
}
