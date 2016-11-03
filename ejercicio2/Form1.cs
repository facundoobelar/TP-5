using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string iOpcionSeleccionada = "";
            if(radioButton1.Checked==true) 
            {
                iOpcionSeleccionada = "Radio button 1 seleccionado";
            }
            else if(radioButton2.Checked==true)
            {
                iOpcionSeleccionada = "Radio button 2 seleccionado";
            }
            else if(radioButton3.Checked==true)
            {
                iOpcionSeleccionada = "Radio button 3 seleccionado";
            }
            
            if (checkBox1.Checked)
            {
                iOpcionSeleccionada = iOpcionSeleccionada + " check 1 seleccionado";
            }
            if(checkBox2.Checked)
            {
                iOpcionSeleccionada = iOpcionSeleccionada+ " check 2 seleccionado";
            }
            if(iOpcionSeleccionada == "")
            {
                iOpcionSeleccionada = "NO HAY OPCION SELECCIONADA";
            }
            MessageBox.Show(iOpcionSeleccionada);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
