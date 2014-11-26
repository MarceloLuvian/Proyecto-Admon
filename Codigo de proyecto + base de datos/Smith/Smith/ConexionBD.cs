using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace SmithyAsociados
{
    class ConexionBD
    {
       MySqlConnection con = new MySqlConnection("Server = 127.0.0.1; Database = bfabogados; Uid = Marcelo; Pwd=zxcv24ab;");
       MySqlCommand instruccionSQL = new MySqlCommand();    
       public DataSet ds = new DataSet();      
       public int id =0 ;
       public String respuesta;

       public void Conectar()
       {
       try
       {
       con.Open();               
       con.Close();
       }
       catch (Exception e)
       {
       MessageBox.Show("error " + e);
       }
       }

        public bool ejecutar(String SQLComando) {
                con.Open();
                instruccionSQL = new MySqlCommand(SQLComando,con);
                int i = instruccionSQL.ExecuteNonQuery();
                instruccionSQL.Dispose();
                con.Close();
                if (i > 0)
                {
                return true;                   
                }else {                    
                return false;                   
                }
                }

        public int consultarID(String SQLComando){
            MySqlDataReader consulta;
            MySqlConnection con2 = new MySqlConnection("Server = 127.0.0.1; Database = bfabogados; Uid = Marcelo; Pwd=zxcv24ab;");
            con2.Open();
            instruccionSQL = new MySqlCommand(SQLComando,con2) ;
            consulta = instruccionSQL.ExecuteReader();
            while (consulta.Read())
            {
            id = consulta.GetInt32(0);  
            }
            return id;            
            }

        public String consultarTipo(String SQLComando)
        {            
            MySqlDataReader consulta2;
            MySqlConnection con3 = new MySqlConnection("Server = 127.0.0.1; Database = bfabogados; Uid = Marcelo; Pwd=zxcv24ab;");
            con3.Open();
            MySqlCommand instruccionSQL3 = new MySqlCommand(SQLComando, con3);
            consulta2 = instruccionSQL3.ExecuteReader();
            while (consulta2.Read())
            {
                respuesta = consulta2.GetString(0);
                
            }
            return respuesta;
          
        }   

        public void ActualizarTabla(DataGridView DG, String _comSQL)
        {
            String _SQL = _comSQL;
            MySqlDataAdapter data;
            DataTable dt;
            try
            {
                data = new MySqlDataAdapter(_SQL, con);
                dt = new DataTable();
                data.Fill(dt);
                DG.DataSource = dt;
            }
            catch (Exception e)
            {
                MessageBox.Show("No se pudo llenar el dataGridview" + e);

            }

        }
        

    }
}