using Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class AppDbContext: DbContext
    {
        public DbSet<ContactEntity> Contacts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"data sourece = d:\contacts.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ContactEntity>()
                .HasKey(e => e.ContactId);
            modelBuilder.Entity<ContactEntity>()
                .HasData(
            new ContactEntity()
            {
                ContactId = 1,
                Name = "Test",
                Email = "Test@mail.pl",
                Phone = "647859276",
                Priority = 1,

            },
            new ContactEntity()
            {
                ContactId = 2,
                Name = "Test1",
                Email = "Test1@mail.pl",
                Phone = "647415276",
                Priority = 3,
                Birth = new DateTime(2000, 11, 12)

            }

        );


        }
    }
}
