using Microsoft.Reporting.WinForms;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportWiew
{
    public class Metodos : DBContext
    {
        public void reportone(string nombres, ReportViewer rView)
        {
            try
            {
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
                DataSet clientds = new DataSet();
                DataTable clientsTable = new DataTable();
                Command.Connection = connectionBD;
                Command.CommandText = "getProveedorbyFilter";
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.AddWithValue("@nombrex", nombres);
                dataAdapter.SelectCommand = Command;
                dataAdapter.Fill(clientsTable);

                rView.LocalReport.DataSources.Clear();
                ReportDataSource rp = new ReportDataSource("Proveedor", clientsTable);

                rView.LocalReport.DataSources.Add(rp);
                rView.RefreshReport();

                Command.Parameters.Clear();
                connectionBD.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("" + ex);
                Command.Parameters.Clear();
                Reader.Close();
                connectionBD.Close();
                
            }
        }
    }
}
