using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EA_.Class;
using EA_.Modelo;

namespace EA_.View
{
    public partial class frmLogin : Form
    {
        public string cargoteste;
        ConexaoBD conexao = new ConexaoBD();
        ControleLogin controle = new ControleLogin();

        public frmLogin()
        {
            InitializeComponent();
        }
        string mensagem;

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e){
            if (Application.OpenForms.Count == 0)
            {
                Application.Exit();
            }
            else foreach (Form formAberto in Application.OpenForms)
                {
                    if (formAberto is Form1) formAberto.Show();
                }
        }

        private void entrarToolStripMenuItem_Click(object sender, EventArgs e){
            frmLogin Login = new frmLogin();
            Login.Show();
            this.Hide();
        }

        private void mapaToolStripMenuItem_Click(object sender, EventArgs e){
            frmMapa Mapa = new frmMapa();
            Mapa.Show();
            this.Hide();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e){
            frmSobre Sobre = new frmSobre();
            Sobre.Show();
            this.Hide();
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e){
            Form1 Home = new Form1();
            Home.Show();
            this.Hide();
        }

        private void rdPessoaFisica_CheckedChanged(object sender, EventArgs e){
            if(rdPessoaFisica.Checked){
                lblSenhaEmail.Text = "E-mail";
            }else if (rdPessoaJuridica.Checked){
                lblSenhaEmail.Text = "CPF"; 
            }
        }

        private void rdPessoaJuridica_CheckedChanged(object sender, EventArgs e){
            if (rdPessoaFisica.Checked)
            {
                lblSenhaEmail.Text = "E-mail";
                txtCPF.Hide();
                txtEmail.Show();
            }
            else if (rdPessoaJuridica.Checked)
            {
                lblSenhaEmail.Text = "CNPJ";
                txtEmail.Hide();
                txtCPF.Show();
            }
        }

        private void linkparacadastrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e){
            if (btnPessoaFisica.Visible && btnPessoaJuridica.Visible && lblOU.Visible)
            {
                btnPessoaJuridica.Hide();
                btnPessoaFisica.Hide();
                lblOU.Hide();
            }
            else
            {
                btnPessoaJuridica.Show();
                btnPessoaFisica.Show();
                lblOU.Show();
            }
        }

        private void txtCPFouEmail_TextChanged(object sender, EventArgs e){
            string email = txtEmail.Text;
            if (rdPessoaFisica.Checked) { 
                if (email.IndexOf('@') == -1 || email.IndexOf('.') == -1){
                    lblEmailOuCPFIncorreto.Show();
                }
                else lblEmailOuCPFIncorreto.Hide();
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e){
            string email = txtEmail.Text;
            string valor = txtCPF.Text;
            string cargo = "";

            if(rdPessoaFisica.Checked)
            {
                if (txtEmail.Text == "" && txtSenha.Text == "")
                {
                    MessageBox.Show("Preencha os campos vazios, por favor");
                }
                else if (txtEmail.Text == "") MessageBox.Show("Preencha o e-mail.");
                else if (txtSenha.Text == "") MessageBox.Show("Preencha a senha.");
                else 
                if(controle.mensagem.Equals(""))
                {
                    controle.acessar(txtEmail.Text, txtSenha.Text,ref cargo);
                    if (controle.tem)
                    {

                        frmMenuPessoaFisica menuPessoaFisica = new frmMenuPessoaFisica();
                        this.Hide();
                        if (cargo == "Pessoa Fisica"){
                            MessageBox.Show("Logado com sucesso!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            menuPessoaFisica.Show();
                        }
                        else MessageBox.Show("Pessoa Fisica não encontrada, verifique se você é cadastrado no sistema","erro" + MessageBoxIcon.Error);
                    }
                    else{
                        MessageBox.Show("E-mail ou senha estão errados\nTente novamente", "Login incorreto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            if (rdPessoaJuridica.Checked){
                if (txtCPF.Text == "") { MessageBox.Show("Preencha o CNPJ"); }
                else if (ValidaCNPJ.Cnpj(valor)){
                    if (controle.mensagem.Equals(""))
                    {
                        cargo = "Pessoa Juridica";
                        controle.acessar(valor, txtSenha.Text, ref cargo);
                        if (controle.tem){
                            controle.cargo = cargo;
                            frmMenuPessoaJuridica menuPessoaJuridica = new frmMenuPessoaJuridica();
                            this.Hide();
                            if (cargo == "Pessoa Juridica"){
                                MessageBox.Show("Logado com sucesso!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                menuPessoaJuridica.Show();
                            }
                            else MessageBox.Show("Pessoa juridica não encontrada, verifique se você é cadastrado no sistema", "erro" + MessageBoxIcon.Error);
                        }else MessageBox.Show("CNPJ ou senha estão errados\nTente novamente", "Login incorreto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }


                else{
                    mensagem = "O número é um CNPJ Inválido !";
                    MessageBox.Show(mensagem, "ERRO EM LOGAR");
                }
            }
        }

        private void txtCPF_TextChanged(object sender, EventArgs e){
            
        }

        private void pessoaFisicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroPessoaFisica cadastroPessoaFisica = new frmCadastroPessoaFisica();
            cadastroPessoaFisica.Show();
            this.Hide();
        }

        private void pessoaJuridicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroPessoaJuridica cadastroPessoaJuridica = new frmCadastroPessoaJuridica();
            cadastroPessoaJuridica.Show();
            this.Hide();
        }

        private void btnPessoaFisica_Click(object sender, EventArgs e){
            frmCadastroPessoaFisica cadastroPessoaFisica = new frmCadastroPessoaFisica();
            cadastroPessoaFisica.Show();
            this.Hide();
        }

        private void pessoaFisicaToolStripMenuItem_Click_1(object sender, EventArgs e){
            frmCadastroPessoaFisica cadastroPessoaFisica = new frmCadastroPessoaFisica();
            cadastroPessoaFisica.Show();
            this.Hide();
        }

        private void pessoaJuridicaToolStripMenuItem_Click_1(object sender, EventArgs e){
            frmCadastroPessoaJuridica cadastroPessoaJuridica = new frmCadastroPessoaJuridica();
            cadastroPessoaJuridica.Show();
            this.Hide();
        }

        private void entrarToolStripMenuItem_Click_1(object sender, EventArgs e){
            frmLogin Login = new frmLogin();
            Login.Show();
            this.Hide();
        }

        private void inicioToolStripMenuItem_Click_1(object sender, EventArgs e){
            Form1 home = new Form1();
            home.Show();
            this.Hide();
        }

        private void mapaToolStripMenuItem_Click_1(object sender, EventArgs e){
            frmMapa Mapa = new frmMapa();
            Mapa.Show();
            this.Hide();
        }

        private void sobreToolStripMenuItem_Click_1(object sender, EventArgs e){
            frmSobre Sobre = new frmSobre();
            Sobre.Show();
            this.Hide();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
