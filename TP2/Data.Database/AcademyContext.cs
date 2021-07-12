using Business.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Database
{
class AcademyContext: DbContext
{
    public DbSet<Usuario>? Usuarios { get; set; }
    public DbSet<Especialidad>? Especialidades { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=academia;Trusted_Connection=True;MultipleActiveResultSets=true");
    }
}
}
