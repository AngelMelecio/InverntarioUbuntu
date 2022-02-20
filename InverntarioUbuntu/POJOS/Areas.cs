using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InverntarioUbuntu.POJOS
{
    public class Areas
    {
        private int id;
        private string nombre;
        private string ubicacion;

        public int Id { get { return id; }set { id = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Ubicacion { get { return ubicacion; } set { ubicacion = value; } }
    }
}
