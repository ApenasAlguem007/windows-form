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

                                                        //  configuração inicial do List view para exibição dos dados dos clientes
            lstCliente.View = View.Details;             // Define a visualização ou detalhes
            lstCliente.LabelEdit = true;                // permite editar os titulos das colunas
            lstCliente.AllowColumnReorder = true;       // Permite reordenar as colunas
        
            lstCliente.FullRowSelect = true;         // Seleciona a linha inteira ao clicar
            lstCliente.GridLines = true;            // Exibe as linhas de grade no View


            // Definindo as Colunas mo ListView

            lstCliente.Columns.Add("Codigo", 100, HorizontalAlignment.Left);        // Coluna de Código
            lstCliente.Columns.Add("Nome Completo", 200, HorizontalAlignment.Left);  // coluna do Nome Completo
            lstCliente.Columns.Add("Nome Social", 200, HorizontalAlignment.Left);   // coluna do Nome Social
            lstCliente.Columns.Add("E-mail", 200, HorizontalAlignment.Left);        // Coluna de email
            lstCliente.Columns.Add("CPF", 000, HorizontalAlignment.Left);           // Coluna de CPF


            // carrega os dados dos clientes na interface/tela
            
            carregar_cliente();


        }


        private void carregar_clietes_com_query(string query)
        {
            try {
            
                // cria a conexão com o banco de dados
                Conexao = new MySqlConnection(data_source);
                Conexao.Open();

                // executa a consulta SQL fornecida
                MySqlCommand cmd = new MySqlCommand(query, Conexao);

                // Se a consulta contém o parametro @q, adiciona o valor da caixa de pesquisa
                if(query.Contains("@q"))
                {
                    cmd.Parameters.AddWithValue("@q", "%" + txtBuscar.Text + "%");
                }
                        
                // Executa o comando e obtém os resultados
                MySqlDataReader reader = cmd.ExecuteReader();

                // Limpa os itens existentes no ListView antes de adicionar novos
                lstCliente.Items.Clear();

                // Preencha o ListView com os dados do Cliente que foi buscado
                while (reader.Read())
                {
                    // cria uma linha para cada cliente com os dados retornados da consulta
                    string[] row =
                    {
                        Convert.ToString(reader.GetInt32(0)),   //codigo
                        reader.GetString(1),                    // Nome Completo
                        reader.GetString(2),                    // Nome Social
                        reader.GetString(3),                    // E-mail
                        reader.GetString(4),                    // CPF
                    };

                    // Adiciona a Linha ao ListView

                    lstCliente.Items.Add(new ListViewItem(row));

                }
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


        // Metodo para recarregar ( organizar ) todos os clientes no ListView (usando uma consulta sem parametro)

        private void carregar_cliente()
        {
            string query = "SELECT * FROM dadosdocliente ORDER BY idcliente DESC";
            carregar_clietes_com_query(query);
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


                // Limpa os campos após sucesso 
                txtNomeCompleto.Text = String.Empty;
                txtNomeSocial.Text = " ";
                txtEmail.Text = " ";
                txtCPF.Text = " ";

                // Regarrega os clientes no ListView
                carregar_cliente();

                // Muda para a aba  de Pesquisa
                tbControl.SelectedIndex = 1;


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

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM dadosdocliente WHERE nomecompleto LIKE @q OR nomesocial LIKE @q ORDER BY idcliente DESC";
            carregar_clietes_com_query(query);
                
        }
    }
}
