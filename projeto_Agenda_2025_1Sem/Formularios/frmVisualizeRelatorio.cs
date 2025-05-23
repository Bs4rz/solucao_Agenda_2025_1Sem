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
    public partial class frmVisualizeRelatorio : Form
    {
        public frmVisualizeRelatorio()
        {
            InitializeComponent();
        }

        private void frmVisualizeRelatorio_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSet_Agenda.Pessoa'. Você pode movê-la ou removê-la conforme necessário.
            this.pessoaTableAdapter.Fill(this.dataSet_Agenda.Pessoa);

            this.reportViewer1.RefreshReport();
        }
    }
}
