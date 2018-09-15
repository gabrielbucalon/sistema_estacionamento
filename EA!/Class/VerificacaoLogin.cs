using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using EA_.Modelo;

namespace EA_.Class
{
    public class VerificacaoLogin
    {

        public string selectLoginPessoaFisica = "SELECT usuario,senha,cargo FROM Usuario where usuario = @usuario AND senha = @Senha";
        public bool tem = false;
        public string mensagem = "";
        ConexaoBD conexao = new ConexaoBD();
        ControleLogin controle = new ControleLogin();

        NpgsqlCommand command = new NpgsqlCommand(); 

        public bool verificaLogin(String usuario, String senha, ref String cargo){

            if (cargo == "Pessoa Juridica"){
                NpgsqlConnection conexaoBD = new NpgsqlConnection(conexao.ConnectionString);
                conexaoBD.Open();
                command.Connection = conexaoBD;
                command.CommandText = "SELECT cnpj,senha,cargo FROM Usuario where cnpj = @cnpj AND senha = @senha ";
                command.Parameters.AddWithValue("@cnpj", usuario);
                command.Parameters.AddWithValue("@senha", senha);

                try
                {
                    conexao.Conectar();
                    //command.ExecuteNonQuery();

                    NpgsqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        tem = true;
                        reader.Read();

                        controle.cargo = reader.GetString(2);
                        cargo = controle.cargo;
                    }
                }
                catch (NpgsqlException ex)
                {
                    this.mensagem = "Erro com banco de dados\n\nVerificacaoLogin" + ex.Message;
                }
            }
            else { 

                NpgsqlConnection conexaoBD = new NpgsqlConnection(conexao.ConnectionString);
                conexaoBD.Open();
                command.Connection = conexaoBD;
                command.CommandText = "SELECT usuario,senha,cargo FROM Usuario where usuario = @usuario AND senha = @senha ";
                command.Parameters.AddWithValue("@usuario", usuario);
                command.Parameters.AddWithValue("@senha", senha);


                try
                {
                    conexao.Conectar();
                    //command.ExecuteNonQuery();
                
                    NpgsqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows){
                        tem = true;
                        reader.Read();

                        controle.cargo = reader.GetString(2);
                        cargo = controle.cargo;
                    }
                }catch(NpgsqlException ex){
                    this.mensagem = "Erro com banco de dados\n\nVerificacaoLogin" + ex.Message ;
                }
            }
            return tem;
        }

        public string Cadastrar(){
            return mensagem;
        }
    }
}
