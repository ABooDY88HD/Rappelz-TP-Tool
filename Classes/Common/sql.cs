using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;

namespace TP_Tool_11._2
{
    class sql
    {
        public static String ConnectionString { get{return "User Id=" + Properties.Settings.Default.username + ";Password=" + Properties.Settings.Default.password + ";Data Source=" + Properties.Settings.Default.ip + ";Initial Catalog=" + Properties.Settings.Default.arcadia + ";connection timeout=5;MultipleActiveResultSets = True;";}}

        public static Boolean TestConnection()
        {
            try
            {
                new SqlConnection(string.Concat(ConnectionString)).Open();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static DataTable fetch_table(String query)
        {
            SqlConnection sqlConnection = new SqlConnection(string.Concat(ConnectionString));
            sqlConnection.Open();
            SqlDataAdapter SQLAD = new SqlDataAdapter(query, sqlConnection);
            DataTable data = new DataTable();
            SQLAD.Fill(data);
            sqlConnection.Close();

            return data;
        }

        public static String[] fetch_list(String query)
        {
            List<String> ls = new List<string>();
            SqlConnection sqlConnection = new SqlConnection(string.Concat(ConnectionString));
            SqlCommand cmd = new SqlCommand(query, sqlConnection);

            sqlConnection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
                ls.Add(reader.GetValue(0) + "");

            sqlConnection.Close();
            return ls.ToArray();
        }

        public static String fetch_result(String query)
        {
            SqlConnection sqlConnection = new SqlConnection(string.Concat(ConnectionString));
            SqlCommand cmd = new SqlCommand(query, sqlConnection);

            sqlConnection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
                return reader.GetValue(0).ToString();
            return "";
        }

        public static DataTable fetch_text_file(String name, String parameters, Char delimit)
        {
            int parameters_count = parameters.Split(',').Length;
            DataTable dt = new DataTable();
            String[] file = File.ReadAllLines(@".\gm_data\" + name + ".txt");

            foreach (String line in file)
            {
                string[] str = line.Split(delimit);
                dt.Rows.Add(new object[] { str[0], str[1], str[2] });
            }

            return dt;
        }
    }
}
