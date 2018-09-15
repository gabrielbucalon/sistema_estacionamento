using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using EA_.Modelo;
using EA_.Class;
using Npgsql;
using NpgsqlTypes;

namespace EA_.View
{
    public partial class frmCadastroPessoaFisica : Form
    {
        private BindingSource bind_source;
        private NpgsqlDataAdapter data_adapter;
        private DataTable data_table;

        
        ConexaoBD conexao = new ConexaoBD();
        ControleLogin controle = new ControleLogin();

        public frmCadastroPessoaFisica(){
            InitializeComponent();
        }

        private void pessoaFisicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroPessoaFisica cadastroPessoaFisica = new frmCadastroPessoaFisica();
            cadastroPessoaFisica.Show();
            this.Hide();
        }

        private void pessoaJuridicaToolStripMenuItem_Click(object sender, EventArgs e){
            
        }

        private void pessoaJuridicaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmCadastroPessoaJuridica cadastroPessoaJuridica = new frmCadastroPessoaJuridica();
            cadastroPessoaJuridica.Show();
            this.Hide();
        }

        private void mapaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMapa Mapa = new frmMapa();
            Mapa.Show();
            this.Hide();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSobre Sobre = new frmSobre();
            Sobre.Show();
            this.Hide();
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e){
            Form1 Home = new Form1();
            Home.Show();
            this.Hide();
        }

        private void btnCadastrar_Click(object sender, EventArgs e){
            controle.cargo = "Pessoa Fisica";
            NpgsqlConnection conexaoBD = new NpgsqlConnection(conexao.ConnectionString);
            string strSelect = "SELECT * FROM tb_cliente";
            string email;

            conexaoBD.Open();
           
            NpgsqlCommand command = new NpgsqlCommand("INSERT INTO Cliente(nome,sobrenome) VALUES (@nome,@sobrenome)", conexaoBD);
            command = new NpgsqlCommand("INSERT INTO Usuario(usuario,senha,cargo) VALUES (@usuario,@senha,@cargo)", conexaoBD);


            command.Parameters.Add("@nome", NpgsqlDbType.Varchar).Value = txtNome.Text;
            command.Parameters.Add("@sobrenome", NpgsqlDbType.Varchar).Value = txtSobrenome.Text;
            command.Parameters.Add("@senha", NpgsqlDbType.Char).Value = txtSenha.Text;
            command.Parameters.Add("@usuario", NpgsqlDbType.Varchar).Value = txtEmail.Text;
            command.Parameters.Add("@cargo", NpgsqlDbType.Varchar).Value = controle.cargo;


            email = txtEmail.Text;
            if (txtSenha.Text != txtConfirmaSenha.Text){
                MessageBox.Show("Senhas incorretas","SENHAS");
            }else if (email.IndexOf('@') == -1 || email.IndexOf('.') == -1){
                MessageBox.Show("E-mail incorreto","E-mail");
            }
            else { 
                try{
                    //Cria um novo adaptador para os dados na tabela
                    data_adapter = new NpgsqlDataAdapter();
                    data_adapter.SelectCommand = new NpgsqlCommand(strSelect, conexaoBD);

                    conexao.Conectar();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Cadastrado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();

                    frmLogin login = new frmLogin();
                    login.Show();
                }
                catch (Exception error){
                    MessageBox.Show("Falha no cadastramento em pessoa fisica.","ERRO AO CADASTRAR",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    MessageBox.Show(":(", "ERRO AO CADASTRAR" + error.Message);
                }
            }
        }
        private void verifica_email(object sender, EventArgs e){
            string email = txtEmail.Text;

            if (email.IndexOf('@') == -1 || email.IndexOf('.') == -1)
            {
                lblEmailIncorreto.Show();
            }
            else lblEmailIncorreto.Hide();
        }

        private void verifica_ConfirmaSenha(object sender, EventArgs e){
            if (txtSenha.Text != txtConfirmaSenha.Text)
            {
                lblSenhasDiferentes.Show();
            }
            else lblSenhasDiferentes.Hide();
        }
        private void BtnLimpar(object sender, EventArgs e)
        {
            txtConfirmaSenha.Text = "";
            txtEmail.Text = "";
            txtNome.Text = "";
            txtSenha.Text = "";
            txtSobrenome.Text = "";
        }

        private void btnCanecelar_Click(object sender, EventArgs e)
        {
        }
    }        
}   

   