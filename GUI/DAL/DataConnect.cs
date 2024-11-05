    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace DAL
    {
        internal class DataConnect
        {
            public string strConn = @"Data Source=LAPTOP-NITRO5;Initial Catalog=QuanLyGSP;Integrated Security=True";
            private SqlCommand cmd = null;
            private SqlConnection conn = null;
            private SqlDataReader reader = null;

            public DataConnect()
            {
                conn = new SqlConnection(strConn);
            }

            public void openConnection()
            {
                try 
                {
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                } catch (Exception ex){

                    throw ex;
                }  
            
            }

            public void closeConnection()
            {
                try
                {
                    if (conn.State == ConnectionState.Open)
                        conn.Close();
                }
                catch (Exception ex)
                {

                    throw ex;
                }

            }

            public SqlDataReader GetData(string table)
            {
                try
                {
                    string sql = "Select * from " + table;
                    cmd = new SqlCommand(sql);
                    cmd.Connection = conn;
                    this.openConnection();
                    reader = cmd.ExecuteReader();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                return reader;
            }
        }
    }
