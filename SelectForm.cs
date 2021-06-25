using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace ContractsV4._0
{
    public partial class SelectForm : Form
    {
        public SelectForm()
        {
            InitializeComponent();
        }

        private async void SelectForm_Load(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ContractsV4"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            await sqlConnection.OpenAsync();
            if (sqlConnection.State == ConnectionState.Open)
                connnectionLabel.Visible = true;
        
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.View = View.Details;
    
            listView1.Columns.Add("Номер в базе");
            listView1.Columns.Add("Номер");
            listView1.Columns.Add("Сумма");
            listView1.Columns.Add("Дата");
            listView1.Columns.Add("Платеж");
            listView1.Columns.Add("Дата платежа");
            listView1.Columns.Add("Поставщик");
            listView1.Columns.Add("КВР");
            listView1.Columns.Add("44ФЗ");
            listView1.Columns.Add("Дата начала");
            listView1.Columns.Add("Дата окончания");
            listView1.Columns.Add("Комментарий");

            await LoadContractsAsync(sqlConnection);

            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                sqlConnection.Close();
        }

        private async Task LoadContractsAsync(SqlConnection sqlConnection) // Select
        {
            SqlDataReader sqlReader = null;
            SqlCommand commands = new SqlCommand("Select * from [Contracts]", sqlConnection);

            try
            {
                sqlReader = await commands.ExecuteReaderAsync();

                while (await sqlReader.ReadAsync())
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        Convert.ToString(sqlReader["Id"]),
                        Convert.ToString(sqlReader["numContracts"]),
                        Convert.ToString(sqlReader["sumContracts"]),
                        Convert.ToString(sqlReader["dateContracts"]),
                        Convert.ToString(sqlReader["paymentContracts"]),
                        Convert.ToString(sqlReader["paymentDateContracts"]),
                        Convert.ToString(sqlReader["partnerContracts"]),
                        Convert.ToString(sqlReader["codeKVRContracts"]),
                        Convert.ToString(sqlReader["pointFZ44Contracts"]),
                        Convert.ToString(sqlReader["dateStartContracts"]),
                        Convert.ToString(sqlReader["dateFinishContracts"]),
                        Convert.ToString(sqlReader["noticeContracts"]),

                    });
                    listView1.Items.Add(item);
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlReader != null)
                    sqlReader.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SelectForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
              //  sqlConnection.Close();
        }
    }
}
