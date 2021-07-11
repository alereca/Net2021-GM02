using Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Database
{
    public class UsuarioAdapter
    {
        private Adapter _adapter;
        public UsuarioAdapter()
        {
            _adapter = new Adapter();
        }

        public List<Usuario> GetAll()
        {
            using (var db = new AcademyContext())
            {
                Microsoft.EntityFrameworkCore.DbSet<Usuario>? usuarios = db.Usuarios;
                if (usuarios == null) return new List<Usuario>();
                return usuarios.ToList();
            }
        }

        public Business.Entities.Usuario GetOne(int id)
        {
            _adapter.OpenConnection();

        }
    }
}
