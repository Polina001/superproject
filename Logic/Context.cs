using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    class Context : DbContext
    {
        public DbSet<Theme> Themes { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Inscription> Inscriptions { get; set; }

        public Context() : base("localsql")
        {

        }
    }
}
