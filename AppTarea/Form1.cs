using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppTarea
{
    public partial class Form1 : Form
    {
        Lista milista;
        Nodo n = new Nodo();
        public Form1()
        {
            InitializeComponent();
            milista = new Lista();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Nodo n = new Nodo();
            milista.Agregar(n);
            n.Dato = txtDato.Text;
            MessageBox.Show(milista.ToString());
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            milista.Borrar(txtDato.Text);
            MessageBox.Show(milista.ToString());
            //if (milista.Buscar(txtDato.Text()))
            //{

            //}
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}
