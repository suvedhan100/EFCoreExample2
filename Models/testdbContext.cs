using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreExample2.Models
{
    public partial class testdbContext:DbContext
    {
        public testdbContext()
        {
        }

        public testdbContext(DbContextOptions<testdbContext> options)
            : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=testdb;Trusted_Connection=True;");
        }

        public virtual DbSet<Personsview> Personsview { get; set; }
    }
}
