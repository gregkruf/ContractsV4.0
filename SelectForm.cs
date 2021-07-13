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
        
            lViewSelect.GridLines = true; // создаю заголовки таблицы
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

            await LoadContractsAsync(); // Выполняю запрос на получение данных из БД 

        }

        public async Task LoadContractsAsync() // Select
        {
            SqlDataReader sqlReader = null;
            SqlCommand selectCommands = new SqlCommand("Select * from [Contracts] c LEFT JOIN [KVR] kvr ON c.codeKVRContracts = kvr.Id lEFT JOIN [44FZ] fz ON c.pointFZ44Contracts = fz.Id LEFT JOIN SUPPLIERS s ON c.partnerContracts = s.Id", sqlConnection);

            try
            {
                sqlReader = await selectCommands.ExecuteReaderAsync();
                double sumAllContr = 0;
                double sumAllPayContr = 0;

                while (await sqlReader.ReadAsync())
                {                                                       // заполнение данными из строки БД в ListView
                    ListViewItem item = new ListViewItem(new string[] 
                    {
                            Convert.ToString(sqlReader["Id"]),
                            Convert.ToString(sqlReader["numContracts"]),
                            Convert.ToString(sqlReader["sumContracts"]),
                            Convert.ToString(sqlReader["dateContracts"]),
                            Convert.ToString(sqlReader["paymentContracts"]),
                            Convert.ToString(sqlReader["paymentDateContracts"]),
                            Convert.ToString(sqlReader["NameSupp"]),
                            Convert.ToString(sqlReader["CodeKVR"]),
                            Convert.ToString("п " + sqlReader["point44FZ"]),
                            Convert.ToString(sqlReader["dateStartContracts"]), 
                            Convert.ToString(sqlReader["dateFinishContracts"]),
                            Convert.ToString(sqlReader["noticeContracts"]),

                    });

                    if (item.SubItems[3].Text != "" )  //Дата контракта, обрезается время и выводит в LIstView
                       item.SubItems[3].Text = ((Convert.ToDateTime(item.SubItems[3].Text)).ToShortDateString()).ToString();

                    if (item.SubItems[5].Text != "")//Дата платежа по контракту, обрезается время и выводит в LIstView
                        item.SubItems[5].Text = ((Convert.ToDateTime(item.SubItems[5].Text)).ToShortDateString()).ToString();

                    if (item.SubItems[9].Text != "")//Дата начала действия контракта, обрезается время и выводит в LIstView
                        item.SubItems[9].Text = ((Convert.ToDateTime(item.SubItems[9].Text)).ToShortDateString()).ToString();

                    if (item.SubItems[10].Text != "")//Дата завершения контракта, обрезается время и выводит в LIstView
                        item.SubItems[10].Text = ((Convert.ToDateTime(item.SubItems[10].Text)).ToShortDateString()).ToString();

                    if (item.SubItems[2].Text != "")
                        sumAllContr += Convert.ToDouble(item.SubItems[2].Text); // Суммирую все суммы по контрактам
                    if (item.SubItems[4].Text != "")
                        sumAllPayContr += Convert.ToDouble(item.SubItems[4].Text);

                    lViewSelect.Items.Add(item);
                    
                }
                ListViewItem sum = new ListViewItem(new string[] { "", "ИТОГО:", sumAllContr.ToString(), "", sumAllPayContr.ToString() });
                lViewSelect.Items.Add(sum);  // добавляю итоговую строку в ListView


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
        private void butChange_Click(object sender, EventArgs e)
        {
            if (lViewSelect.SelectedItems.Count > 0)
            {
                UpdateForm updateForm = new UpdateForm(sqlConnection, Convert.ToInt32(lViewSelect.SelectedItems[0].SubItems[0].Text));
                updateForm.Show();
            }
            else
                MessageBox.Show("Выделите элемент...");
        }

        private async void butDelete_Click(object sender, EventArgs e)
        {
            if(lViewSelect.SelectedItems.Count > 0)
            {
                DialogResult res = MessageBox.Show("Вы действительно хотите удалить строку?", "Удаление строки", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                switch (res)
                {
                    case DialogResult.OK:
                        SqlCommand deleteSqlCommand = new SqlCommand("Delete From [Contracts] Where Id = @id", sqlConnection);
                        deleteSqlCommand.Parameters.AddWithValue("id", Convert.ToInt32(lViewSelect.SelectedItems[0].SubItems[0].Text));

                        try
                        {
                            await deleteSqlCommand.ExecuteNonQueryAsync();
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        lViewSelect.Items.Clear();
                        await LoadContractsAsync();
                    break;
                }
            }
            else
                MessageBox.Show("Выделите элемент...");
        }
        private void lViewSelect_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CodeKVRMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void codeKVRToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InsertForm insertForm = new InsertForm(sqlConnection);
            insertForm.Show();
        }

    }
}
