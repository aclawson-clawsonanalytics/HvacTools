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
        public DbSet<ILocation> Locations { get; set; }
    }
}
