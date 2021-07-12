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
        public UpdateForm(SqlConnection connection)
        {
            InitializeComponent();
            sqlConnection = connection;
        }
        private void UpdateForm_Load(object sender, EventArgs e)
        {

        }

        private void butInsertContracts_Click(object sender, EventArgs e)
        {

        }

    }
}
