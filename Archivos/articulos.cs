using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos
{
    class articulos
    {
        private string nombre;
        private double precio;

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }

        }

        public double Precio
        {
            get
            {
                return precio;
            }
            set
            {
                precio = value;
            }
        }

        public articulos()
        {
            this.nombre = "";
            this.Precio = 0;
        }
        public articulos(string nombre, double precio)
        {
            this.nombre = nombre;
            Precio = precio;
        }
        public override string ToString()
        {
            return nombre+""+ Precio+"";
        }
    }
}
