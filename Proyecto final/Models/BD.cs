using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;


namespace Proyecto_final.Models
{
    public static class BD
    {

        private static string _connectionString = "Server=localhost;Database=Casas GRUPO 5;Trusted_Connection=True;";

        public static string ConnectionString
        {
            get
            {
                return _connectionString;
            }
        }

        private static SqlConnection Conectar()
        {
            SqlConnection conn = new SqlConnection(_connectionString);
            conn.Open();
            return conn;
        }

        public static void Desconectar(SqlConnection conn)
        {
            conn.Close();
        }

        public static List<Inmueble> ObtenerTodosInmuebles()
        {
            List<Inmueble> lista = new List<Inmueble>();
            SqlConnection conn = Conectar();
            SqlCommand consulta = conn.CreateCommand();
            consulta.CommandText = "SELECT precio, id, barrio, superficie, ambientes, patio, terraza, idTipo, idAgente, reservado, direccion, baños, habitaciones from Inmueble";
            consulta.CommandType = System.Data.CommandType.Text;
            SqlDataReader dr = consulta.ExecuteReader();
            while (dr.Read())
            {
                int precio= Convert.ToInt32(dr["precio"]);
                int id = Convert.ToInt32(dr["id"]);
                string barrio = (dr["barrio"]).ToString();
                int superficie = Convert.ToInt32(dr["superficie"]);
                int ambientes = Convert.ToInt32(dr["ambientes"]);
                bool patio = Convert.ToBoolean(dr["patio"]);
                bool terraza = Convert.ToBoolean(dr["terraza"]);
                string idTipo = (dr["idTipo"]).ToString();
                int idAgente = Convert.ToInt32(dr["idAgente"]);
                bool reservado = Convert.ToBoolean(dr["reservado"]);
                string direccion = (dr["direccion"]).ToString();
                int baños = Convert.ToInt32(dr["baños"]);
                int habitaciones = Convert.ToInt32(dr["habitaciones"]);

                Inmueble inmb = new Inmueble(precio, id, barrio, superficie, ambientes, patio, terraza, idTipo, idAgente, reservado, direccion, baños, habitaciones);

                lista.Add(inmb);
            }
            Desconectar(conn);
            return lista;
        }
        public static Usuario LogIn(Usuario miUsuario)
        {
            SqlConnection conn = Conectar();
            Usuario unUsuario = null;
            SqlCommand consulta = conn.CreateCommand();
            consulta.CommandText = "sp_LogIn";
            consulta.CommandType = System.Data.CommandType.StoredProcedure;
            consulta.Parameters.AddWithValue("@usu", miUsuario.NombreDeUsuario);
            consulta.Parameters.AddWithValue("@pass", miUsuario.Contraseña);
            SqlDataReader dr = consulta.ExecuteReader();
            if (dr.Read())
            { 
                int id = Convert.ToInt32(dr["id"]);
                string nombreDeUsuario = (dr["nombreDeUsuario"]).ToString();
                string nombre = (dr["nombre"]).ToString();
                string apellido = (dr["apellido"]).ToString();
                string contraseña = (dr["contraseña"]).ToString();

               unUsuario = new Usuario(id, nombreDeUsuario, nombre, apellido ,contraseña);
            }
            
            Desconectar(conn);
            return unUsuario;
        }
    }
}