using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_Agenda_2025_1Sem.Formularios
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void pessoasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadPessoas objCadPessoas = new frmCadPessoas();
            objCadPessoas.MdiParent = this;
            objCadPessoas.Show();
        }

        private void pessoasFiltroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultasPessoas objConsultasPessoas = new frmConsultasPessoas();
            objConsultasPessoas.MdiParent = this;
            objConsultasPessoas.Show();
        }

        private void relatorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVisualizeRelatorio objVisualiza = new frmVisualizeRelatorio();
            objVisualiza.MdiParent = this;
            objVisualiza.Show();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
