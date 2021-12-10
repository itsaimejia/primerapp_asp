using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PrimerApp.Models;

namespace PrimerApp.Data
{
    public class AplicationDBContext : DbContext
    {
        public AplicationDBContext (DbContextOptions<AplicationDBContext> options)
            : base(options)
        {
        }

        public DbSet<PrimerApp.Models.Categoria> Categoria { get; set; }
    }
}
