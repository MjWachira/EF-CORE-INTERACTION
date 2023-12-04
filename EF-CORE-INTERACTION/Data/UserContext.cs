using EF_CORE_INTERACTION.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CORE_INTERACTION.Data
{
    public class UserContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Server=JOHNNY;Database=TestDB;Trusted_Connection=True;TrustServerCertificate=True;");
        }
        public DbSet<User> User { get; set; }
        public DbSet<Book> Book { get; set; }
        public DbSet<Order> Order { get; set; }


        //On the package manager console.//

        //  add-migration migration-name
        //update-database




    }
}
