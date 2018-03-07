using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using HvacTools.Mobile.Models;


namespace HvacTools.Mobile.Database
{
    public class MobileReferenceContext : DbContext
    {
        #region Member Variables
        private string SqlitePath { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<Refrigerant> Refrigerants { get; set; }
        public DbSet<RefrigerantType> RefrigerantTypes { get; set; }

        #endregion

        #region Constructor(s)
        public MobileReferenceContext(string dbPath)
        {
            if (dbPath == null || dbPath == string.Empty)
                throw new Exception("Invalid sqlite database path.");

            SqlitePath = dbPath;
        }
        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // use Sqlite Extensions here.
            optionsBuilder.UseSqlite($"Filename={SqlitePath}");
        }
        

    }
}
