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

namespace VarlıkZimmetDepo.UI
{
   public class SqlConn
    {
       private static SqlConnection conn = null;
        private static SqlCommand cmd = null;
        private static SqlConn con;

        private  SqlConn( string Adres = "Server=.;Database=VarlikZimmetDepo;Trusted_Connection=True")
        {
            conn = new SqlConnection(Adres);
            conn.Open();
           
       
        }
        public static SqlConnection Baglanti
        {
            get 
            {
                if (conn == null)
                {
                    con = new SqlConn();
                }
                return conn;
            }
        
        }
        public static SqlCommand Komut(string komut)
        {
            
                cmd = new SqlCommand(komut);
            cmd.Connection = conn;
                return cmd ;
            
            
        }
        public void Close()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

        }
        public void Open()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

        }

    }
}
