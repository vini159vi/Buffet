using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.IO;
using Buffet.MISC;

namespace Buffet
{
    class Database
    {
        private static SQLiteConnection connection;
        private static Database instance;
        private static string URL = "Data Source=Buffet.db";
        private static string bdNome = "Buffet.db";

        SQLiteConnection bd = new SQLiteConnection();

        private Database()
        {
            CriarTabelas(bdNome);
            connection = new SQLiteConnection(URL);
        }

        public static Database GetInstance()
        {
            if (instance == null)
            {
                instance = new Database();
            }
            return instance;
        }

        public SQLiteConnection GetConnection()
        {
            return connection;
        }

        public void ExecuteNonQuery(string qry)
        {
            if (connection.State != System.Data.ConnectionState.Open)
                connection.Open();
            SQLiteCommand comm = new SQLiteCommand(qry, connection);
            comm.ExecuteNonQuery();
            connection.Close();
        }

        public DataSet ExecuteQuery(string qry)
        {
            if (connection.State != System.Data.ConnectionState.Open)
                connection.Open();
            SQLiteCommand comm = new SQLiteCommand(qry, connection);
            SQLiteDataAdapter da = new SQLiteDataAdapter(comm);
            DataSet ds = new DataSet();
            Console.WriteLine(qry);
            ds.Clear();
            da.Fill(ds);
            connection.Close();
            return ds;
        }
        
        private void CriarTabelas(string bdNome)
        {
            Console.WriteLine("TUSCA333");
            if (!File.Exists(bdNome))
            {
                Console.WriteLine("TUSCA");
                SQLiteConnection.CreateFile(bdNome);
                SQLiteConnection conn = new SQLiteConnection(URL);
                conn.Open();
                
                TabelasDB tabelas = new TabelasDB();
                
                SQLiteCommand cmd = new SQLiteCommand(tabelas.ToString(), conn);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show("Erro ao criar banco de dados: " + ex.Message);
                }
            }
        }
  
    }
}
