
namespace ContractsV4._0
{
    partial class SelectForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.contractsV4DataSet = new ContractsV4._0.ContractsV4DataSet();
            this.contractsV4DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.connnectionLabel = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.contractsV4DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractsV4DataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "File";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // contractsV4DataSet
            // 
            this.contractsV4DataSet.DataSetName = "ContractsV4DataSet";
            this.contractsV4DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contractsV4DataSetBindingSource
            // 
            this.contractsV4DataSetBindingSource.DataSource = this.contractsV4DataSet;
            this.contractsV4DataSetBindingSource.Position = 0;
            // 
            // connnectionLabel
            // 
            this.connnectionLabel.AutoSize = true;
            this.connnectionLabel.ForeColor = System.Drawing.Color.Red;
            this.connnectionLabel.Location = new System.Drawing.Point(66, 9);
            this.connnectionLabel.Name = "connnectionLabel";
            this.connnectionLabel.Size = new System.Drawing.Size(180, 13);
            this.connnectionLabel.TabIndex = 28;
            this.connnectionLabel.Text = "Соединение с базой установлено!";
            this.connnectionLabel.Visible = false;
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 25);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(800, 425);
            this.listView1.TabIndex = 29;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // SelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.connnectionLabel);
            this.Controls.Add(this.label1);
            this.Name = "SelectForm";
            this.Text = "Выборка";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SelectForm_FormClosing);
            this.Load += new System.EventHandler(this.SelectForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.contractsV4DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractsV4DataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource contractsV4DataSetBindingSource;
        private ContractsV4DataSet contractsV4DataSet;
        private System.Windows.Forms.Label connnectionLabel;
        private System.Windows.Forms.ListView listView1;
    }
}