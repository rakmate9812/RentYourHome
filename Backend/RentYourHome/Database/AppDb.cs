using Microsoft.EntityFrameworkCore;
using RentYourHome.Database.Models;
using System.Collections.Generic;

namespace RentYourHome.Database
{

    /// <summary>
    /// Configuring the database context with EF Core DbContext
    /// </summary>
    public class AppDb : DbContext
    {
        public IConfiguration Config { get; set; }

        public AppDb(IConfiguration config)
        {
            Config = config;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // The GetConnectionString() will look for the appsettings.Development.json first, where it should find the connectionstring with the key "Local"
            // If there is no appsettings.Development.json, it will look for the appsettings.json for "Local"
            // My appsettings.Development.json looks like this: 
            //{
            //    "ConnectionStrings": {
            //        "Local": "Data Source={{MY DESKTOP MS SQL CONNECTION}};Initial Catalog={{DATABASE NAME}};Integrated Security=True;Trust Server Certificate=True"
            //    }
            //}
            optionsBuilder.UseSqlServer(Config.GetConnectionString("Local")); 
        }

        public DbSet<Test> Tests { get; set; } // Database Table
    }
}
