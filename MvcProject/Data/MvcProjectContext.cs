using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace MvcProject.Data
{
    public class MvcProjectContext : DbContext
    {
        public MvcProjectContext(DbContextOptions<MvcProjectContext> options)
            : base(options)
        {
            // Database.EnsureDeleted();
            Database.EnsureCreated();
        }
       

        public DbSet<MvcMovie.Models.Movie> Movie { get; set; } = default!; //свойство DbSet<Movie>, представляющее фильмы в базе данных.
    }
}
