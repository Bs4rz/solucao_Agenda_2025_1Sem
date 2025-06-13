using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_Agenda_2025_1Sem.Teste
{
    public partial class frmTesteVisualiza : Form
    {
        public frmTesteVisualiza()
        {
            InitializeComponent();
        }

        private void frmTesteVisualiza_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
