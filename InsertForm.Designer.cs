﻿namespace ContractsV4._0
{
    partial class InsertForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.sUPPLIERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.suppliersDataSet = new ContractsV4._0.SuppliersDataSet();
            this.fZBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fZ44DataSet = new ContractsV4._0.FZ44DataSet();
            this.kVRBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.dataFromKVR = new ContractsV4._0.DataFromKVR();
            this.kVRBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contractsV4DataSet1 = new ContractsV4._0.ContractsV4DataSet1();
            this.kVRTableAdapter = new ContractsV4._0.ContractsV4DataSet1TableAdapters.KVRTableAdapter();
            this.kVRBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.contractsV4DataSet = new ContractsV4._0.ContractsV4DataSet();
            this.contractsV4DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kVRBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.kVRTableAdapter1 = new ContractsV4._0.DataFromKVRTableAdapters.KVRTableAdapter();
            this._44FZTableAdapter = new ContractsV4._0.FZ44DataSetTableAdapters._44FZTableAdapter();
            this.sUPPLIERSTableAdapter = new ContractsV4._0.SuppliersDataSetTableAdapters.SUPPLIERSTableAdapter();
            this.tboxNumContr = new System.Windows.Forms.TextBox();
            this.tboxSumContr = new System.Windows.Forms.TextBox();
            this.tboxPaymentContr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tboxNoticeContr = new System.Windows.Forms.TextBox();
            this.butInsertContracts = new System.Windows.Forms.Button();
            this.pickerDateContr = new System.Windows.Forms.DateTimePicker();
            this.pickerDatePaymContr = new System.Windows.Forms.DateTimePicker();
            this.pickerDateStartContr = new System.Windows.Forms.DateTimePicker();
            this.pickerDateFinishContr = new System.Windows.Forms.DateTimePicker();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.labelContractAdded = new System.Windows.Forms.Label();
            this.cbCodeKVR = new System.Windows.Forms.ComboBox();
            this.cbFZ44 = new System.Windows.Forms.ComboBox();
            this.cbSuppliers = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sUPPLIERSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fZBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fZ44DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kVRBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataFromKVR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kVRBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractsV4DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kVRBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractsV4DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractsV4DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kVRBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(376, 425);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightGray;
            this.tabPage1.Controls.Add(this.checkBox4);
            this.tabPage1.Controls.Add(this.checkBox3);
            this.tabPage1.Controls.Add(this.checkBox2);
            this.tabPage1.Controls.Add(this.checkBox1);
            this.tabPage1.Controls.Add(this.cbSuppliers);
            this.tabPage1.Controls.Add(this.cbFZ44);
            this.tabPage1.Controls.Add(this.cbCodeKVR);
            this.tabPage1.Controls.Add(this.labelContractAdded);
            this.tabPage1.Controls.Add(this.pickerDateFinishContr);
            this.tabPage1.Controls.Add(this.pickerDateStartContr);
            this.tabPage1.Controls.Add(this.pickerDatePaymContr);
            this.tabPage1.Controls.Add(this.pickerDateContr);
            this.tabPage1.Controls.Add(this.butInsertContracts);
            this.tabPage1.Controls.Add(this.tboxNoticeContr);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.tboxPaymentContr);
            this.tabPage1.Controls.Add(this.tboxSumContr);
            this.tabPage1.Controls.Add(this.tboxNumContr);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(368, 399);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Свойства";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // sUPPLIERSBindingSource
            // 
            this.sUPPLIERSBindingSource.DataMember = "SUPPLIERS";
            this.sUPPLIERSBindingSource.DataSource = this.suppliersDataSet;
            // 
            // suppliersDataSet
            // 
            this.suppliersDataSet.DataSetName = "SuppliersDataSet";
            this.suppliersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fZBindingSource
            // 
            this.fZBindingSource.DataMember = "44FZ";
            this.fZBindingSource.DataSource = this.fZ44DataSet;
            // 
            // fZ44DataSet
            // 
            this.fZ44DataSet.DataSetName = "FZ44DataSet";
            this.fZ44DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kVRBindingSource3
            // 
            this.kVRBindingSource3.DataMember = "KVR";
            this.kVRBindingSource3.DataSource = this.dataFromKVR;
            // 
            // dataFromKVR
            // 
            this.dataFromKVR.DataSetName = "DataFromKVR";
            this.dataFromKVR.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kVRBindingSource
            // 
            this.kVRBindingSource.DataMember = "KVR";
            this.kVRBindingSource.DataSource = this.contractsV4DataSet1;
            this.kVRBindingSource.CurrentChanged += new System.EventHandler(this.kVRBindingSource_CurrentChanged);
            // 
            // contractsV4DataSet1
            // 
            this.contractsV4DataSet1.DataSetName = "ContractsV4DataSet1";
            this.contractsV4DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kVRTableAdapter
            // 
            this.kVRTableAdapter.ClearBeforeFill = true;
            // 
            // kVRBindingSource1
            // 
            this.kVRBindingSource1.DataMember = "KVR";
            this.kVRBindingSource1.DataSource = this.contractsV4DataSet1;
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
            // kVRBindingSource2
            // 
            this.kVRBindingSource2.DataMember = "KVR";
            this.kVRBindingSource2.DataSource = this.dataFromKVR;
            // 
            // kVRTableAdapter1
            // 
            this.kVRTableAdapter1.ClearBeforeFill = true;
            // 
            // _44FZTableAdapter
            // 
            this._44FZTableAdapter.ClearBeforeFill = true;
            // 
            // sUPPLIERSTableAdapter
            // 
            this.sUPPLIERSTableAdapter.ClearBeforeFill = true;
            // 
            // tboxNumContr
            // 
            this.tboxNumContr.Location = new System.Drawing.Point(219, 37);
            this.tboxNumContr.Name = "tboxNumContr";
            this.tboxNumContr.Size = new System.Drawing.Size(123, 20);
            this.tboxNumContr.TabIndex = 0;
            // 
            // tboxSumContr
            // 
            this.tboxSumContr.Location = new System.Drawing.Point(219, 63);
            this.tboxSumContr.Name = "tboxSumContr";
            this.tboxSumContr.Size = new System.Drawing.Size(123, 20);
            this.tboxSumContr.TabIndex = 2;
            this.tboxSumContr.TextChanged += new System.EventHandler(this.tboxSumContr_TextChanged);
            // 
            // tboxPaymentContr
            // 
            this.tboxPaymentContr.Location = new System.Drawing.Point(219, 141);
            this.tboxPaymentContr.Name = "tboxPaymentContr";
            this.tboxPaymentContr.Size = new System.Drawing.Size(123, 20);
            this.tboxPaymentContr.TabIndex = 5;
            this.tboxPaymentContr.TextChanged += new System.EventHandler(this.tboxPaymentContr_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Номер контракта";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Сумма контракта";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Дата контракта";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Контрагент";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(47, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Сумма оплаты";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Дата оплаты";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Код КВР";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Пункт 44ФЗ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(47, 248);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Дата начала действия";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(47, 274);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Дата окончания действия";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(47, 300);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Комментарий";
            // 
            // tboxNoticeContr
            // 
            this.tboxNoticeContr.Location = new System.Drawing.Point(219, 297);
            this.tboxNoticeContr.MaximumSize = new System.Drawing.Size(250, 50);
            this.tboxNoticeContr.Multiline = true;
            this.tboxNoticeContr.Name = "tboxNoticeContr";
            this.tboxNoticeContr.Size = new System.Drawing.Size(123, 50);
            this.tboxNoticeContr.TabIndex = 20;
            // 
            // butInsertContracts
            // 
            this.butInsertContracts.Location = new System.Drawing.Point(219, 359);
            this.butInsertContracts.Name = "butInsertContracts";
            this.butInsertContracts.Size = new System.Drawing.Size(120, 37);
            this.butInsertContracts.TabIndex = 22;
            this.butInsertContracts.Text = "Сохранить";
            this.butInsertContracts.UseVisualStyleBackColor = true;
            this.butInsertContracts.Click += new System.EventHandler(this.butInsertContracts_Click);
            // 
            // pickerDateContr
            // 
            this.pickerDateContr.Location = new System.Drawing.Point(220, 89);
            this.pickerDateContr.Name = "pickerDateContr";
            this.pickerDateContr.Size = new System.Drawing.Size(122, 20);
            this.pickerDateContr.TabIndex = 23;
            // 
            // pickerDatePaymContr
            // 
            this.pickerDatePaymContr.Location = new System.Drawing.Point(220, 167);
            this.pickerDatePaymContr.Name = "pickerDatePaymContr";
            this.pickerDatePaymContr.Size = new System.Drawing.Size(122, 20);
            this.pickerDatePaymContr.TabIndex = 24;
            this.pickerDatePaymContr.ValueChanged += new System.EventHandler(this.pickerDatePaymContr_ValueChanged);
            // 
            // pickerDateStartContr
            // 
            this.pickerDateStartContr.Location = new System.Drawing.Point(220, 245);
            this.pickerDateStartContr.Name = "pickerDateStartContr";
            this.pickerDateStartContr.Size = new System.Drawing.Size(122, 20);
            this.pickerDateStartContr.TabIndex = 25;
            // 
            // pickerDateFinishContr
            // 
            this.pickerDateFinishContr.Location = new System.Drawing.Point(220, 271);
            this.pickerDateFinishContr.Name = "pickerDateFinishContr";
            this.pickerDateFinishContr.Size = new System.Drawing.Size(122, 20);
            this.pickerDateFinishContr.TabIndex = 26;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(199, 274);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(15, 14);
            this.checkBox4.TabIndex = 35;
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // labelContractAdded
            // 
            this.labelContractAdded.AutoSize = true;
            this.labelContractAdded.ForeColor = System.Drawing.Color.Red;
            this.labelContractAdded.Location = new System.Drawing.Point(47, 363);
            this.labelContractAdded.Name = "labelContractAdded";
            this.labelContractAdded.Size = new System.Drawing.Size(105, 13);
            this.labelContractAdded.TabIndex = 28;
            this.labelContractAdded.Text = "Контракт добавлен";
            this.labelContractAdded.Visible = false;
            // 
            // cbCodeKVR
            // 
            this.cbCodeKVR.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbCodeKVR.DataSource = this.kVRBindingSource3;
            this.cbCodeKVR.DisplayMember = "FULLNAMEKVR";
            this.cbCodeKVR.FormattingEnabled = true;
            this.cbCodeKVR.Location = new System.Drawing.Point(221, 193);
            this.cbCodeKVR.Name = "cbCodeKVR";
            this.cbCodeKVR.Size = new System.Drawing.Size(121, 21);
            this.cbCodeKVR.TabIndex = 29;
            this.cbCodeKVR.ValueMember = "Id";
            // 
            // cbFZ44
            // 
            this.cbFZ44.DataSource = this.fZBindingSource;
            this.cbFZ44.DisplayMember = "POINT44FZ";
            this.cbFZ44.FormattingEnabled = true;
            this.cbFZ44.Location = new System.Drawing.Point(221, 219);
            this.cbFZ44.Name = "cbFZ44";
            this.cbFZ44.Size = new System.Drawing.Size(121, 21);
            this.cbFZ44.TabIndex = 30;
            this.cbFZ44.ValueMember = "Id";
            // 
            // cbSuppliers
            // 
            this.cbSuppliers.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbSuppliers.DataSource = this.sUPPLIERSBindingSource;
            this.cbSuppliers.DisplayMember = "NameSupp";
            this.cbSuppliers.FormattingEnabled = true;
            this.cbSuppliers.Location = new System.Drawing.Point(218, 115);
            this.cbSuppliers.Name = "cbSuppliers";
            this.cbSuppliers.Size = new System.Drawing.Size(121, 21);
            this.cbSuppliers.TabIndex = 31;
            this.cbSuppliers.ValueMember = "Id";
            this.cbSuppliers.SelectedIndexChanged += new System.EventHandler(this.cbSuppliers_SelectedIndexChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(199, 173);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 32;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(199, 92);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 33;
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(199, 247);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(15, 14);
            this.checkBox3.TabIndex = 34;
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // InsertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 425);
            this.Controls.Add(this.tabControl1);
            this.Name = "InsertForm";
            this.Text = "Добавить контракт...";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sUPPLIERSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fZBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fZ44DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kVRBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataFromKVR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kVRBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractsV4DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kVRBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractsV4DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractsV4DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kVRBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private ContractsV4DataSet1 contractsV4DataSet1;
        private System.Windows.Forms.BindingSource kVRBindingSource;
        private ContractsV4DataSet1TableAdapters.KVRTableAdapter kVRTableAdapter;
        private System.Windows.Forms.BindingSource kVRBindingSource1;
        private System.Windows.Forms.BindingSource contractsV4DataSetBindingSource;
        private ContractsV4DataSet contractsV4DataSet;
        private DataFromKVR dataFromKVR;
        private System.Windows.Forms.BindingSource kVRBindingSource2;
        private DataFromKVRTableAdapters.KVRTableAdapter kVRTableAdapter1;
        private System.Windows.Forms.BindingSource kVRBindingSource3;
        private FZ44DataSet fZ44DataSet;
        private System.Windows.Forms.BindingSource fZBindingSource;
        private FZ44DataSetTableAdapters._44FZTableAdapter _44FZTableAdapter;
        private SuppliersDataSet suppliersDataSet;
        private System.Windows.Forms.BindingSource sUPPLIERSBindingSource;
        private SuppliersDataSetTableAdapters.SUPPLIERSTableAdapter sUPPLIERSTableAdapter;
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
    }
}

