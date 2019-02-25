using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class ConexaoBanco
    {
        private MySqlConnection conexao;
        private MySqlCommand comando;

        public ConexaoBanco()
        {
            string strConexao;
            strConexao = ConfigurationManager.ConnectionStrings["conexao"].ToString();
            conexao = new MySqlConnection(strConexao);
            comando = conexao.CreateCommand();
            try
            {
                conexao.Open();
                //MessageBox.Show("Conexão bem sucedida.\n");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Falha na conexão com o banco.\n" + ex.Message);
            }
        }
        public string Executarcomando(string pComando, Dictionary<String, Object> pParametros)
        {
            comando.CommandText = pComando;
            comando.Parameters.Clear();
            foreach (var item in pParametros)
            {
                comando.Parameters.AddWithValue(item.Key, item.Value);
            }
            comando.ExecuteNonQuery();
            return "";
        }
        public DataTable ExecutarSelect(string pSelect, Dictionary<String, Object> pParametros)
        {
            DataTable tabela = new DataTable();
            comando.CommandText = pSelect;
            comando.Parameters.Clear();
            foreach (var item in pParametros)
            {
                comando.Parameters.AddWithValue(item.Key, item.Value);
            }
            tabela.Load(comando.ExecuteReader());
            return tabela;
        }
        public DataTable ExecutarSelect(string pSelect)
        {
            DataTable tabela = new DataTable();
            comando.CommandText = pSelect;
            comando.Parameters.Clear();
            tabela.Load(comando.ExecuteReader());
            return tabela;
        }
    }
}
