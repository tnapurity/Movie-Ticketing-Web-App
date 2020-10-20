using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AspNetCoreTodo.Models;

namespace AspNetCoreTodo.Data
{
    public class DBContext : DbContext
    {
        public DBContext (DbContextOptions<DBContext> options)
            : base(options)
        {
        }

        public DbSet<AspNetCoreTodo.Models.Movie> Movie { get; set; }

        public DbSet<AspNetCoreTodo.Models.Users> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {



            base.OnModelCreating(builder);
        }

        public DbSet<AspNetCoreTodo.Models.Reservation> Reservation { get; set; }
    }
}
