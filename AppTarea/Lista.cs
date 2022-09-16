using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTarea
{
    internal class Lista
    {
        private Nodo head;
        public Nodo Head
        {
            get { return head; }
            set { head = value; }
        }
        //public Lista()
        //{
        //    string milista;
        //}
        public void Agregar(Nodo n)
        {
            Nodo h = head;
            if (h == null)
            {
                h = n;
                return;
            }
            if (string.Compare(n.Dato, head.Dato) < 0)
            {
                n.Siguiente = head;
                head = n;
                return;
            }
            n.Siguiente = head;
            h.Siguiente = n;
            //while  (mientras) no se sabe cuantos datos se van a ejecutar
            //do while  
            //for cuando se conoce el numero de cosas
            //for each cuando se conoce el numero de objetos 
        }
        public void Borrar(String d)
        {
            if (d == head.Dato)
            {
                head = head.Siguiente;
                return;
            }
            Nodo h = head;
            while (h.Siguiente != null)
            {
                if (string.Compare (d, h.Siguiente.Dato)<=0)
                {
                    break;
                }
                h = h.Siguiente;
            }
            //if (d==h.Siguiente.Dato()<=0)
            //{
            //    break;
            //}
            //h = h.Siguiente;
        }
        //public  bool Buscar(string d)
        //{
        //    Nodo h = head;
        //    if (h.Siguiente !=null && head.Dato)
        //    {
        //        return true;
        //    }
        //    return false;
        //}
        public override string ToString()
        {
            //Nodo h = head;
            Nodo n = new Nodo();
            //string milista;
            ////string Dato = "";
            ////h = h.Siguiente;
            //while (milista != null)
            //{
            //    n.Dato += h.ToString();
            //}
            return n.Dato.ToString();
        }
    }
}
