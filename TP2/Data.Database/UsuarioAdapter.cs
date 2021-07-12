using Business.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
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
            var usr = new Usuario();

            string connString = ConfigurationManager.ConnectionStrings["ConnStringLocal"].ConnectionString;
            var sqlConnection = new SqlConnection(connString);
            sqlConnection.Open();
            var cmdGetOneUser = new SqlCommand("select * from Usuarios as U where U.id = @id", sqlConnection);
            cmdGetOneUser.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;
            SqlDataReader drGetOne = cmdGetOneUser.ExecuteReader();
            if (drGetOne.Read())
            {
                usr.ID = (int)drGetOne["ID"];
                usr.Nombre = (string)drGetOne["NombreUsuario"];
                usr.Clave = (string)drGetOne["Clave"];
                usr.Habilitado = (bool)drGetOne["Habilitado"];
                usr.Nombre = (string)drGetOne["Nombre"];
                usr.Apellido = (string)drGetOne["Apellido"];
                usr.Email = (string)drGetOne["Email"];
            }
            drGetOne.Close();
            sqlConnection.Close();

            return usr;
        } 
    }
}
