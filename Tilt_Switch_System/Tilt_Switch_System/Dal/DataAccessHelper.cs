using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;

namespace Tilt_Switch_System.Dal
{
    public class DataAccessHelper
    {
        OleDbDataAdapter adp;
        OleDbCommand cmd;
        DataTable dt;
        public OleDbConnection conn;

        public DataAccessHelper()
        {
            conn = new OleDbConnection();
            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Persist Security Info = False; Data Source=" + AppDomain.CurrentDomain.BaseDirectory + @"\Database\Ldt.accdb";
        }

        public void connectionState()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            else
            {
                conn.Close();
                conn.Open();
            }
        }

        public int executeqry(string Qry)
        {
            connectionState();
            int ret = 0;
            cmd = new OleDbCommand();
            cmd.Connection = conn;
            cmd.CommandText = Qry;
            ret = cmd.ExecuteNonQuery();
            return ret;
        }
        public int ExecuteScalar(string Qry)
        {
            connectionState();
            int ret = 0;
            cmd = new OleDbCommand();
            cmd.Connection = conn;
            cmd.CommandText = Qry;
            ret = (int)cmd.ExecuteScalar();
            return ret;
        }

        public int ExecuteNonQuery(string Qry, string[] inputParams, Object[] inputValues)
        {
            connectionState();
            int ret = 0;
            cmd = new OleDbCommand();
            cmd.Connection = conn;
            cmd.CommandText = Qry;
            OleDbParameter para;
            for (int i = 0; i < inputParams.Length; i++)
            {
                if (inputValues[i] == null)
                    inputValues[i] = DBNull.Value;
                para = new OleDbParameter(inputParams[i], inputValues[i].ToString());
                cmd.Parameters.Add(para);
            }
            ret = cmd.ExecuteNonQuery();
            return ret;
        }

        public DataTable GetDatatable(string Qry)
        {
            dt = new DataTable();
            adp = new OleDbDataAdapter(Qry, conn);
            adp.Fill(dt);
            return dt;
        }

        public DataTable GetparameterDatatable(string Qry, string[] inputParams, Object[] inputValues)
        {
            dt = new DataTable();
            cmd = new OleDbCommand();
            cmd.Connection = conn;
            cmd.CommandText = Qry;
            OleDbParameter para = null;
            for (int i = 0; i < inputParams.Length; i++)
            {
                if (inputValues[i] == null)
                    inputValues[i] = DBNull.Value;
                para = new OleDbParameter(inputParams[i], inputValues[i]);
                cmd.Parameters.Add(para);
            }
            adp = new OleDbDataAdapter(cmd);
            adp.Fill(dt);
            return dt;
        }
        ~DataAccessHelper()
        {
        }
    }
}