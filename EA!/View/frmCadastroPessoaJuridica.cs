using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EA_.Modelo;
using EA_.Class;
using Npgsql;
using NpgsqlTypes;

namespace EA_.View
{
    public partial class frmCadastroPessoaJuridica : Form
    {
        private BindingSource bind_source;
        private NpgsqlDataAdapter data_adapter;
        private DataTable data_table;

        ControleLogin controle = new ControleLogin();
        ConexaoBD conexao = new ConexaoBD();
        ValidaCNPJ cnpj = new ValidaCNPJ();
        public frmCadastroPessoaJuridica(){
            InitializeComponent();
        }

        private void pessoaFisicaToolStripMenuItem_Click(object sender, EventArgs e){
            frmCadastroPessoaFisica cadastroPessoaFisica = new frmCadastroPessoaFisica();
            cadastroPessoaFisica.Show();
            this.Hide();
        }

        private void pessoaJuridicaToolStripMenuItem_Click(object sender, EventArgs e){
            frmCadastroPessoaJuridica cadastroPessoaJuridica = new frmCadastroPessoaJuridica();
            cadastroPessoaJuridica.Show();
            this.Hide();
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e){
            Form1 Home = new Form1();
            Home.Show();
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

        private void entrarToolStripMenuItem_Click(object sender, EventArgs e){
            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();
        }

        private void mapaToolStripMenuItem_Click(object sender, EventArgs e){
            frmMapa mapa = new frmMapa();
            mapa.Show();
            this.Hide();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e){
            frmSobre Sobre = new frmSobre();
            Sobre.Show();
            this.Hide();
        }

        private void btnCadastrar_Click(object sender, EventArgs e){
            controle.cargo = "Pessoa Juridica";
            NpgsqlConnection conexaoBD = new NpgsqlConnection(conexao.ConnectionString);
            string strSelect = "SELECT * FROM tb_cliente";
            string cnpj;

            conexaoBD.Open();

            NpgsqlCommand command = new NpgsqlCommand("INSERT INTO Usuario(cnpj,senha,cargo) VALUES(@cnpj,@senha,@cargo)", conexaoBD);
            command.Parameters.Add("@cnpj", NpgsqlDbType.Varchar).Value = txtCnpj.Text;
            command.Parameters.Add("@senha", NpgsqlDbType.Char).Value = txtSenha.Text;
            command.Parameters.Add("@cargo", NpgsqlDbType.Varchar).Value = controle.cargo;
                try
                {
                    //Cria um novo adaptador para os dados na tabela
                    data_adapter = new NpgsqlDataAdapter();
                    data_adapter.SelectCommand = new NpgsqlCommand(strSelect, conexaoBD);

                    //conexao.Conectar();
                    command.ExecuteNonQuery();
                    this.Hide();

                }
                catch (Exception error)
                {
                    MessageBox.Show("Erro no cadastramento" + error.Message + "ERRO!" + MessageBoxIcon.Error);
                }


            command = new NpgsqlCommand("INSERT INTO Endereco(rua,bairro,cidade) VALUES(@rua,@bairro,@cidade)", conexaoBD);
            command.Parameters.Add("@rua", NpgsqlDbType.Varchar).Value = txtRua.Text;
            command.Parameters.Add("@bairro", NpgsqlDbType.Varchar).Value = txtBairro.Text;
            command.Parameters.Add("@cidade", NpgsqlDbType.Varchar).Value = txtCidade.Text;

            if (txtCnpj.Text == " " && txtSenha.Text == "" && txtRua.Text == "" && txtBairro.Text == ""){
                MessageBox.Show("Preencha os campos obrigatorios", "Erro no cadastramento" + MessageBoxIcon.Error);
            }
            else { 
                try{
                    //Cria um novo adaptador para os dados na tabela
                    data_adapter = new NpgsqlDataAdapter();
                    data_adapter.SelectCommand = new NpgsqlCommand(strSelect, conexaoBD);

                    //conexao.Conectar();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Cadastrado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();

                    frmLogin login = new frmLogin();
                    login.Show();
                }
                catch(Exception error){
                    MessageBox.Show("Erro no cadastramento" + error.Message + "ERRO!" + MessageBoxIcon.Error);
                }
            }
        }
    }
}
