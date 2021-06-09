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
        public static void SeedData()
        {
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

            using (var db = new AcademyContext())
            {
                db.AddRange(usuarios);
                db.SaveChanges();
            }
        }
    }
}
