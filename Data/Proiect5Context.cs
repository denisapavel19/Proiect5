using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Proiect5.Models;

namespace Proiect5.Data
{
    public class Proiect5Context : DbContext
    {
        public Proiect5Context (DbContextOptions<Proiect5Context> options)
            : base(options)
        {
        }

        public DbSet<Proiect5.Models.Parinte> Parinte { get; set; } = default!;

        public DbSet<Proiect5.Models.Elev>? Elev { get; set; }
    }
}
