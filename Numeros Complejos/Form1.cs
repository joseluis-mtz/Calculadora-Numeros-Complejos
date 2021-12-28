using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

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

        private void tbnPow_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtReal.Text.Length > 0 && txtImg.Text.Length > 0 && txtN.Text.Length > 0)
                {
                    double ptReal = double.Parse(txtReal.Text);
                    double ptImg = double.Parse(txtImg.Text);
                    int potencia = int.Parse(txtN.Text);
                    Complex num1 = new Complex(ptReal, ptImg);
                    Complex resultado = Complex.Pow(num1, potencia);
                    lblResPow.Text = "Resultado: " + resultado.Real.ToString("0.####") + ", " + resultado.Imaginary.ToString("0.####") + "i";
                }
                else
                {
                    MessageBox.Show("Completa los campos primero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (VerificaOp())
                {
                    double nuRe1 = double.Parse(txtRe1.Text);
                    double nuRe2 = double.Parse(txtRe2.Text);
                    double nuImg1 = double.Parse(txtIm1.Text);
                    double nuImg2 = double.Parse(txtIm2.Text);
                    Complex num1 = new Complex(nuRe1, nuImg1);
                    Complex num2 = new Complex(nuRe2, nuImg2);
                    Complex resultado = Complex.Add(num1, num2);
                    lblResOp.Text = "Resultado: " + resultado.Real.ToString("0.####") + ", " + resultado.Imaginary.ToString("0.####") + "i";
                }
            }
            catch (Exception)
            {

            }
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            try
            {
                if (VerificaOp())
                {
                    double nuRe1 = double.Parse(txtRe1.Text);
                    double nuRe2 = double.Parse(txtRe2.Text);
                    double nuImg1 = double.Parse(txtIm1.Text);
                    double nuImg2 = double.Parse(txtIm2.Text);
                    Complex num1 = new Complex(nuRe1, nuImg1);
                    Complex num2 = new Complex(nuRe2, nuImg2);
                    Complex resultado = Complex.Subtract(num1, num2);
                    lblResOp.Text = "Resultado: " + resultado.Real.ToString("0.####") + ", " + resultado.Imaginary.ToString("0.####") + "i";
                }
            }
            catch (Exception)
            {

            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            try
            {
                if (VerificaOp())
                {
                    double nuRe1 = double.Parse(txtRe1.Text);
                    double nuRe2 = double.Parse(txtRe2.Text);
                    double nuImg1 = double.Parse(txtIm1.Text);
                    double nuImg2 = double.Parse(txtIm2.Text);
                    Complex num1 = new Complex(nuRe1, nuImg1);
                    Complex num2 = new Complex(nuRe2, nuImg2);
                    Complex resultado = Complex.Multiply(num1, num2);
                    lblResOp.Text = "Resultado: " + resultado.Real.ToString("0.####") + ", " + resultado.Imaginary.ToString("0.####") + "i";
                }
            }
            catch (Exception)
            {

            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            try
            {
                if (VerificaOp())
                {
                    double nuRe1 = double.Parse(txtRe1.Text);
                    double nuRe2 = double.Parse(txtRe2.Text);
                    double nuImg1 = double.Parse(txtIm1.Text);
                    double nuImg2 = double.Parse(txtIm2.Text);
                    Complex num1 = new Complex(nuRe1, nuImg1);
                    Complex num2 = new Complex(nuRe2, nuImg2);
                    Complex resultado = Complex.Divide(num1, num2);
                    lblResOp.Text = "Resultado: " + resultado.Real.ToString("0.####") + ", " + resultado.Imaginary.ToString("0.####") + "i";
                }
            }
            catch (Exception)
            {

            }
        }

        private void txtReal_KeyPress(object sender, KeyPressEventArgs e)
        {
            Libreria_validacion.Validar.SoloNumerosDecimales(e);
            Libreria_validacion.Validar.PresionarEnter(e);
        }

        private void txtImg_KeyPress(object sender, KeyPressEventArgs e)
        {
            Libreria_validacion.Validar.SoloNumerosDecimales(e);
            Libreria_validacion.Validar.PresionarEnter(e);
        }

        private void txtN_KeyPress(object sender, KeyPressEventArgs e)
        {
            Libreria_validacion.Validar.SoloNumeros(e);
            Libreria_validacion.Validar.PresionarEnterBoton(e, tbnPow);
        }

        private void txtRe1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Libreria_validacion.Validar.SoloNumerosDecimales(e);
            Libreria_validacion.Validar.PresionarEnter(e);
        }

        private void txtIm1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Libreria_validacion.Validar.SoloNumerosDecimales(e);
            Libreria_validacion.Validar.PresionarEnter(e);
        }

        private void txtRe2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Libreria_validacion.Validar.SoloNumerosDecimales(e);
            Libreria_validacion.Validar.PresionarEnter(e);
        }

        private void txtIm2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Libreria_validacion.Validar.SoloNumerosDecimales(e);
            Libreria_validacion.Validar.PresionarEnter(e);
        }
    }
}
