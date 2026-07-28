using EFCoreProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreProject
{
    public class ProjectContext : DbContext
    {
        // 1. resigster models
        public DbSet<Employee> employees {  get; set; }
        public DbSet<Department> departments { get; set; }
        public DbSet<Dependent> dependents { get; set; }
        public DbSet<Project> projects { get; set; }

        // 2. connect to database
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(
                "Server=DESKTOP-IBEP3PJ\\SQLEXPRESS;Database=CompanyProjectDataBase;Trusted_Connection=True;TrustServerCertificate=True;"
            );
        }
    }
}
