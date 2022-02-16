using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InverntarioUbuntu.POJOS
{
    class Productos
    {
        private string nombre;
        private string descripcion;
        private string serie;
        private string color;
        private string fechaAdquisicion;
        private string tipoAdquisicion;
        private string observaciones;
        private int areasId;

        public Productos( string N, string D, string S, string C, string F, string T, string O, int A )
        {
            nombre = N;
            descripcion = D;
            serie = S;
            color = C;
            fechaAdquisicion = F;
            tipoAdquisicion = T;
            observaciones = O;
            areasId = A;
        }

        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Descripcion { get { return descripcion; } set { descripcion = value; } }
        public string Serie { get { return serie; } set { serie = value; } }
        public string Color { get { return color; } set { color = value; } }
        public string FechaAdquisicion { get { return fechaAdquisicion; } set { fechaAdquisicion = value; } }
        public string TipoAdquisicion { get { return tipoAdquisicion; } set { tipoAdquisicion = value; } }
        public string Observaciones { get { return observaciones; } set { observaciones = value; } }
        public int AreasId { get { return areasId; } set { areasId = value; } }

    }
}
