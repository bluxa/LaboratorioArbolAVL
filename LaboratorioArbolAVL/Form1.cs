using LaboratorioArbolAVL.ArbolAVL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaboratorioArbolAVL
{
    public partial class Form1 : Form
    {
        ArbolAvl miArbolAvl = new ArbolAvl();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClsProyecto miProyecto = new ClsProyecto();
            miProyecto.prioridad = Convert.ToInt32(txtPrioridad.Text);
            miProyecto.depto = cmbDepto.Text;
            miProyecto.nombre = txtNombre.Text;
            miProyecto.monto = Convert.ToDouble(txtMonto.Text);

            miArbolAvl.insertar(miProyecto);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClsProyecto objProyecto = new ClsProyecto(0,"",txtNombre.Text,0);
            ClsProyecto objEncontrado = (ClsProyecto)miArbolAvl.buscar(objProyecto).valorNodo();

            MessageBox.Show(objEncontrado.ToString());
        }
    }
}
