using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace honda.DAL
{
    public class DataProvider
    {
        private static DataProvider? instance;
        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return instance; }
            private set { instance = value; }
        }

        private readonly string connectionString = @"Server=np:\\.\pipe\LOCALDB#E3911D1B\tsql\query;Database=HondaManagement;Trusted_Connection=True;TrustServerCertificate=True;";

        private DataProvider() { }

        public DataTable ExecuteQuery(string query, object[]? parameter = null)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (parameter != null)
                    {
                        string[] listPara = query.Split(' ');
                        int i = 0;
                        foreach (string item in listPara)
                        {
                            if (item.Contains('@'))
                            {
                                string cleanItem = item.Trim();
                                while (cleanItem.Length > 0 && (cleanItem.EndsWith(",") || cleanItem.EndsWith(")") || cleanItem.EndsWith(";")))
                                {
                                    cleanItem = cleanItem.Substring(0, cleanItem.Length - 1);
                                }
                                int atIndex = cleanItem.IndexOf('@');
                                if (atIndex >= 0)
                                {
                                    cleanItem = cleanItem.Substring(atIndex);
                                }
                                if (!command.Parameters.Contains(cleanItem) && i < parameter.Length)
                                {
                                    command.Parameters.AddWithValue(cleanItem, parameter[i] ?? DBNull.Value);
                                    i++;
                                }
                            }
                        }
                    }
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(data);
                    }
                }
            }
            return data;
        }

        public int ExecuteNonQuery(string query, object[]? parameter = null)
        {
            int data = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (parameter != null)
                    {
                        string[] listPara = query.Split(' ');
                        int i = 0;
                        foreach (string item in listPara)
                        {
                            if (item.Contains('@'))
                            {
                                string cleanItem = item.Trim();
                                while (cleanItem.Length > 0 && (cleanItem.EndsWith(",") || cleanItem.EndsWith(")") || cleanItem.EndsWith(";")))
                                {
                                    cleanItem = cleanItem.Substring(0, cleanItem.Length - 1);
                                }
                                int atIndex = cleanItem.IndexOf('@');
                                if (atIndex >= 0)
                                {
                                    cleanItem = cleanItem.Substring(atIndex);
                                }
                                if (!command.Parameters.Contains(cleanItem) && i < parameter.Length)
                                {
                                    command.Parameters.AddWithValue(cleanItem, parameter[i] ?? DBNull.Value);
                                    i++;
                                }
                            }
                        }
                    }
                    data = command.ExecuteNonQuery();
                }
            }
            return data;
        }

        public object? ExecuteScalar(string query, object[]? parameter = null)
        {
            object? data = null;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (parameter != null)
                    {
                        string[] listPara = query.Split(' ');
                        int i = 0;
                        foreach (string item in listPara)
                        {
                            if (item.Contains('@'))
                            {
                                string cleanItem = item.Trim();
                                while (cleanItem.Length > 0 && (cleanItem.EndsWith(",") || cleanItem.EndsWith(")") || cleanItem.EndsWith(";")))
                                {
                                    cleanItem = cleanItem.Substring(0, cleanItem.Length - 1);
                                }
                                int atIndex = cleanItem.IndexOf('@');
                                if (atIndex >= 0)
                                {
                                    cleanItem = cleanItem.Substring(atIndex);
                                }
                                if (!command.Parameters.Contains(cleanItem) && i < parameter.Length)
                                {
                                    command.Parameters.AddWithValue(cleanItem, parameter[i] ?? DBNull.Value);
                                    i++;
                                }
                            }
                        }
                    }
                    data = command.ExecuteScalar();
                }
            }
            return data;
        }
    }
}
