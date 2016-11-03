using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio6
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void acreditarSaldo_Click(object sender, EventArgs e)
        {
            TipoDeCuenta frm = new TipoDeCuenta();
            frm.ShowDialog();            
        }
        private void consultarSaldo_Click(object sender, EventArgs e)
        {
            TipoDeCuenta frm = new TipoDeCuenta();
            frm.ShowDialog();            
        }       
        private void debitar_Click(object sender, EventArgs e)
        {
            TipoDeCuenta frm = new TipoDeCuenta();
            frm.ShowDialog();
            
        }        
    }
}
