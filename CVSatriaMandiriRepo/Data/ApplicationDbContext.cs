using System;
using Microsoft.EntityFrameworkCore;

namespace CVSatriaMandiriRepo.Data
{
	public class ApplicationDbContext:DbContext
	{
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        //public DbSet<Pasien> Pasiens { get; set; }
        //public DbSet<Riwayat> Riwayats { get; set; }
        //public DbSet<Config> Configs { get; set; }
        //public DbSet<DtRiwayat> DtRiwayats { get; set; }
        //public DbSet<Pengguna> Penggunas { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Pengguna>().HasData(
        //    new Pengguna()
        //    {
        //        Username = "ariansyah",
        //        Password = "rsjko123",
        //        Role = "Superadmin"
        //    },

        //    new Pengguna()
        //    {
        //        Username = "admin",
        //        Password = "rsjko123",
        //        Role = "Admin"
        //    });

        //    modelBuilder.Entity<Config>().HasData(
        //      new Config()
        //      {
        //          Id = 1,
        //          config_key = "RekamMedis",
        //          config_value = 0
        //      });
        //}
    }
}

