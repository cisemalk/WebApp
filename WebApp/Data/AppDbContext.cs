using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using WebApp.Models;

namespace WebApp.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(string connectionString):base(connectionString)
        {
        }

        public IDbSet<TblEmployee> TblEmployees { get; set; }

        protected void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblEmployee>().ToTable("Employee");
        }
    }
}