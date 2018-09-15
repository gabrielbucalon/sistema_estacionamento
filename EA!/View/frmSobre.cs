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
    public partial class frmSobre : Form
    {
        public frmSobre()
        {
            InitializeComponent();
        }
        private void fecharJanelaSobre(object sender, FormClosedEventArgs e){
            if (Application.OpenForms.Count == 0){
                Application.Exit();
            }else foreach(Form formAberto in Application.OpenForms){
                    if (formAberto is Form1) formAberto.Show(); 
                }
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 Home = new Form1();
            Home.Show();
            this.Hide();
        }

        private void pessoaFisicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroPessoaFisica pessoaFisica = new frmCadastroPessoaFisica();
            pessoaFisica.Show();
            this.Hide();
        }

        private void pessoaJuridicaToolStripMenuItem_Click(object sender, EventArgs e){
            frmCadastroPessoaJuridica pessoaJuridica = new frmCadastroPessoaJuridica();
            pessoaJuridica.Show();
            this.Hide();
        }

        private void entrarToolStripMenuItem_Click(object sender, EventArgs e){
            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();
        }

        private void mapaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMapa mapa = new frmMapa();
            mapa.Show();
            this.Hide();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSobre sobre = new frmSobre();
            sobre.Show();
            this.Hide();
        }
    }
}
