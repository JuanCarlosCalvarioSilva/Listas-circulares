using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas_Circulares
{
    class Ruta
    {
        Base inicio;

        public void agregar(Base nuevo)
        {
            if (inicio == null)
                inicio = nuevo;
            else
            {
                Base temp = inicio;
                while (temp.siguiente != inicio)
                {
                    temp = temp.siguiente;
                }
                nuevo.anterior = temp;
                temp.siguiente = nuevo;
            }
            nuevo.siguiente = inicio;
            inicio.anterior = nuevo;
        }

        //public void eliminar(string nombre)
        //{

        //}

        public void agregarInicio(Base nuevo)
        {
            if (inicio == null)
            {
                inicio = nuevo;
            }
            else
            {
                nuevo.anterior = inicio.anterior;
                inicio.anterior.siguiente = nuevo;
                inicio.anterior = nuevo;
                nuevo.siguiente = inicio;
                inicio = nuevo;
            }
        }

        public void eliminarPrimero()
        {
            if (inicio != null)
            {
                inicio.anterior.siguiente = inicio.siguiente;
                inicio.siguiente.anterior = inicio.anterior;
                inicio = inicio.siguiente;
            }
        }
        public void eliminarUltimo()
        {
            if (inicio != null)
            {
                inicio.anterior.anterior.siguiente = inicio;
                inicio.anterior = inicio.anterior.anterior;
            }
        }

        public string reporte()
        {
            string cad = "";

            if (inicio != null)
            {
                Base actual = inicio;
                while (actual != null && actual.siguiente != inicio)
                {
                    cad += actual.ToString() + Environment.NewLine;
                    actual = actual.siguiente;
                }
                cad += inicio.anterior.ToString() + Environment.NewLine;
            }

            return cad;
        }
    }
}
