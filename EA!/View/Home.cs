using System;
using EA_.View;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using System.Data.SqlClient;
using EA_.Class;

namespace EA_{

    public partial class Form1 : Form{
        //=========== //
       // POSTGRESQL //
      // ========== //
        
        //NpgsqlConnection conn = new NpgsqlConnection();

        public Form1(){
            InitializeComponent();
        }



        private void pessoaFisicaToolStripMenuItem_Click(object sender, EventArgs e){
            frmCadastroPessoaFisica PessoaFisica = new frmCadastroPessoaFisica();
            PessoaFisica.Show();
            this.Hide();
        }

        private void pessoaJuridicaToolStripMenuItem_Click(object sender, EventArgs e){
            frmCadastroPessoaJuridica PessoaJuridica = new frmCadastroPessoaJuridica();
            PessoaJuridica.Show();
            this.Hide();
        }

        private void entrarToolStripMenuItem_Click(object sender, EventArgs e){
            frmLogin Login = new frmLogin();
            Login.Show();
            this.Hide();
        }

        private void mapaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMapa Mapa = new frmMapa();
            Mapa.Show();
            this.Hide();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e){
            frmSobre Sobre = new frmSobre();
            Sobre.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e){
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
