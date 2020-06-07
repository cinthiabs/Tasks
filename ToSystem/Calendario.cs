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
    public partial class FrmCalendario : Form
    {
        public FrmCalendario()
        {
            InitializeComponent();
        }

        private void btnCalendario_Click(object sender, EventArgs e)
        {
            //sem evento
        }

        private void btnTarefas_Click(object sender, EventArgs e)
        {
            FrmTarefas frmTarefas = new FrmTarefas();
            this.Hide();
            frmTarefas.ShowDialog();

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            FrmHome frmHome = new FrmHome();
            this.Hide();
            frmHome.ShowDialog();
          
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmToSystem frmToSystem = new FrmToSystem();
            this.Hide();
            frmToSystem.ShowDialog();
        }
    }
}
