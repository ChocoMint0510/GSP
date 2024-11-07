using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DataConnect
    {
        private SqlConnection conn;
        private SqlCommand cmd;

        public DataConnect(string username, string password)
        {
            string strConn = $"Data Source=LAPTOP-NITRO5;Initial Catalog=QuanLyGSP;User ID={username};Password={password}";
            conn = new SqlConnection(strConn);
        }

        public void OpenConnection()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        public void CloseConnection()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        public int ExecuteNonQuery(string query, SqlParameter[] parameters = null)
        {
            try
            {
                OpenConnection();
                cmd = new SqlCommand(query, conn);
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }
                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error executing query: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public int ExecuteStoredProcedure(string storedProcedure, SqlParameter[] parameters = null)
        {
            try
            {
                OpenConnection();
                cmd = new SqlCommand(storedProcedure, conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }
                cmd.Parameters.Add(new SqlParameter("@ReturnValue", SqlDbType.Int)
                {
                    Direction = ParameterDirection.ReturnValue
                });
                cmd.ExecuteNonQuery();
                return (int)cmd.Parameters["@ReturnValue"].Value;
            }
            catch (Exception ex)
            {
                throw new Exception("Error executing stored procedure: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public DataTable GetData(string query, SqlParameter[] parameters = null)
        {
            try
            {
                OpenConnection();
                cmd = new SqlCommand(query, conn);
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
            catch (Exception ex)
            {
                throw new Exception("Error fetching data: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
    }
}
