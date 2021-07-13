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
            DoCheck();

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
                    if (Convert.ToString(sqlReader["dateContracts"]) != "")
                    {
                        pickerDateContr.Value = Convert.ToDateTime(sqlReader["dateContracts"]);
                        checkBox2.Checked = true;
                    }
                    else
                        pickerDateContr.Enabled = checkBox2.Checked;
                    Convert.ToString(sqlReader["paymentContracts"]);
                    if (Convert.ToString(sqlReader["paymentDateContracts"]) != "")
                    {
                        pickerDatePaymContr.Value = Convert.ToDateTime(sqlReader["paymentDateContracts"]);
                        checkBox1.Checked = true;
                    }
                    else
                        pickerDatePaymContr.Enabled = checkBox1.Checked;

                    if (Convert.ToString(sqlReader["dateStartContracts"]) != "")
                    {
                        pickerDateStartContr.Value = Convert.ToDateTime(sqlReader["dateStartContracts"]);
                        checkBox3.Checked = true;
                    }
                    else
                        pickerDateStartContr.Enabled = checkBox3.Checked;
                    if (Convert.ToString(sqlReader["dateFinishContracts"]) != "")
                    {
                        pickerDateFinishContr.Value = Convert.ToDateTime(sqlReader["dateFinishContracts"]);
                        checkBox4.Checked = true;
                    }
                    else
                        pickerDateFinishContr.Enabled = checkBox4.Checked;

                    tboxNoticeContr.Text = Convert.ToString(sqlReader["noticeContracts"]);
                    cbSuppliers.SelectedValue = Convert.ToInt32(sqlReader["partnerContracts"]);
                    cbFZ44.SelectedValue = Convert.ToInt32(sqlReader["pointFZ44Contracts"]);
                    cbCodeKVR.SelectedValue = Convert.ToInt32(sqlReader["codeKVRContracts"]);

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
            SqlCommand updateContractsCommand2 = new SqlCommand("Update [Contracts] Set  [numContracts] = @num, [sumContracts] = @sum Where [Id] = @id", sqlConnection);
            
            SqlCommand updateContractsCommand = new SqlCommand("Update Contracts Set [numContracts] = @num, [sumContracts] = @sum, " +
            "[dateContracts] = @date, [paymentContracts] = @payment, [partnerContracts] = @partner, " +
            "[paymentDateContracts] = @paymentD, [codeKVRContracts] = @KVR, " +
            "[pointFZ44Contracts] = @FZ44, [dateStartContracts] = @dateS, [dateFinishContracts] = @dateF, " +
            "[noticeContracts] = @note Where [Id] = @id", sqlConnection);

            updateContractsCommand.Parameters.AddWithValue("id", id);
            updateContractsCommand.Parameters.AddWithValue("num", tboxNumContr.Text);
            if (tboxSumContr.Text != "")
                updateContractsCommand.Parameters.AddWithValue("@sum", Convert.ToDouble(tboxSumContr.Text));
            else
                updateContractsCommand.Parameters.AddWithValue("@sum", Convert.DBNull);
            if (checkBox2.Checked == true)
                updateContractsCommand.Parameters.AddWithValue("@date", Convert.ToDateTime(pickerDateContr.Value));
            else
                updateContractsCommand.Parameters.AddWithValue("@date", Convert.DBNull);
            if (tboxPaymentContr.Text != "")
                updateContractsCommand.Parameters.AddWithValue("@payment", Convert.ToDouble(tboxPaymentContr.Text));
            else
                updateContractsCommand.Parameters.AddWithValue("@payment", Convert.DBNull);
            updateContractsCommand.Parameters.AddWithValue("@partner", cbSuppliers.SelectedValue);

            if (checkBox1.Checked == true)
                updateContractsCommand.Parameters.AddWithValue("@paymentD", Convert.ToDateTime(pickerDatePaymContr.Value));
            else
                updateContractsCommand.Parameters.AddWithValue("@paymentD", Convert.DBNull);

            updateContractsCommand.Parameters.AddWithValue("@KVR", Convert.ToInt32(cbCodeKVR.SelectedValue));

            updateContractsCommand.Parameters.AddWithValue("@FZ44", Convert.ToInt32(cbFZ44.SelectedValue));

            if (checkBox3.Checked == true)
                updateContractsCommand.Parameters.AddWithValue("@dateS", Convert.ToDateTime(pickerDateStartContr.Value));
            else updateContractsCommand.Parameters.AddWithValue("@dateS", Convert.DBNull);

            if (checkBox4.Checked == true)
                updateContractsCommand.Parameters.AddWithValue("@dateF", Convert.ToDateTime(pickerDateFinishContr.Value));
            else updateContractsCommand.Parameters.AddWithValue("@dateF", Convert.DBNull);

            updateContractsCommand.Parameters.AddWithValue("@note", tboxNoticeContr.Text);

            try
            {
                await updateContractsCommand.ExecuteNonQueryAsync();
                labelContractAdded.Visible = true;
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
        
        private void DoCheck()
        {
            pickerDatePaymContr.Enabled = checkBox1.Checked;
            pickerDateContr.Enabled = checkBox2.Checked;
            pickerDateStartContr.Enabled = checkBox3.Checked;
            pickerDateFinishContr.Enabled = checkBox4.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            DoCheck();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            DoCheck();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            DoCheck();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            DoCheck();
        }
    }
}
