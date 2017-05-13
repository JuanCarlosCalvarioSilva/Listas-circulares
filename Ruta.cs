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

        public void agregarFinal(Base nuevo)
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

        public void insertarDespuesDe(Base nuevo,string nombre)
        {
            Base anteriorPadre, actual;
            actual = inicio;
            anteriorPadre = null;            

            do
            {
                if (actual.nombre == nombre)
                {
                    nuevo.anterior = anteriorPadre;
                    anteriorPadre.siguiente.anterior = nuevo;
                    anteriorPadre.siguiente = nuevo;
                    nuevo.siguiente = actual;
                }
                anteriorPadre = actual;
                actual = actual.siguiente;
            }
            while (actual.siguiente != inicio);
        }

        public Base buscar(string nombre)
        {
            Base actual = inicio;
            while (actual.siguiente != inicio)
            {
                if (actual.nombre == nombre)
                    return actual;
                actual = actual.siguiente;
            }
            if (inicio.anterior.nombre == nombre)
                return inicio.anterior;
            return null;
        }

        public void eliminar(string nombre)
        {
            if (inicio != null)
            {
                Base actual, anterior;
                anterior = buscarAnteriorPadre(nombre);

                if (anterior == null)
                {
                    actual = inicio;
                    inicio = inicio.siguiente;
                    anterior = inicio;
                }
                else
                {
                    actual = anterior.siguiente;
                    actual.siguiente.anterior = actual.anterior;
                    anterior.siguiente = actual.siguiente;
                }
                actual = null;                
            }
        }

        private Base buscarAnteriorPadre(string nombre)
        {
            Base anteriorPadre, actual;
            actual = inicio;
            anteriorPadre = null;

            while (actual.siguiente != inicio)
            {
                if (actual.nombre == nombre)
                    break;
                anteriorPadre = actual;
                actual = actual.siguiente;
            }
            return anteriorPadre;
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
                while (actual.siguiente != inicio)
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
