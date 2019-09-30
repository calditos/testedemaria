using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace ConexaoTest
{
    class Conexao
    {
        public SQLiteConnection conn = new SQLiteCommection("Data Source=testeC#demaria.db");
        
        public void conectar()
        {
            conn.Open();
        }
        
        public void desconectar()
        {
            conn.Close();
        }
        
     }   
 }     