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

namespace ContractsV4._0
{
    public partial class Form1 : Form
    {
        private SqlConnection sqlConnection = null;

        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ContractsV4"].ConnectionString);
            await sqlConnection.OpenAsync();
            if (sqlConnection.State == ConnectionState.Open)
                connnectionLabel.Visible = true;


        }

        private void butInsertContracts_Click(object sender, EventArgs e)
        {

            SqlCommand command = new SqlCommand("INSERT INTO Contracts (numContracts, sumContracts, dateContracts, " + 
            "paymentContracts, partnerContracts, paymentDateContracts, codeKVRContracts, " + 
            "pointFZ44Contracts, dateStartContracts, dateFinishContracts, noticeContracts) " + 
            "VALUES (@numContracts, @sumContracts, @dateContracts, " + 
            "@paymentContracts, @partnerContracts, @paymentDateContracts, @codeKVRContracts, " +
            "@pointFZ44Contracts, @dateStartContracts, @dateFinishContracts, @noticeContracts)", sqlConnection);
            SqlCommand command2 = new SqlCommand("Insert into Contracts (numContracts, sumContracts, dateContracts) VALUES (@numContracts, @sumContracts, @dateContracts)", sqlConnection);

            string allowedchar = ",0123456789";

            if (!(tboxPaymentContr.Text.ToString().Contains(allowedchar)) || 
                tboxSumContr.Text.ToString().Contains(allowedchar))
            {
                labelContractAdded.Text = "Контракт не добавлен";
                labelContractAdded.Show();
                labelErrorSumContr.Text = "Заменить точку на запятую";
                labelErrorSumContr.Show();
                labelErrorSumPaym.Text = "Заменить точку на запятую";
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
                command.ExecuteNonQuery();
                labelContractAdded.Text = "Контракт добавлен!";
                labelErrorSumPaym.Hide();
                labelErrorSumContr.Hide();
                //System.Threading.Thread.Sleep(500);
            }
            //command2.ExecuteNonQuery();
            //System.Threading.Thread.Sleep(1000);
            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SelectForm sf = new SelectForm();
            sf.ShowDialog();
        }
    }
}
