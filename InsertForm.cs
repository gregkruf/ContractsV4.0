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
    public partial class InsertForm : Form
    {
        private SqlConnection sqlConnection = null;

        public InsertForm(SqlConnection connection)
        {
            InitializeComponent();
            sqlConnection = connection;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "suppliersDataSet.SUPPLIERS". При необходимости она может быть перемещена или удалена.
            this.sUPPLIERSTableAdapter.Fill(this.suppliersDataSet.SUPPLIERS);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fZ44DataSet._44FZ". При необходимости она может быть перемещена или удалена.
            this._44FZTableAdapter.Fill(this.fZ44DataSet._44FZ);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataFromKVR.KVR". При необходимости она может быть перемещена или удалена.
            this.kVRTableAdapter1.Fill(this.dataFromKVR.KVR);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "contractsV4DataSet1.KVR". При необходимости она может быть перемещена или удалена.
            this.kVRTableAdapter.Fill(this.contractsV4DataSet1.KVR);
            if (sqlConnection.State == ConnectionState.Open)
                connnectionLabel.Visible = true;
        }

        private async void butInsertContracts_Click(object sender, EventArgs e)
        {

            SqlCommand command = new SqlCommand("INSERT INTO Contracts (numContracts, sumContracts, dateContracts, " + 
            "paymentContracts, partnerContracts, paymentDateContracts, codeKVRContracts, " + 
            "pointFZ44Contracts, dateStartContracts, dateFinishContracts, noticeContracts) " +
            "VALUES (@numContracts, @sumContracts, @dateContracts, " + 
            "@paymentContracts, @partnerContracts, @paymentDateContracts, @codeKVRContracts, " +
            "@pointFZ44Contracts, @dateStartContracts, @dateFinishContracts, @noticeContracts)", sqlConnection);

            try
            {

                command.Parameters.AddWithValue("@numContracts", tboxNumContr.Text);

                if (tboxSumContr.Text != "")
                    command.Parameters.AddWithValue("@sumContracts", Convert.ToDouble(tboxSumContr.Text));
                else
                    command.Parameters.AddWithValue("@sumContracts", Convert.DBNull);
                if (pickerDateContr.Value != null)
                    command.Parameters.AddWithValue("@dateContracts", Convert.ToDateTime(pickerDateContr.Value));
                else
                    command.Parameters.AddWithValue("@dateContracts", Convert.DBNull);
                if (tboxPaymentContr.Text != "")
                    command.Parameters.AddWithValue("@paymentContracts", Convert.ToDouble(tboxPaymentContr.Text));
                else
                    command.Parameters.AddWithValue("@paymentContracts", Convert.DBNull);
                if (cbSuppliers.Text != "")
                    command.Parameters.AddWithValue("@partnerContracts", cbSuppliers.SelectedValue);
                else
                    command.Parameters.AddWithValue("@partnerContracts", Convert.DBNull);
                if (pickerDatePaymContr.Value != null)
                    command.Parameters.AddWithValue("@paymentDateContracts", Convert.ToDateTime(pickerDatePaymContr.Value));
                else
                    command.Parameters.AddWithValue("@paymentDateContracts", Convert.DBNull);
                if (cbCodeKVR.Text != "")
                    command.Parameters.AddWithValue("@codeKVRContracts", Convert.ToInt32(cbCodeKVR.SelectedValue));
                else
                    command.Parameters.AddWithValue("@codeKVRContracts", Convert.DBNull);
                if (cbFZ44.Text != "")
                    command.Parameters.AddWithValue("@pointFZ44Contracts", Convert.ToInt32(cbFZ44.SelectedValue));
                else
                    command.Parameters.AddWithValue("@pointFZ44Contracts", Convert.DBNull);
                if (pickerDateStartContr.Value != null)
                    command.Parameters.AddWithValue("@dateStartContracts", Convert.ToDateTime(pickerDateStartContr.Value));
                else
                    command.Parameters.AddWithValue("@dateStartContracts", Convert.DBNull);
                if (pickerDateFinishContr.Value != null)
                    command.Parameters.AddWithValue("@dateFinishContracts", Convert.ToDateTime(pickerDateFinishContr.Value));
                else
                    command.Parameters.AddWithValue("@dateFinishContracts", Convert.DBNull);
                command.Parameters.AddWithValue("@noticeContracts", tboxNoticeContr.Text);
                labelContractAdded.Visible = true;

                await command.ExecuteNonQueryAsync();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Thread.Sleep(500);

                
            }
                Close();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tboxSumContr_TextChanged(object sender, EventArgs e)
        {
            bool flag = true;
            string str = tboxSumContr.Text;          //"1sd21,436(&^*^ff,2 a,2,b2";
            string result = null;
            foreach (char each in str)
            {
                if (Char.IsDigit(each))
                    result += each;
                if (each == ',' && flag)
                {
                    flag = false;
                    result += each;
                }
            }
            if (result != null)
            {
                tboxSumContr.Text = result;
                tboxSumContr.SelectionStart = result.Length;
            }
        }

        private void tboxPaymentContr_TextChanged(object sender, EventArgs e)
        {
            bool flag = true;
            string str = tboxPaymentContr.Text; //"1sd21,436(&^*^ff,2 a,2,b2";
            string result = null;
            foreach (char each in str)
            {
                if (Char.IsDigit(each))
                    result += each;
                if (each == ',' && flag)
                {
                    flag = false;
                    result += each;
                }
            }
            if (result != null)
            { 
                tboxPaymentContr.Text = result;
                tboxPaymentContr.SelectionStart = result.Length; 
            }


        }

        private void tboxCodeKVRContr_TextChanged(object sender, EventArgs e)
        {

        }

        private void kVRBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void tboxPOint44fzContr_TextChanged(object sender, EventArgs e)
        {

        }
    }



   
    
}
