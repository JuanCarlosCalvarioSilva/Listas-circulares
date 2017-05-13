using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas_Circulares
{
    class Base
    {
        private string _nombre;
        public string nombre
        {
            set { _nombre = value; }
            get { return _nombre; }
        }

        private int _minutos;
        public int minutos
        {
            set { _minutos = value; }
            get { return _minutos; }
        }

        private Base _siguiente;
        public Base siguiente
        {
            set { _siguiente = value; }
            get { return _siguiente; }
        }

        private Base _anterior;
        public Base anterior
        {
            set { _anterior = value; }
            get { return _anterior; }
        }

        public override string ToString()
        {
            return "Nombre: " + _nombre.ToString() + " |  Minutos: " + _minutos.ToString();
        }
    }
}
