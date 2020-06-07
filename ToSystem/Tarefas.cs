using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToSystem
{
    public partial class FrmTarefas : Form
    {
        public FrmTarefas()
        {
            InitializeComponent();
        }

        private void boxTarefa_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            
            if (txtTarefa.Text == "")
            {
                MessageBox.Show("Campo vazio! Preencha antes de adicionar");
            }
            else
            {
                boxTarefas.Items.Add(txtTarefa.Text);
                txtTarefa.Clear();
                txtTarefa.Focus();
            }


        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            boxTarefas.Items.RemoveAt(txtTarefa.TextLength);
        }

        private void date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            FrmHome frmHome = new FrmHome();
            this.Hide();
            frmHome.ShowDialog();
        }

        private void btnTarefas_Click(object sender, EventArgs e)
        {
            FrmTarefas frmTarefas = new FrmTarefas();
            frmTarefas.ShowDialog();
            this.Close();
        }

        private void btnCalendario_Click(object sender, EventArgs e)
        {
            FrmCalendario frmCalendario = new FrmCalendario();
            this.Hide();
            frmCalendario.ShowDialog();

        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmToSystem frmToSystem = new FrmToSystem();
            this.Hide();
            frmToSystem.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            boxTarefas.Text = DateTime.Now.ToLongDateString();
        }

        private void btnRemoverTudo_Click(object sender, EventArgs e)
        {
            boxTarefas.Items.Clear();
        }
    }
}
