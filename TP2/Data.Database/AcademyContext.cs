using Business.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Database
{
    class AcademyContext: DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Especialidad> Especialidades { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options) => 
            options.UseSqlite(@"Data Source=C:\Users\aleja\OneDrive\Documentos\Net2021-GM02\TP2\academia.db");
    }
}
