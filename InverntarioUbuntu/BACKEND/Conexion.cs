using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace InverntarioUbuntu.BACKEND
{
    class Conexion
    {
        static MySqlConnection conexion = new MySqlConnection();
        public  bool conectar(MySqlConnection conexion)
        {
            conexion.ConnectionString = "server=localHost;database=ubuntudb;" +
                   "uid=root;password=SQLden18*";

            // Comando para conetar a Ubuntu

            //conexion.ConnectionString = "server=192.168.137.100;database=ubuntuDB;" +
            //    "uid=userWindows;pwd=1234";
            try
                {
                conexion.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                return false;
            }
        }
        public void desconectar()
        {
            if (conexion != null && conexion.State == ConnectionState.Open)
                conexion.Close();
        }
        public DataTable ejecutarConsulta(MySqlCommand consulta)
        {
            if (conectar(            //Comando para conectarse Local

            conexion))
            {
                try
                {
                    consulta.Connection = conexion;
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta);
                    DataTable resultado = new DataTable();
                    adaptador.Fill(resultado);
                    return resultado;
                }
                catch (MySqlException ex)
                {
                    return null;
                }
                finally
                {
                    desconectar();
                }
            }
            else
            {
                return null;
            }
        }
        public bool ejecutarSentencia(MySqlCommand sentencia)
        {
            if (conectar(            //Comando para conectarse Local

            conexion))
            {
                try
                {
                    sentencia.Connection = conexion;
                    sentencia.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    return false;
                }
                finally
                {
                    desconectar();
                }
            }
            else
            {
                return false;
            }
            return true;
        }

    }
}
