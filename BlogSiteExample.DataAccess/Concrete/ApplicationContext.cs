using BlogSiteExample.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSiteExample.DataAccess.Concrete
{
    public class ApplicationContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=BlogSiteExample;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Message2>()
                .HasOne(x => x.SenderUserID)
                .WithMany(x => x.SenderMessages)
                .HasForeignKey(x => x.Sender)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<Message2>()
                .HasOne(x => x.RecieverID)
                .WithMany(x => x.RecieverMessager)
                .HasForeignKey(x => x.Reciever)
                .OnDelete(DeleteBehavior.ClientSetNull);
                
               
                
            
         }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<BlogRating> BlogsRatings { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Newsletter> Newsletters { get; set; }
        public DbSet<Writer> Writers { get; set; }
        public DbSet<Message2> Message2s { get; set; }
        public DbSet<Message> Messages { get; set; }
    }
}
