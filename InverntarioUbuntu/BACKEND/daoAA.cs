using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace InverntarioUbuntu.BACKEND
{
    internal class daoAA
    {

        public DataTable obtener(string parametros)
        {
            MySqlCommand consulta =
                new MySqlCommand(@"SELECT * FROM " + parametros + ";");

            Conexion C = new Conexion();
            return C.ejecutarConsulta(consulta);

        }
        public bool insertar(string N, string U)
        {
            MySqlCommand sentencia =
                new MySqlCommand(@"INSERT INTO Areas values(default,'" + N + "','" + U + "');");
            Conexion Conexion = new Conexion();
            return Conexion.ejecutarSentencia(sentencia);
        }

        public bool editar(string N, string U)
        {
            MySqlCommand sentencia =
                new MySqlCommand(@"INSERT INTO Areas values(default,'" + N + "','" + U + "');");
            Conexion Conexion = new Conexion();
            return Conexion.ejecutarSentencia(sentencia);
        }

        public bool eliminar()
        {
            return false;
            
        }


    }

}

