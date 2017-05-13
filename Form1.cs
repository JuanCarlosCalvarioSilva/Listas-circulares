using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Listas_Circulares
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Ruta ruta = new Ruta();
        Base nuevaBase;

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Agrega producto
            nuevaBase = new Base();

            if (txtNombre.Text == "" || txtMinutos.Text == "")
                MessageBox.Show("Llenar todos los campos");
            else
            {
                nuevaBase.nombre = txtNombre.Text;
                nuevaBase.minutos = int.Parse(txtMinutos.Text);

                ruta.agregar(nuevaBase);

                txtNombre.Text = "";
                txtMinutos.Text = "";
            }
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            //Reporte
            txtReporte.Text = ruta.reporte();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarInicio_Click(object sender, EventArgs e)
        {
            //Agrega al inicio           
           nuevaBase = new Base();
            

            if (txtNombre.Text == "" || txtMinutos.Text == "")
                MessageBox.Show("Llenar todos los campos");
            else
            {              
                nuevaBase.nombre = txtNombre.Text;
                nuevaBase.minutos = int.Parse(txtMinutos.Text);

                ruta.agregarInicio(nuevaBase);
    
                txtNombre.Text = "";
                txtMinutos.Text = "";
            }
        }

        private void btnEliminarPrimero_Click(object sender, EventArgs e)
        {
            ruta.eliminarPrimero();
        }

        private void btnEliminarUltimo_Click(object sender, EventArgs e)
        {
            ruta.eliminarUltimo();
        }
    }
}
