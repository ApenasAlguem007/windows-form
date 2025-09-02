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

                if (string.IsNullOrEmpty(txtNomeCompleto.Text.Trim()) ||
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

                // Cria conexão com o banco de dados
                Conexao = new MySqlConnection(data_source);
                Conexao.Open();


                // Comando SQL para inserir novo cliente no banco de dados
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = Conexao
                };

                cmd.Prepare();
                cmd.CommandText = "INSERT INTO dadosdocliente(nomecompleto, nomesocial, email, cpf) " + "VALUES (@nomecompleto, @nomesocial, @email, @cpf)";


                // Adiciona os parametros com os dados do formulario
                cmd.Parameters.AddWithValue("@nomecompleto", txtNomeCompleto.Text.Trim());
                cmd.Parameters.AddWithValue("@nomesocial", txtNomeSocial.Text.Trim());
                cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                cmd.Parameters.AddWithValue("@cpf", cpf);


                // executa o comando de inserção no banco
                cmd.ExecuteNonQuery();

                // Mensagem de sucesso
                MessageBox.Show("Contato inserido com Sucesso:",
                                    "Sucesso",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

            }
            catch (MySqlException ex)
            {

                //Trata erros relacionados ao MYSQl
                MessageBox.Show("Erro " + ex.Number + "ocorreu:" + ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }

            catch (Exception ex)
            {
                // Trata outros tipos de erros
                MessageBox.Show("Ocorreu:" + ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                // garante que a conexao com o banco será fechada, mesmo que ocorra um erro

                if (Conexao != null & Conexao.State == ConnectionState.Open) 
                { 
                    Conexao.Close();
                }
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

        private void frmCadastroDeClientes_Load(object sender, EventArgs e)
        {

        }
    }
}
