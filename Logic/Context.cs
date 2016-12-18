using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Context : DbContext
    {
        public DbSet<Theme> Theme { get; set; }
        public DbSet<Inscription> Inscription { get; set; }
        public DbSet<PictureForProject> Pictures { get; set; }

        public Context() : base("localsql")
        {
                
        }
    }
}
