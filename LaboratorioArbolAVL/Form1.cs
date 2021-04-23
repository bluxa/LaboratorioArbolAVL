using LaboratorioArbolAVL.ArbolAVL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaboratorioArbolAVL
{
    public partial class Form1 : Form
    {
        ArbolAvl miArbolAvl = new ArbolAvl();
        public ClsProyecto[] miProyectoTxt;

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
            cargarProyectosTxt(ref miProyectoTxt);
            agregarProyectoTxt(ref miProyectoTxt, Convert.ToInt32(txtPrioridad.Text), cmbDepto.Text, txtNombre.Text, Convert.ToDouble(txtMonto.Text));
        }


        private void button2_Click(object sender, EventArgs e)
        {
            ClsProyecto objProyecto = new ClsProyecto(0,"",txtNombre.Text,0);
            ClsProyecto objEncontrado = (ClsProyecto)miArbolAvl.buscar(objProyecto).valorNodo();

            MessageBox.Show(objEncontrado.ToString());
        }

        public static void cargarProyectosTxt(ref ClsProyecto[] miProyectoTxt)
        {
            StreamReader reader = new StreamReader("Proyecto.txt");

            int size = Convert.ToInt32(reader.ReadLine());
            miProyectoTxt = new ClsProyecto[size];

            for (int index = 0; index < miProyectoTxt.Length; index++)
            {
                miProyectoTxt[index] = new ClsProyecto();
                miProyectoTxt[index].prioridad = int.Parse(reader.ReadLine());
                miProyectoTxt[index].depto = reader.ReadLine();
                miProyectoTxt[index].nombre = reader.ReadLine();
                miProyectoTxt[index].monto = Convert.ToDouble(reader.ReadLine()); 

            }
            reader.Close();
        }

        public static void agregarProyectoTxt(ref ClsProyecto[] miProyectoTxt, int prioridad, string depto, string nombre,
            double monto)
        {
            StreamWriter writer = new StreamWriter("Proyecto.txt");
            writer.WriteLine(miProyectoTxt.Length + 1);

            ClsProyecto temp = new ClsProyecto();

            //Lee el documento y vuelve a escribir los datos que ya estaban 
            for (int index = 0; index < miProyectoTxt.Length; index++)
            {
                writer.WriteLine(miProyectoTxt[index].prioridad);
                writer.WriteLine(miProyectoTxt[index].depto);
                writer.WriteLine(miProyectoTxt[index].nombre);
                writer.WriteLine(miProyectoTxt[index].monto);
            }

            temp.prioridad = prioridad;
            temp.depto = depto;
            temp.nombre = nombre;
            temp.monto = monto;

            //Escribe los nuevos datos despues que ya haya insertado los anteriores 
            writer.WriteLine(temp.prioridad);
            writer.WriteLine(temp.depto);
            writer.WriteLine(temp.nombre);
            writer.WriteLine(temp.monto);

            writer.Close();
        }
    }
}
