using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Tools.Models;

namespace HvacTools.Mobile.Database
{
    public class MobileContext : DbContext
    {
        #region Member Variables
        private string SqlitePath { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<ServiceRecord> ServiceRecords { get; set; }

        #endregion

        #region Constructor(s)
        public MobileContext(string sqliteDbPath)
        {
            SqlitePath = sqliteDbPath;
        }
        #endregion

        #region Class Methods
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // use Sqlite Extensions here.
            optionsBuilder.UseSqlite($"Filename={SqlitePath}");
        }
        #endregion


    }

    
}
