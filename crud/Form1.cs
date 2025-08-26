using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace crud
{
    public partial class frmCadastroDeClientes : Form
    {

        // Conexão com o banco de dados MySql
        MySqlConnection Conexao;
        string data_source = "datasource=localhost; username=root; password=; database=db_cadastro";

        public frmCadastroDeClientes()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validação de Campos Obrigatorios

                if(string.IsNullOrEmpty(txtNomeCompleto.Text.Trim()) ||
                    string.IsNullOrEmpty(txtEmail.Text.Trim()) ||
                    string.IsNullOrEmpty(txtCPF.Text.Trim()))
                {
                    MessageBox.Show("Todos os campos devem ser preenchidos.",
                        "Validação",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                        );
                    return; //impede o prosseguimento se algum campo estiver vazio
                }

                // validação de CPF

                string cpf = txtCPF.Text.Trim();

                if (!IsValidCPFLength(cpf))
                {
                    MessageBox.Show("CPF inválido Certifique-se de que o CPF tenha 11 digitos númericos.",
                        "Validação",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return; // Impede o prosseguimento se o CPF for válido
                }
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        // Função para válidar o comprimento e formato do CPF
        private bool IsValidCPFLength(string cpf)
        {

            //Remove todos os caracteres não numericos
            cpf = new string(cpf.Where(char.IsDigit).ToArray());

            // Verifica se o CPF tem exatamente 11 digitos
            return cpf.Length == 11;

        }
    }
}
