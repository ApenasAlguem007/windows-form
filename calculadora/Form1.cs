using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form1 : Form
    {
        double Numero1 = 0, Numero2 = 0;
        char Operador;

        public Form1()
        {
            InitializeComponent();
        }

        private void acrescentarNumero(object sender, EventArgs e)
        {
            var botao = ((Button)sender);

            if (txtResultado.Text == "0")
                txtResultado.Text = "";

            txtResultado.Text += botao.Text; 
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {

        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            Numero2 = Convert.ToDouble(txtResultado.Text);

            if (Operador == '+')
            {
                txtResultado.Text =(Numero1 + Numero2).ToString();
                Numero1 = Convert.ToDouble(txtResultado.Text);
            }
            else if (Operador == '-')
            {
                txtResultado.Text = (Numero1 - Numero2).ToString();
                Numero1 = Convert.ToDouble(txtResultado.Text);
            }
            else if (Operador == 'x')
            {
                txtResultado.Text = (Numero1 * Numero2).ToString();
                Numero1 = Convert.ToDouble(txtResultado.Text);
            }
            else if (Operador == '/')
            {
                if(txtResultado.Text != "0")
                txtResultado.Text = (Numero1 / Numero2).ToString();
                Numero1 = Convert.ToDouble(txtResultado.Text);
            }
            else
            {
                MessageBox.Show("Não é possivel dividir por Zero(0).");
            }
        }

        private void btnErase_Click(object sender, EventArgs e)
        {
            {
                if (txtResultado.Text.Length > 1)
                {
                    txtResultado.Text = txtResultado.Text.Substring(0, txtResultado.Text.Length - 1);
                }
                else
                {
                    txtResultado.Text = "0";
                }
            }
        }

        private void btnApagarTudo_Click(object sender, EventArgs e)
        {
            Numero1 = 0;
            Numero2 = 0;
            Operador = '\0';
            txtResultado.Text = "0";
        }

        private void btnPonto_Click(object sender, EventArgs e)
        {
            if (!txtResultado.Text.Contains("."))
            {
                txtResultado.Text += ".";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "0";
        }

        private void btnSigno_Click(object sender, EventArgs e)
        {
            Numero1 = Convert.ToDouble(txtResultado.Text);
            Numero1 *= -1;
            txtResultado.Text = Numero1.ToString();
        }


        private void clickOperador(object sender, EventArgs e)
        {
            var botao = ((Button)sender);
            Numero1 = Convert.ToDouble(txtResultado.Text);
            Operador = Convert.ToChar(botao.Tag);

            txtResultado.Text = "0";

        }
    }
}

        