using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    public class UsuarioLogic
    {
        private readonly UsuarioAdapter _usuarioData;
        public UsuarioLogic()
        {
            _usuarioData =  new UsuarioAdapter();
        }
        public List<Usuario> GetAll()
        {
            return _usuarioData.GetAll();
        }

        public Usuario GetOne(int id)
        {
            return _usuarioData.GetOne(id);
        }
    }
}
