using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class frm1 : Form
    {
        public frm1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            int valor1, valor2,resultado;

            
            string tmpVerificarValor1 = txtNumeroUm.Text;
            string tmpVerificarValor2 = txtNumeroDois.Text;
      
            if (tmpVerificarValor1 == "")
            {
                lblResultado.Text = "Favor colocar um número no campo de texto.";
            }

            if (tmpVerificarValor2 == "")
            {
                lblResultado.Text = "Favor colocar um número no campo de texto.";
            }

            else { 
             valor1 = Convert.ToInt32(txtNumeroUm.Text);
            valor2 = Convert.ToInt32(txtNumeroDois.Text);

            resultado = valor1 + valor2;
           

            lblResultado.Text = resultado.ToString();
            }


           
           

        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            int valor1, valor2, resultado;

            string tmpVerificarValor1 = txtNumeroUm.Text;
            string tmpVerificarValor2 = txtNumeroDois.Text;

            if (tmpVerificarValor1 == "")
            {
                lblResultado.Text = "Favor colocar um número no campo de texto.";
            }

            if (tmpVerificarValor2 == "")
            {
                lblResultado.Text = "Favor colocar um número no campo de texto.";
            }
            else { 
            
            valor1 = Convert.ToInt32(txtNumeroUm.Text);
            valor2 = Convert.ToInt32(txtNumeroDois.Text);

            resultado = valor1 - valor2;
            
            lblResultado.Text = resultado.ToString();
            }
            
        }

        private void Dividir_Click(object sender, EventArgs e)
        {
            int valor1, valor2, resultado;

            string tmpVerificarValor1 = txtNumeroUm.Text;
            string tmpVerificarValor2 = txtNumeroDois.Text;

            if (tmpVerificarValor1 == "")
            {
                lblResultado.Text = "Favor colocar um número no campo de texto.";
            }

            if (tmpVerificarValor2 == "")
            {
                lblResultado.Text = "Favor colocar um número no campo de texto.";
            }

            else { 
            valor1 = Convert.ToInt32(txtNumeroUm.Text);
            valor2 = Convert.ToInt32(txtNumeroDois.Text);

            resultado = valor1 / valor2;
           
            lblResultado.Text = resultado.ToString();
            }
            
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            int valor1, valor2, resultado;
            string tmpVerificarValor1 = txtNumeroUm.Text;
            string tmpVerificarValor2 = txtNumeroDois.Text;

            if (tmpVerificarValor1 == "")
            {
                lblResultado.Text = "Favor colocar um número no campo de texto.";
            }

            if (tmpVerificarValor2 == "")
            {
                lblResultado.Text = "Favor colocar um número no campo de texto.";
            }
            else { 
            
            valor1 = Convert.ToInt32(txtNumeroUm.Text);
            valor2 = Convert.ToInt32(txtNumeroDois.Text);

            resultado = valor1 * valor2;
          
            lblResultado.Text = resultado.ToString();
            }
            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtNumeroUm_Leave(object sender, EventArgs e)
        {
          string teste=  txtNumeroUm.Text;
            if (teste.Contains("a"))
            {
                lblResultado.Text = "Aceita-se apenas números";
                txtNumeroUm.Clear();
            }
        }
    }
}
