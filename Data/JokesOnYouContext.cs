using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JokesOnYou.Models;

namespace JokesOnYou.Data
{
    public class JokesOnYouContext : DbContext
    {
        public JokesOnYouContext (DbContextOptions<JokesOnYouContext> options)
            : base(options)
        {
        }

        public DbSet<JokesOnYou.Models.Joke>? Joke { get; set; }
    }
}
