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
                new MySqlCommand(@"INSERT INTO Areas values(default,'" + N + "','" + U + "');");
            Conexion Conexion = new Conexion();
            return Conexion.ejecutarSentencia(sentencia);
        }

    }
}
