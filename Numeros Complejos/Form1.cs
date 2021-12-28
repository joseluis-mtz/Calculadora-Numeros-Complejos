using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numeros_Complejos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public bool VerificaOp()
        {
            if (txtRe1.Text.Length > 0 && txtRe2.Text.Length > 0 && txtIm1.Text.Length > 0 && txtIm2.Text.Length > 0)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Completa los campos primero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
