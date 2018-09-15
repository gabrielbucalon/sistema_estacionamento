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
    public partial class frmES : Form
    {
        private BindingSource bind_source;
        private NpgsqlDataAdapter data_adapter;
        private DataTable data_table;
        NpgsqlCommand command = new NpgsqlCommand();
        ConexaoBD conexao = new ConexaoBD();
        ControleLogin controle = new ControleLogin();

        public frmES()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e){
            NpgsqlConnection conexaoBD = new NpgsqlConnection(conexao.ConnectionString);
            conexaoBD.Open();
            string strSelect = "SELECT * FROM tb_cliente";
            NpgsqlCommand command = new NpgsqlCommand("INSERT INTO Veiculo(placa, modelo, marca) VALUES (@placa, @modelo, @marca)", conexaoBD);
       
            try
            {
                data_adapter = new NpgsqlDataAdapter();
                data_adapter.SelectCommand = new NpgsqlCommand(strSelect, conexaoBD);

                command.Parameters.Add("@placa", NpgsqlDbType.Char).Value = txtPlaca.Text;
                command.Parameters.Add("@modelo", NpgsqlDbType.Char).Value = txtModelo.Text;
                command.Parameters.Add("@marca", NpgsqlDbType.Char).Value = txtMarca.Text;

                MessageBox.Show("Cadastrado com sucesso!", "Entrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPlaca.Text = "";
                txtModelo.Text = "";
                txtMarca.Text = "";

                conexao.Conectar();
                command.ExecuteNonQuery();
            }
            catch(Exception error){
                MessageBox.Show("erro", error.Message);
            }
            finally{
                conexao.desconectar();
            }
            //command = new NpgsqlCommand("INSERT INTO Reserva(pagamento, quantidadeDeHorasReserva) VALUES (@pagamento,@quantidadeDeHorasReserva)", conexaoBD);

            
            //command.Parameters.Add("@usuario", NpgsqlDbType.Varchar).Value = txtEmail.Text;
            //command.Parameters.Add("@cargo", NpgsqlDbType.Varchar).Value = controle.cargo;
        }

        private void relatorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelatorio relatorio = new frmRelatorio();
            this.Hide();
            relatorio.Show();
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conexaoBD = new NpgsqlConnection(conexao.ConnectionString);
            conexaoBD.Open();
            command.Connection = conexaoBD;
            command.CommandText = "SELECT marca FROM veiculo where placa = @placa";
           
            string placa = txtBuscaPlaca.Text;
            
            
            command.Parameters.AddWithValue("@placa", placa);
            try
            {
                NpgsqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows){ 
                    reader.Read();
                }
            }
            catch(Exception error){
                MessageBox.Show("",error.Message);
            }
            finally
            {
                conexaoBD.Close();
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void frmES_Load(object sender, EventArgs e)
        {

        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conexaoBD = new NpgsqlConnection(conexao.ConnectionString);
            conexaoBD.Open();
            string strSelect = "SELECT * FROM tb_cliente";
            NpgsqlCommand command = new NpgsqlCommand("INSERT INTO Reserva(quantidadeDeHorasReserva, pagamento) VALUES (@quantidadeDeHorasReserva, @pagamento)", conexaoBD);

            try
            {
                data_adapter = new NpgsqlDataAdapter();
                data_adapter.SelectCommand = new NpgsqlCommand(strSelect, conexaoBD);

                command.Parameters.Add("@quantidadeDeHorasReserva", NpgsqlDbType.Integer).Value = Convert.ToInt32(txtTempo.Text);
                command.Parameters.Add("@pagamento", NpgsqlDbType.Integer).Value = Convert.ToInt32(txtTotalPagar.Text);

                MessageBox.Show("Finalizado com sucesso!", "Finalizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTotalPagar.Text = "";
                txtTempo.Text = "";

                conexao.Conectar();
                command.ExecuteNonQuery();
            }
            catch (Exception error)
            {
                MessageBox.Show("erro", error.Message);
            }
            finally
            {
                conexao.desconectar();
            }

        }
    }
}
