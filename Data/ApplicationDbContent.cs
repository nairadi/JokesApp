using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JokesWebApp.Models;

namespace JokesWebApp.Data
{
    public class ApplicationDbContent : DbContext
    {
        public ApplicationDbContent (DbContextOptions<ApplicationDbContent> options)
            : base(options)
        {
        }

        public DbSet<JokesWebApp.Models.Joke> Joke { get; set; } = default!;
    }
}
