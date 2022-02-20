using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace InverntarioUbuntu.BACKEND
{
    class dao
    {
        public DataTable obtener( string parametros )
        {
            MySqlCommand consulta =
                new MySqlCommand(@"SELECT * FROM "+ parametros +";");

            Conexion C = new Conexion();
            return C.ejecutarConsulta(consulta);

        }
        public bool insertar( string N, string D, string S, string C, string F, string T, string O, int A)
        {
            MySqlCommand sentencia =
                new MySqlCommand(@"INSERT INTO Inventario values(" +
               "default,'" + N + "','" + D + "','" + S + "','" + C + "','" + F + "','" + T + "','" + O + "'," + A + ");");
            Conexion Conexion = new Conexion();
            return Conexion.ejecutarSentencia(sentencia);
        }
        public bool eliminar(string tabla, int id)
        {
            MySqlCommand sentencia = new MySqlCommand(@"DELETE FROM " 
                    + tabla + " Where id = " + id.ToString() + " ;");
            Conexion Conexion = new Conexion();
            return Conexion.ejecutarSentencia(sentencia);
        }
        public bool insertar(string N, string U)
        {
            MySqlCommand sentencia =
                new MySqlCommand(@"INSERT INTO AREAS values(default,'" + N + "','" + U + "');");
            Conexion Conexion = new Conexion();
            return Conexion.ejecutarSentencia(sentencia);
        }
        public bool editar( int I, string N, string D, string S, string C, string F, string T, string O, int A)
        {
            MySqlCommand sentencia =
               new MySqlCommand(@"Update Inventario " +
                    "SET NombreCorto = '" + N + "', " +
                    "Descripcion = '" + D + "', " +
                    "Serie = '" + S + "', " +
                    "Color = '" + C + "', " +
                    "FechaAdquisicion = '" + F + "', " +
                    "TipoAdquisicion = '" + T + "', " +
                    "Observaciones = '" + O + "', " +
                    "AREAS_id = " + A +
                    " Where id = " + I + ";");
            Conexion Conexion = new Conexion();
            return Conexion.ejecutarSentencia(sentencia);
        }
        public bool editar(int I, string N, string U)
        {
            MySqlCommand sentencia =
               new MySqlCommand(@"Update AREAS " +
                    "SET Nombre = '" + N + "', " +
                    "ubicacion = '" + U + "' " +
                    " Where id = " + I + ";");
            Conexion Conexion = new Conexion();
            return Conexion.ejecutarSentencia(sentencia);
        }
    }
}
