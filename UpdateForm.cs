using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Threading;

namespace ContractsV4._0
{
    public partial class UpdateForm : Form
    {
        private SqlConnection sqlConnection = null;
        private int id;
        public UpdateForm(SqlConnection connection, int Id)
        {
            InitializeComponent();
            sqlConnection = connection;
            this.id = Id;
        }
        private async void UpdateForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fZ44DataSet._44FZ". При необходимости она может быть перемещена или удалена.
            this._44FZTableAdapter.Fill(this.fZ44DataSet._44FZ);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataFromKVR.KVR". При необходимости она может быть перемещена или удалена.
            this.kVRTableAdapter.Fill(this.dataFromKVR.KVR);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "suppliersDataSet.SUPPLIERS". При необходимости она может быть перемещена или удалена.
            this.sUPPLIERSTableAdapter.Fill(this.suppliersDataSet.SUPPLIERS);

            SqlCommand getInfoContracts = new SqlCommand("Select * from [Contracts] Where Id = @Id", sqlConnection);
            getInfoContracts.Parameters.AddWithValue("Id", id);

            SqlDataReader sqlReader = null;

            try
            {
                sqlReader = await getInfoContracts.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    tboxNumContr.Text = Convert.ToString(sqlReader["numContracts"]);
                    tboxSumContr.Text = Convert.ToString(sqlReader["sumContracts"]);
                    
                    /*Convert.ToDateTime(sqlReader["dateContracts"]);
                            Convert.ToString(sqlReader["paymentContracts"]),
                            Convert.ToString(sqlReader["paymentDateContracts"]),
                            Convert.ToString(sqlReader["NameSupp"]),
                            Convert.ToString(sqlReader["CodeKVR"]),
                            Convert.ToString("п " + sqlReader["point44FZ"]),
                            Convert.ToString(sqlReader["dateStartContracts"]), 
                            Convert.ToString(sqlReader["dateFinishContracts"]),
                            Convert.ToString(sqlReader["noticeContracts"]),
                    */
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlReader != null && !sqlReader.IsClosed)
                    sqlReader.Close();
            }

        }


        private async void butInsertContracts_Click_1(object sender, EventArgs e)
        {
            SqlCommand updateContractsCommand = new SqlCommand("Update [Contracts] Set  [numContracts] = @num, [sumContracts] = @sum Where [Id] = @id", sqlConnection);
            updateContractsCommand.Parameters.AddWithValue("id", id);
            updateContractsCommand.Parameters.AddWithValue("num", tboxNumContr.Text);
            updateContractsCommand.Parameters.AddWithValue("sum", Convert.ToDouble(tboxSumContr.Text));

            try
            {
                await updateContractsCommand.ExecuteNonQueryAsync();
                Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

            }
        }
    }
}
