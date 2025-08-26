using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureBox
{
    public partial class PictureBox : Form
    {
        private string imagemLocalizada;
      

        public PictureBox()
        {
           
            InitializeComponent();
        }

        private void btnVerImagem_Click(object sender, EventArgs e)
        {
            pbCidade.Image = Image.FromFile(@"C:\Users\geovanna.psilva9\Downloads\Sampa.PNG");
            pbCidade.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnAnexar_Click(object sender, EventArgs e)
        {
            try
            {
                // caixa de dialogo para abrir o arquivo
                OpenFileDialog abrirarquivo = new OpenFileDialog();
                abrirarquivo.Filter = "jpg files (*.jpg)|*.jpg|PNG file(*.png)|*.png|All files (*.*)|*.*";

                if (abrirarquivo.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imagemLocalizada = abrirarquivo.FileName;
                    pbAnexarImagem.ImageLocation = imagemLocalizada;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}


