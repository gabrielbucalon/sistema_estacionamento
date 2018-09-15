using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EA_.View
{
    public partial class frmMenuPessoaJuridica : Form
    {
        public frmMenuPessoaJuridica()
        {
            InitializeComponent();
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            frmES ES = new frmES();
            this.Hide();
            ES.Show();
        }

        private void mapaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMapa mapa = new frmMapa();
            this.Hide();
            mapa.Show();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSobre sobre = new frmSobre();
            this.Hide();
            sobre.Show();
        }

        private void relatorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelatorio relatorio = new frmRelatorio();
            this.Hide();
            relatorio.Show();
        }
    }
}

