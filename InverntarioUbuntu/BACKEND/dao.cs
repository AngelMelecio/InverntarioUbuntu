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
        public DataTable obtenerInventario()
        {
            MySqlCommand consulta =
                new MySqlCommand(@"SELECT * FROM inventario;");

            Conexion C = new Conexion();
            return C.ejecutarConsulta(consulta);

        }
        public DataTable obtenerAreas()
        {
            MySqlCommand consulta =
                new MySqlCommand(@"SELECT * FROM areas;");

            Conexion C = new Conexion();
            return C.ejecutarConsulta(consulta);

        }
    }
}
