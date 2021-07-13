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
        private readonly AcademyContext _context;
        private Adapter _adapter;
        public UsuarioAdapter(AcademyContext context)
        {
            _adapter = new Adapter();
            _context = context;
        }

        public List<Usuario> GetAll()
        {
            return _context.Usuarios?.ToList() ?? new List<Usuario>();
        }

        public Usuario GetOne(int id)
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
                usr.Nombre = drGetOne["NombreUsuario"].ToString();
                usr.Clave = drGetOne["Clave"].ToString();
                usr.Habilitado = (bool)drGetOne["Habilitado"];
                usr.Nombre = drGetOne["Nombre"].ToString();
                usr.Apellido = drGetOne["Apellido"].ToString();
                usr.Email = drGetOne["Email"].ToString();
            }
            drGetOne.Close();
            sqlConnection.Close();

            return usr;
        } 
    }
}
