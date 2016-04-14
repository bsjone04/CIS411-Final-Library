﻿using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace CIS411_Final_Library.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Checkout> Checkouts { get; set; }
        public DbSet<Rate> Rates { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

        //    modelBuilder.Entity<Book>()
        //        .HasMany(c => c.Rates).WithMany(i => i.Books)
        //        .Map(t => t.MapLeftKey("BookId")
        //            .MapRightKey("RateId")
        //            .ToTable("Book_Rate"));


        //    modelBuilder.Entity<Book>()
        //        .HasMany(c => c.Checkouts).WithMany(i => i.Books)
        //        .Map(t => t.MapLeftKey("BookId")
        //            .MapRightKey("CheckoutId")
        //            .ToTable("Book_CheckOut"));
        //}

        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
         
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        //public System.Data.Entity.DbSet<CIS411_Final_Library.Models.SchoolModel> SchoolModels { get; set; }
    }
}