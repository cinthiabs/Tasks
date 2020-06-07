using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToSystem
{
    public partial class FrmNovoUsuário : Form
    {
        public FrmNovoUsuário()
        {
            InitializeComponent();
        }

         private void btnAdicionar_Click(object sender, EventArgs e)
        { 
            //craindo conexao com o banco de dados
            SqlConnection banco = new SqlConnection("Data Source=DESKTOP-7VCU04E\\SQLEXPRESS;Initial Catalog=NOVO_BANCO;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("insert into login(NOME, SOBRENOME, LOGIN, SEXO, SENHA)values(@NOME, @SOBRENOME, @LOGIN, @SEXO, @SENHA)",banco);

            sqlCommand.Parameters.Add("@SOBRENOME", SqlDbType.VarChar).Value = txtSobrenome.Text;
            sqlCommand.Parameters.Add("@NOME", SqlDbType.VarChar).Value = txtNome.Text;
            sqlCommand.Parameters.Add("@LOGIN", SqlDbType.VarChar).Value = txtLogin.Text;
            sqlCommand.Parameters.Add("@SEXO", SqlDbType.VarChar).Value = cbSexo.Text;
            sqlCommand.Parameters.Add("@SENHA", SqlDbType.VarChar).Value = txtSenha.Text;

            if(txtSobrenome.Text != "" && txtNome.Text != "" && txtLogin.Text != "" && txtSenha.Text != "" && cbSexo.Text != "")
            {
                try
                {
                    banco.Open();
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Cadastro Efetuado com Sucesso!" + MessageBoxButtons.OK);
                    txtSobrenome.Text = "";
                    txtNome.Text = "";
                    txtLogin.Text = "";
                    txtSenha.Text = "";
                    cbSexo.Text = "";
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally {
                    banco.Close();
                }
            }
            else
            {
                MessageBox.Show("Por favor Digite todos os Campos!");
                txtNome.Focus();
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
