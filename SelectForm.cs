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
        private SqlConnection sqlConnection = null;
        public SelectForm()
        {
            InitializeComponent();
        }

        private async void SelectForm_Load(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ContractsV4"].ConnectionString;
            sqlConnection = new SqlConnection(connectionString);

            await sqlConnection.OpenAsync();
            if (sqlConnection.State == ConnectionState.Open)
                toolStripLabel1.Visible = true;
        
            lViewSelect.GridLines = true;
            lViewSelect.FullRowSelect = true;
            lViewSelect.View = View.Details;

            lViewSelect.Columns.Add("Id в базе");
            lViewSelect.Columns.Add("Номер контракта");
            lViewSelect.Columns.Add("Сумма");
            lViewSelect.Columns.Add("Дата");
            lViewSelect.Columns.Add("Платеж");
            lViewSelect.Columns.Add("Дата платежа");
            lViewSelect.Columns.Add("Поставщик");
            lViewSelect.Columns.Add("КВР");
            lViewSelect.Columns.Add("44ФЗ");
            lViewSelect.Columns.Add("Дата начала");
            lViewSelect.Columns.Add("Дата окончания");
            lViewSelect.Columns.Add("Комментарий");

            await LoadContractsAsync();

        }

        private async Task LoadContractsAsync() // Select
        {
            SqlDataReader sqlReader = null;
            SqlCommand selectCommands = new SqlCommand("Select * from [Contracts]", sqlConnection);

            try
            {
                sqlReader = await selectCommands.ExecuteReaderAsync();

                while (await sqlReader.ReadAsync())
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        Convert.ToString(sqlReader["Id"]),
                        Convert.ToString(sqlReader["numContracts"]),
                        Convert.ToString(sqlReader["sumContracts"]),
                        Convert.ToString(Convert.ToDateTime(sqlReader["dateContracts"]).ToShortDateString()),
                        Convert.ToString(sqlReader["paymentContracts"]),
                        Convert.ToString(Convert.ToDateTime(sqlReader["paymentDateContracts"]).ToShortDateString()),
                        Convert.ToString(sqlReader["partnerContracts"]),
                        Convert.ToString(sqlReader["codeKVRContracts"]),
                        Convert.ToString(sqlReader["pointFZ44Contracts"]),
                        Convert.ToString(Convert.ToDateTime(sqlReader["dateStartContracts"]).ToShortDateString()),
                        Convert.ToString(Convert.ToDateTime(sqlReader["dateFinishContracts"]).ToShortDateString()),
                        Convert.ToString(sqlReader["noticeContracts"]),

                    });
                    lViewSelect.Items.Add(item);
                    
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
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                sqlConnection.Close();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private async void F5button_Click(object sender, EventArgs e)
        {
            lViewSelect.Items.Clear();
            await LoadContractsAsync();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            InsertForm insertForm = new InsertForm(sqlConnection);
            insertForm.Show();
        }
    }
}
