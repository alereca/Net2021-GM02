using Business.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Database
{
    public class Seed
    {
        /// <summary>
        /// Recrear Db y agregar datos semilla a usar en la fase de desarrollo
        /// </summary>
        public static void SeedData(AcademyContext context)
        {

            context.Database.EnsureDeleted();
            context.Database.Migrate();

            var usuarios = new List<Usuario>()
            {
                new()
                {
                    Nombre = "Ale"
                },
                new()
                {
                    Nombre = "Juan"
                }
            };

            context.AddRange(usuarios);
            context.SaveChanges();
        }
    }
}
