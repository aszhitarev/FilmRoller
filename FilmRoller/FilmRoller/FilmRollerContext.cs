using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace FilmRoller
{
    class FilmRollerContext
    {
        class FilmRollerContext : DbContext
        {
            public FilmRollerContext()
                : base("FilmRoller")
            { }

            public DbSet<Film> Films { get; set; }
            public DbSet<Owner> Owners { get; set; }
            public DbSet<Review> Reviews { get; set; }
        }
    }
}
