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
            {// здесь ошибка с преобразованием суммы в дабл
            string allowedchar = ",0123456789";

            if ((tboxPaymentContr.Text.ToString().Contains(allowedchar)) ||
                (tboxSumContr.Text.ToString().Contains(allowedchar)))
            {
                labelContractAdded.Text = "Контракт не добавлен";
                labelContractAdded.Show();
                labelErrorSumContr.Text = "Неккоректный ввод";
                labelErrorSumContr.Show();
                labelErrorSumPaym.Text = "Неккоректный ввод";
                labelErrorSumPaym.Show();
            }
            else
            {
                command.Parameters.AddWithValue("@numContracts", tboxNumContr.Text);
                command.Parameters.AddWithValue("@sumContracts", Convert.ToDouble(tboxSumContr.Text));
                command.Parameters.AddWithValue("@dateContracts", Convert.ToDateTime(pickerDateContr.Value));
                command.Parameters.AddWithValue("@paymentContracts", Convert.ToDouble(tboxPaymentContr.Text));
                command.Parameters.AddWithValue("@partnerContracts", Convert.ToInt32(tboxPartnerContr.Text));
                command.Parameters.AddWithValue("@paymentDateContracts", Convert.ToDateTime(pickerDatePaymContr.Value));
                command.Parameters.AddWithValue("@codeKVRContracts", Convert.ToInt32(tboxCodeKVRContr.Text));
                command.Parameters.AddWithValue("@pointFZ44Contracts", Convert.ToInt32(tboxPOint44fzContr.Text));
                command.Parameters.AddWithValue("@dateStartContracts", Convert.ToDateTime(pickerDateStartContr.Value));
                command.Parameters.AddWithValue("@dateFinishContracts", Convert.ToDateTime(pickerDateFinishContr.Value));
                command.Parameters.AddWithValue("@noticeContracts", tboxNoticeContr.Text);
                labelContractAdded.Visible = true;
                labelErrorSumPaym.Hide();
                labelErrorSumContr.Hide();
            
                await command.ExecuteNonQueryAsync();

            }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Thread.Sleep(1000);

                
            }
                Close();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tboxSumContr_TextChanged(object sender, EventArgs e)
        {
            bool flag = true;
            string str = tboxSumContr.Text; //"1sd21,436(&^*^ff,2 a,2,b2";
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
    }



   
    
}
