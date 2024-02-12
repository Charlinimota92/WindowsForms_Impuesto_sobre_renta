using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_Impuesto_sobre_renta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
           
            txt_Nombre_Empleado.Clear();
            txt_sueldo.Clear();
            txt_AFP.Clear();
            txt_SFS.Clear();
            txt_ISR.Clear();
            txt_status.Clear();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {

           
            string nombre = txt_Nombre_Empleado.Text;
            double sueldo = Convert.ToDouble(txt_sueldo.Text);

            // Calcular el impuesto sobre la renta (ISR) según la tabla de impuestos actual en tu país
            double isr = CalcularISR(sueldo);


            double afp = sueldo * 0.0287; // 2.87%
            double sfs = sueldo * 0.0304; // 3.04%

           
            txt_AFP.Text = afp.ToString("0.00");
            txt_SFS.Text = sfs.ToString("0.00");
            txt_ISR.Text = isr.ToString("0.00");

            // Determinar el estatus del ISR y mostrarlo en el cuadro de texto correspondiente
            if (isr == 0)
            {
                txt_status.Text = "n/a";
            }
            else
            {
                txt_status.Text = "apli";
            }
        }

        private double CalcularISR(double sueldo)
        {
            double isr = 0;
           
            isr = sueldo * 0.20;

            return isr;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
