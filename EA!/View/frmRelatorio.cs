using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Npgsql;

namespace EA_.View
{
    public partial class frmRelatorio : Form
    {
        private NpgsqlDataAdapter data_adapter;
        private DataTable data_table;

        public frmRelatorio()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmES es = new frmES();
            this.Hide();
            es.Show();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSobre sobre = new frmSobre();
            this.Hide();
            sobre.Show();
        }

        private void mapaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMapa mapa = new frmMapa();
            this.Hide();
            mapa.Show();
        }

        private void frmRelatorio_Load(object sender, EventArgs e)
        {
            string strConexao = @"Host=127.0.0.1;Username=postgres;Password=24140123;Database=EstacioneAqui";
            string strSelect = "SELECT placa, modelo, marca FROM veiculo";
            string strSelect2 = "SELECT v.placa, v.modelo, v.marca, r.quantidadeDeHorasReserva, r.pagamento FROM veiculo v INNER JOIN reserva r ON r.id_placa = v.id_placa";

            NpgsqlConnection conexao = new NpgsqlConnection(strConexao);
            conexao.Open();

           NpgsqlCommand cmd = new NpgsqlCommand("SELECT SUM(pagamento) FROM reserva", conexao);//comando de seleção
            
           long count = (long)cmd.ExecuteScalar();
           txtValorTotal.Text = count.ToString();
            
            try
            {
                //Cria um novo adaptador para os dados na tabela
                data_adapter = new NpgsqlDataAdapter();
                data_adapter.SelectCommand = new NpgsqlCommand(strSelect, conexao);


                //cria os comandos insert update e delete
                NpgsqlCommandBuilder cmdBuilder = new NpgsqlCommandBuilder(data_adapter);

                //Diz que iremos utilizar "colchetes" para especificar objetos 
                //de banco de dados (tabelas, colunas...)cujos nomes contenham caracteres 
                //como espaços ou símbolos reservados;
                cmdBuilder.QuotePrefix = "[";
                cmdBuilder.QuoteSuffix = "]";

                //cria e prenche uma tabela com os dados do banco usando o adaptador
                data_table = new DataTable();
                data_adapter.Fill(data_table);

                //diz para o grid utilizar essa tabela como fonte de dados
                gvClientes.DataSource = data_table;

                //Entrada

                //Cria um novo adaptador para os dados na tabela
                data_adapter = new NpgsqlDataAdapter();
                data_adapter.SelectCommand = new NpgsqlCommand(strSelect2, conexao);


                //cria os comandos insert update e delete
                NpgsqlCommandBuilder cmdBuilder2 = new NpgsqlCommandBuilder(data_adapter);

                //Diz que iremos utilizar "colchetes" para especificar objetos 
                //de banco de dados (tabelas, colunas...)cujos nomes contenham caracteres 
                //como espaços ou símbolos reservados;
                cmdBuilder.QuotePrefix = "[";
                cmdBuilder.QuoteSuffix = "]";

                //cria e prenche uma tabela com os dados do banco usando o adaptador
                data_table = new DataTable();
                data_adapter.Fill(data_table);

                //diz para o grid utilizar essa tabela como fonte de dados
                gvClientes2.DataSource = data_table;

                //txtValorTotal.Text = valorTotal;
            }
            //monitora possíveis erros
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            //fecha a conexão
            finally
            {
                conexao.Close();
            }

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // sem o "SqlCommandBuilder" essa linha irá gerar um erro
            //passa os dados da tabela para o adapter que se conecta com o banco
            //e o atualiza
            data_adapter.Update(data_table);
            MessageBox.Show("Dados Salvos!");
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.gvClientes.SelectedRows)
            {
                gvClientes.Rows.RemoveAt(item.Index);
            }

            // sem o "SqlCommandBuilder" essa linha irá gerar um erro
            //passa os dados da tabela para o adapter que se conecta com o banco
            //e o atualiza
            data_adapter.Update(data_table);
        }
    }

}

