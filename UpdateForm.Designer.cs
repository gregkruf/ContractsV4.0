
namespace ContractsV4._0
{
    partial class UpdateForm
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
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.cbSuppliers = new System.Windows.Forms.ComboBox();
            this.cbFZ44 = new System.Windows.Forms.ComboBox();
            this.cbCodeKVR = new System.Windows.Forms.ComboBox();
            this.labelContractAdded = new System.Windows.Forms.Label();
            this.pickerDateFinishContr = new System.Windows.Forms.DateTimePicker();
            this.pickerDateStartContr = new System.Windows.Forms.DateTimePicker();
            this.pickerDatePaymContr = new System.Windows.Forms.DateTimePicker();
            this.pickerDateContr = new System.Windows.Forms.DateTimePicker();
            this.butInsertContracts = new System.Windows.Forms.Button();
            this.tboxNoticeContr = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tboxPaymentContr = new System.Windows.Forms.TextBox();
            this.tboxSumContr = new System.Windows.Forms.TextBox();
            this.tboxNumContr = new System.Windows.Forms.TextBox();
            this.suppliersDataSet = new ContractsV4._0.SuppliersDataSet();
            this.suppliersDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sUPPLIERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sUPPLIERSTableAdapter = new ContractsV4._0.SuppliersDataSetTableAdapters.SUPPLIERSTableAdapter();
            this.dataFromKVR = new ContractsV4._0.DataFromKVR();
            this.kVRBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kVRTableAdapter = new ContractsV4._0.DataFromKVRTableAdapters.KVRTableAdapter();
            this.fZ44DataSet = new ContractsV4._0.FZ44DataSet();
            this.fZBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._44FZTableAdapter = new ContractsV4._0.FZ44DataSetTableAdapters._44FZTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUPPLIERSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataFromKVR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kVRBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fZ44DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fZBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(164, 268);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(15, 14);
            this.checkBox4.TabIndex = 64;
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(164, 241);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(15, 14);
            this.checkBox3.TabIndex = 63;
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(164, 86);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 62;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(164, 167);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 61;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // cbSuppliers
            // 
            this.cbSuppliers.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbSuppliers.DataSource = this.sUPPLIERSBindingSource;
            this.cbSuppliers.DisplayMember = "NameSupp";
            this.cbSuppliers.FormattingEnabled = true;
            this.cbSuppliers.Location = new System.Drawing.Point(183, 109);
            this.cbSuppliers.Name = "cbSuppliers";
            this.cbSuppliers.Size = new System.Drawing.Size(121, 21);
            this.cbSuppliers.TabIndex = 60;
            this.cbSuppliers.ValueMember = "Id";
            // 
            // cbFZ44
            // 
            this.cbFZ44.DataSource = this.fZBindingSource;
            this.cbFZ44.DisplayMember = "POINT44FZ";
            this.cbFZ44.FormattingEnabled = true;
            this.cbFZ44.Location = new System.Drawing.Point(186, 213);
            this.cbFZ44.Name = "cbFZ44";
            this.cbFZ44.Size = new System.Drawing.Size(121, 21);
            this.cbFZ44.TabIndex = 59;
            this.cbFZ44.ValueMember = "Id";
            // 
            // cbCodeKVR
            // 
            this.cbCodeKVR.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbCodeKVR.DataSource = this.kVRBindingSource;
            this.cbCodeKVR.DisplayMember = "FULLNAMEKVR";
            this.cbCodeKVR.FormattingEnabled = true;
            this.cbCodeKVR.Location = new System.Drawing.Point(186, 187);
            this.cbCodeKVR.Name = "cbCodeKVR";
            this.cbCodeKVR.Size = new System.Drawing.Size(121, 21);
            this.cbCodeKVR.TabIndex = 58;
            this.cbCodeKVR.ValueMember = "Id";
            // 
            // labelContractAdded
            // 
            this.labelContractAdded.AutoSize = true;
            this.labelContractAdded.ForeColor = System.Drawing.Color.Red;
            this.labelContractAdded.Location = new System.Drawing.Point(12, 357);
            this.labelContractAdded.Name = "labelContractAdded";
            this.labelContractAdded.Size = new System.Drawing.Size(101, 13);
            this.labelContractAdded.TabIndex = 57;
            this.labelContractAdded.Text = "Контракт изменен";
            this.labelContractAdded.Visible = false;
            // 
            // pickerDateFinishContr
            // 
            this.pickerDateFinishContr.Location = new System.Drawing.Point(185, 265);
            this.pickerDateFinishContr.Name = "pickerDateFinishContr";
            this.pickerDateFinishContr.Size = new System.Drawing.Size(122, 20);
            this.pickerDateFinishContr.TabIndex = 55;
            // 
            // pickerDateStartContr
            // 
            this.pickerDateStartContr.Location = new System.Drawing.Point(185, 239);
            this.pickerDateStartContr.Name = "pickerDateStartContr";
            this.pickerDateStartContr.Size = new System.Drawing.Size(122, 20);
            this.pickerDateStartContr.TabIndex = 54;
            // 
            // pickerDatePaymContr
            // 
            this.pickerDatePaymContr.Location = new System.Drawing.Point(185, 161);
            this.pickerDatePaymContr.Name = "pickerDatePaymContr";
            this.pickerDatePaymContr.Size = new System.Drawing.Size(122, 20);
            this.pickerDatePaymContr.TabIndex = 53;
            // 
            // pickerDateContr
            // 
            this.pickerDateContr.Location = new System.Drawing.Point(185, 83);
            this.pickerDateContr.Name = "pickerDateContr";
            this.pickerDateContr.Size = new System.Drawing.Size(122, 20);
            this.pickerDateContr.TabIndex = 52;
            // 
            // butInsertContracts
            // 
            this.butInsertContracts.Location = new System.Drawing.Point(184, 353);
            this.butInsertContracts.Name = "butInsertContracts";
            this.butInsertContracts.Size = new System.Drawing.Size(120, 37);
            this.butInsertContracts.TabIndex = 51;
            this.butInsertContracts.Text = "Сохранить";
            this.butInsertContracts.UseVisualStyleBackColor = true;
            this.butInsertContracts.Click += new System.EventHandler(this.butInsertContracts_Click_1);
            // 
            // tboxNoticeContr
            // 
            this.tboxNoticeContr.Location = new System.Drawing.Point(184, 291);
            this.tboxNoticeContr.MaximumSize = new System.Drawing.Size(250, 50);
            this.tboxNoticeContr.Multiline = true;
            this.tboxNoticeContr.Name = "tboxNoticeContr";
            this.tboxNoticeContr.Size = new System.Drawing.Size(123, 50);
            this.tboxNoticeContr.TabIndex = 50;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 294);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 13);
            this.label11.TabIndex = 49;
            this.label11.Text = "Комментарий";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 268);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 13);
            this.label9.TabIndex = 48;
            this.label9.Text = "Дата окончания действия";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 242);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 13);
            this.label10.TabIndex = 47;
            this.label10.Text = "Дата начала действия";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "Пункт 44ФЗ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 45;
            this.label6.Text = "Код КВР";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 44;
            this.label7.Text = "Дата оплаты";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 43;
            this.label8.Text = "Сумма оплаты";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Контрагент";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Дата контракта";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Сумма контракта";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Номер контракта";
            // 
            // tboxPaymentContr
            // 
            this.tboxPaymentContr.Location = new System.Drawing.Point(184, 135);
            this.tboxPaymentContr.Name = "tboxPaymentContr";
            this.tboxPaymentContr.Size = new System.Drawing.Size(123, 20);
            this.tboxPaymentContr.TabIndex = 38;
            // 
            // tboxSumContr
            // 
            this.tboxSumContr.Location = new System.Drawing.Point(184, 57);
            this.tboxSumContr.Name = "tboxSumContr";
            this.tboxSumContr.Size = new System.Drawing.Size(123, 20);
            this.tboxSumContr.TabIndex = 37;
            // 
            // tboxNumContr
            // 
            this.tboxNumContr.Location = new System.Drawing.Point(184, 31);
            this.tboxNumContr.Name = "tboxNumContr";
            this.tboxNumContr.Size = new System.Drawing.Size(123, 20);
            this.tboxNumContr.TabIndex = 36;
            // 
            // suppliersDataSet
            // 
            this.suppliersDataSet.DataSetName = "SuppliersDataSet";
            this.suppliersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // suppliersDataSetBindingSource
            // 
            this.suppliersDataSetBindingSource.DataSource = this.suppliersDataSet;
            this.suppliersDataSetBindingSource.Position = 0;
            // 
            // sUPPLIERSBindingSource
            // 
            this.sUPPLIERSBindingSource.DataMember = "SUPPLIERS";
            this.sUPPLIERSBindingSource.DataSource = this.suppliersDataSet;
            // 
            // sUPPLIERSTableAdapter
            // 
            this.sUPPLIERSTableAdapter.ClearBeforeFill = true;
            // 
            // dataFromKVR
            // 
            this.dataFromKVR.DataSetName = "DataFromKVR";
            this.dataFromKVR.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kVRBindingSource
            // 
            this.kVRBindingSource.DataMember = "KVR";
            this.kVRBindingSource.DataSource = this.dataFromKVR;
            // 
            // kVRTableAdapter
            // 
            this.kVRTableAdapter.ClearBeforeFill = true;
            // 
            // fZ44DataSet
            // 
            this.fZ44DataSet.DataSetName = "FZ44DataSet";
            this.fZ44DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fZBindingSource
            // 
            this.fZBindingSource.DataMember = "44FZ";
            this.fZBindingSource.DataSource = this.fZ44DataSet;
            // 
            // _44FZTableAdapter
            // 
            this._44FZTableAdapter.ClearBeforeFill = true;
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 392);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.cbSuppliers);
            this.Controls.Add(this.cbFZ44);
            this.Controls.Add(this.cbCodeKVR);
            this.Controls.Add(this.labelContractAdded);
            this.Controls.Add(this.pickerDateFinishContr);
            this.Controls.Add(this.pickerDateStartContr);
            this.Controls.Add(this.pickerDatePaymContr);
            this.Controls.Add(this.pickerDateContr);
            this.Controls.Add(this.butInsertContracts);
            this.Controls.Add(this.tboxNoticeContr);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tboxPaymentContr);
            this.Controls.Add(this.tboxSumContr);
            this.Controls.Add(this.tboxNumContr);
            this.Name = "UpdateForm";
            this.Text = "Изменение контракта...";
            this.Load += new System.EventHandler(this.UpdateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.suppliersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUPPLIERSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataFromKVR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kVRBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fZ44DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fZBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox cbSuppliers;
        private System.Windows.Forms.ComboBox cbFZ44;
        private System.Windows.Forms.ComboBox cbCodeKVR;
        private System.Windows.Forms.Label labelContractAdded;
        private System.Windows.Forms.DateTimePicker pickerDateFinishContr;
        private System.Windows.Forms.DateTimePicker pickerDateStartContr;
        private System.Windows.Forms.DateTimePicker pickerDatePaymContr;
        private System.Windows.Forms.DateTimePicker pickerDateContr;
        private System.Windows.Forms.Button butInsertContracts;
        private System.Windows.Forms.TextBox tboxNoticeContr;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxPaymentContr;
        private System.Windows.Forms.TextBox tboxSumContr;
        private System.Windows.Forms.TextBox tboxNumContr;
        private System.Windows.Forms.BindingSource suppliersDataSetBindingSource;
        private SuppliersDataSet suppliersDataSet;
        private System.Windows.Forms.BindingSource sUPPLIERSBindingSource;
        private SuppliersDataSetTableAdapters.SUPPLIERSTableAdapter sUPPLIERSTableAdapter;
        private DataFromKVR dataFromKVR;
        private System.Windows.Forms.BindingSource kVRBindingSource;
        private DataFromKVRTableAdapters.KVRTableAdapter kVRTableAdapter;
        private FZ44DataSet fZ44DataSet;
        private System.Windows.Forms.BindingSource fZBindingSource;
        private FZ44DataSetTableAdapters._44FZTableAdapter _44FZTableAdapter;
    }
}