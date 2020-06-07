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
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            FrmTarefas frmTarefas = new FrmTarefas();
            this.Hide();
            frmTarefas.ShowDialog();
 

        }

        private void btnTarefas_Click(object sender, EventArgs e)
        {
            FrmTarefas frmTarefas = new FrmTarefas();
            this.Hide();
            frmTarefas.ShowDialog();
    
        }

        private void btnCalendario_Click(object sender, EventArgs e)
        {
            FrmCalendario frmCalendario = new FrmCalendario();
            this.Hide();
            frmCalendario.ShowDialog();
            
        }


        private void Login_Click(object sender, EventArgs e)
        {
            
            FrmToSystem frmToSystem = new FrmToSystem();
            this.Hide();
            frmToSystem.Show();
       
            


        }
    }
}
