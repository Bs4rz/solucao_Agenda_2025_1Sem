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
    public partial class frmConsultasPessoas : Form
    {
        public frmConsultasPessoas()
        {
            InitializeComponent();
        }

        private void frmConsultasPessoas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSet_Agenda.Pessoa'. Você pode movê-la ou removê-la conforme necessário.
            this.pessoaTableAdapter.Fill(this.dataSet_Agenda.Pessoa);

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            // like seria o sentindo literal "tipo" 
            // '%' funciona como um separador, para puxar o txtPesquisa.Text 
            // se faltar no comeco e tiver no final ele puxa na primeira palavra e visse versa
            // se tiver em ambos puxa tudo
            if (cbbOrientacao.Text == "Possui")
            {
                pessoaBindingSource.Filter = "Nome like '%" + txtPesquisar.Text + "%'";
            } else if (cbbOrientacao.Text == "Inicia Com")
            {
                pessoaBindingSource.Filter = "Nome like '" + txtPesquisar.Text + "%'";
            } else if (cbbOrientacao.Text == "Finaliza Com")
            {
                pessoaBindingSource.Filter = "Nome like '%" + txtPesquisar.Text + "'";
            } 
        }
    }
}
