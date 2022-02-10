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
        public DataTable obtenerTodos()
        {
            MySqlCommand consulta =
                new MySqlCommand(@"SELECT * FROM Alumnos;");
            Conexion C = new Conexion();
            return C.ejecutarConsulta(consulta);

        }
    }
}
