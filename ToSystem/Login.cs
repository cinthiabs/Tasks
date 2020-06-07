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
    public partial class FrmToSystem : Form
    {
        public FrmToSystem()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
           if(txtUser.Text =="" && txtPassword.Text=="")
            {
                MessageBox.Show("Preencha todos os campos!");
            }

            SqlConnection banco = new SqlConnection("Data Source=DESKTOP-7VCU04E\\SQLEXPRESS;Initial Catalog=NOVO_BANCO;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("select * from login where LOGIN=@LOGIN AND SENHA=@SENHA", banco);

            sqlCommand.Parameters.Add("@LOGIN", SqlDbType.VarChar).Value = txtUser.Text;
            sqlCommand.Parameters.Add("@SENHA", SqlDbType.VarChar).Value = txtPassword.Text;

            try
            {
                banco.Open();
                SqlDataReader leia = sqlCommand.ExecuteReader();
                if(leia.HasRows == false)
                {
                    throw new Exception("Usuário ou senha Incorreta!");
                }
                else
                {
                    leia.Read();
                    FrmHome frmHome = new FrmHome();
                    this.Hide();
                    frmHome.ShowDialog();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                banco.Close();
            }
        }

        private void Cadastrese_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmNovoUsuário frmNovoUsuário = new FrmNovoUsuário();
            frmNovoUsuário.ShowDialog();
        }
    }
}
