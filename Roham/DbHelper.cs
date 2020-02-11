﻿using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;

namespace Roham
{
    public class DbHelper
    {
        public static SqlConnection GetConnection()
        {
            var sqlConnection =
                new SqlConnection(ConfigurationManager.ConnectionStrings["RohamDbConnection"].ConnectionString);
            sqlConnection.Open();
            return sqlConnection;
        }

        public static DataSet LoadDataSet(string commandName)
        {
            using (SqlConnection connection = GetConnection())
            {
                SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = commandName;
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;

            }
        }

    public static string GregorianToShamsi(DateTime gregorian)
        {
            try
            {
                PersianCalendar pc = new PersianCalendar();
                int pcYear = pc.GetYear(gregorian);
                int pcMonth = pc.GetMonth(gregorian);
                int pcDay = pc.GetDayOfMonth(gregorian);
                string convertedDate = string.Format("{0}/{1}/{2}", pcYear, pcMonth, pcDay);
                return convertedDate;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return "operation caused error";
            }
        }
    }
}
