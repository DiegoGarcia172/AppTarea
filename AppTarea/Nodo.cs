using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTarea
{
	internal class Nodo
	{
		private string dato;
		private Nodo siguiente;

		public Nodo Siguiente
		{
			get { return siguiente; }
			set { siguiente = value; }
		}

		public string Dato
		{
			get { return dato; }
			set { dato = value; }
		}
		public Nodo()
		{
			Dato = "";
			Siguiente = null;
		}
		public override string ToString()
		{
			return Dato.ToString();
		}
	}
}
