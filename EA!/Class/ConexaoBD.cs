using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace EA_.Class
{
    class ConexaoBD
    {
        private NpgsqlDataAdapter data_adapter;
        private DataTable data_table;
        NpgsqlConnection conn;

        public string ConnectionString = @"Host=127.0.0.1;Username=postgres;Password=24140123;Database=EstacioneAqui";
        public NpgsqlConnection Conectar()
        {
          //conection = new SqlConnection(stringConection);
           conn = new NpgsqlConnection(ConnectionString);
            
                //abre a conexão com o banco
                conn.Open();
                // Executa uma consulta que não retorna nenhum valor
                // Insere um registro na tabela
                return conn;  
        }

        public void desconectar()
        {
            conn.Close();
        }
    }
}

