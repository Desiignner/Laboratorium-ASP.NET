using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{

        public class AppDbContext : DbContext
        {
            public DbSet <ComputerEntity> Computer { get; set; }
            private string DbPath { get; set; }
            public AppDbContext()
            {
                var folder = Environment.SpecialFolder.LocalApplicationData;
                var path = Environment.GetFolderPath(folder);
                DbPath = System.IO.Path.Join(path, "computers.db");
            }
            protected override void OnConfiguring(DbContextOptionsBuilder options) =>
            options.UseSqlite($"Data Source={DbPath}");

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<ContactEntity>().HasData(
                    new ComputerEntity() { Id = 1, Nazwa = "Domowy", Procesor = "Intel Core i5-12400F", Memory = "8", Karta_Graficzna = "Brak", Producent = "MSI", Data_Produkcji = new DateTime(2021, 10, 20) , Priority = 0 },
                    new ComputerEntity() { Id = 1, Nazwa = "Gamingowy", Procesor = "INTEL Core i9-13900KF", Memory = "32", Karta_Graficzna = "MSI GeForce RTX 4060 Gaming X 8GB", Producent = "Asus", Data_Produkcji = new DateTime(2023, 11, 23), Priority = 0 }
                );
            }
        }
 }

