#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using razorMovies2.Models;

namespace razorMovies2.Data
{
    public class razorMovies2Context : DbContext
    {
        public razorMovies2Context (DbContextOptions<razorMovies2Context> options)
            : base(options)
        {
        }

        public DbSet<razorMovies2.Models.Movie> Movie { get; set; }
    }
}
