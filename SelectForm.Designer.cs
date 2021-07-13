
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectForm));
            this.contractsV4DataSet = new ContractsV4._0.ContractsV4DataSet();
            this.contractsV4DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lViewSelect = new System.Windows.Forms.ListView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CodeKVRItemMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обновитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.F5button = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.butChange = new System.Windows.Forms.ToolStripButton();
            this.butDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kvrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fZ44ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поставщикToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemContr = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.контрактToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.поставщикToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.кодКВРToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пункт44ФЗToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.contractsV4DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractsV4DataSetBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            // lViewSelect
            // 
            this.lViewSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lViewSelect.HideSelection = false;
            this.lViewSelect.Location = new System.Drawing.Point(0, 49);
            this.lViewSelect.MultiSelect = false;
            this.lViewSelect.Name = "lViewSelect";
            this.lViewSelect.Size = new System.Drawing.Size(815, 495);
            this.lViewSelect.TabIndex = 29;
            this.lViewSelect.UseCompatibleStateImageBehavior = false;
            this.lViewSelect.View = System.Windows.Forms.View.Tile;
            this.lViewSelect.SelectedIndexChanged += new System.EventHandler(this.lViewSelect_SelectedIndexChanged);
            this.lViewSelect.DoubleClick += new System.EventHandler(this.lViewSelect_DoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.правкаToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(815, 24);
            this.menuStrip1.TabIndex = 30;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.изменитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CodeKVRItemMenu});
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            // 
            // CodeKVRItemMenu
            // 
            this.CodeKVRItemMenu.Name = "CodeKVRItemMenu";
            this.CodeKVRItemMenu.Size = new System.Drawing.Size(118, 22);
            this.CodeKVRItemMenu.Text = "Код КВР";
            this.CodeKVRItemMenu.Click += new System.EventHandler(this.CodeKVRMenuItem_Click);
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.изменитьToolStripMenuItem.Text = "Изменить";
            // 
            // правкаToolStripMenuItem
            // 
            this.правкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обновитьToolStripMenuItem});
            this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            this.правкаToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.правкаToolStripMenuItem.Text = "Правка";
            // 
            // обновитьToolStripMenuItem
            // 
            this.обновитьToolStripMenuItem.Name = "обновитьToolStripMenuItem";
            this.обновитьToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.обновитьToolStripMenuItem.Text = "Обновить";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.F5button,
            this.toolStripButton2,
            this.butChange,
            this.butDelete,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(815, 25);
            this.toolStrip1.TabIndex = 31;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // F5button
            // 
            this.F5button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.F5button.Image = ((System.Drawing.Image)(resources.GetObject("F5button.Image")));
            this.F5button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.F5button.Name = "F5button";
            this.F5button.Size = new System.Drawing.Size(65, 22);
            this.F5button.Text = "Обновить";
            this.F5button.Click += new System.EventHandler(this.F5button_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(63, 22);
            this.toolStripButton2.Text = "Добавить";
            this.toolStripButton2.ToolTipText = "Вставить в базу данных";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // butChange
            // 
            this.butChange.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.butChange.Image = ((System.Drawing.Image)(resources.GetObject("butChange.Image")));
            this.butChange.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.butChange.Name = "butChange";
            this.butChange.Size = new System.Drawing.Size(65, 22);
            this.butChange.Text = "Изменить";
            this.butChange.Click += new System.EventHandler(this.butChange_Click);
            // 
            // butDelete
            // 
            this.butDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.butDelete.Image = ((System.Drawing.Image)(resources.GetObject("butDelete.Image")));
            this.butDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(55, 22);
            this.butDelete.Text = "Удалить";
            this.butDelete.Click += new System.EventHandler(this.butDelete_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripLabel1.ForeColor = System.Drawing.Color.Red;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(194, 22);
            this.toolStripLabel1.Text = "Соединение с базой установлено!";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.изменитьToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(129, 48);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemContr,
            this.поставщикToolStripMenuItem,
            this.kvrToolStripMenuItem,
            this.fZ44ToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(128, 22);
            this.toolStripMenuItem1.Text = "Добавить";
            // 
            // kvrToolStripMenuItem
            // 
            this.kvrToolStripMenuItem.Name = "kvrToolStripMenuItem";
            this.kvrToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kvrToolStripMenuItem.Text = "Код КВР";
            // 
            // fZ44ToolStripMenuItem
            // 
            this.fZ44ToolStripMenuItem.Name = "fZ44ToolStripMenuItem";
            this.fZ44ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fZ44ToolStripMenuItem.Text = "Пункт 44ФЗ";
            // 
            // поставщикToolStripMenuItem
            // 
            this.поставщикToolStripMenuItem.Name = "поставщикToolStripMenuItem";
            this.поставщикToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.поставщикToolStripMenuItem.Text = "Поставщик";
            this.поставщикToolStripMenuItem.Click += new System.EventHandler(this.поставщикToolStripMenuItem_Click);
            // 
            // MenuItemContr
            // 
            this.MenuItemContr.Name = "MenuItemContr";
            this.MenuItemContr.Size = new System.Drawing.Size(180, 22);
            this.MenuItemContr.Text = "Контракт";
            this.MenuItemContr.Click += new System.EventHandler(this.контрактToolStripMenuItem_Click);
            // 
            // изменитьToolStripMenuItem1
            // 
            this.изменитьToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.контрактToolStripMenuItem1,
            this.поставщикToolStripMenuItem1,
            this.кодКВРToolStripMenuItem,
            this.пункт44ФЗToolStripMenuItem});
            this.изменитьToolStripMenuItem1.Name = "изменитьToolStripMenuItem1";
            this.изменитьToolStripMenuItem1.Size = new System.Drawing.Size(128, 22);
            this.изменитьToolStripMenuItem1.Text = "Изменить";
            // 
            // контрактToolStripMenuItem1
            // 
            this.контрактToolStripMenuItem1.Name = "контрактToolStripMenuItem1";
            this.контрактToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.контрактToolStripMenuItem1.Text = "Контракт";
            // 
            // поставщикToolStripMenuItem1
            // 
            this.поставщикToolStripMenuItem1.Name = "поставщикToolStripMenuItem1";
            this.поставщикToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.поставщикToolStripMenuItem1.Text = "Поставщик";
            // 
            // кодКВРToolStripMenuItem
            // 
            this.кодКВРToolStripMenuItem.Name = "кодКВРToolStripMenuItem";
            this.кодКВРToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.кодКВРToolStripMenuItem.Text = "Код КВР";
            // 
            // пункт44ФЗToolStripMenuItem
            // 
            this.пункт44ФЗToolStripMenuItem.Name = "пункт44ФЗToolStripMenuItem";
            this.пункт44ФЗToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.пункт44ФЗToolStripMenuItem.Text = "Пункт 44ФЗ";
            // 
            // SelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 544);
            this.Controls.Add(this.lViewSelect);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SelectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выборка";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SelectForm_FormClosing);
            this.Load += new System.EventHandler(this.SelectForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.contractsV4DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractsV4DataSetBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource contractsV4DataSetBindingSource;
        private ContractsV4DataSet contractsV4DataSet;
        private System.Windows.Forms.ListView lViewSelect;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem правкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обновитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton F5button;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton butChange;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton butDelete;
        private System.Windows.Forms.ToolStripMenuItem CodeKVRItemMenu;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem kvrToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fZ44ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поставщикToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItemContr;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem контрактToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem поставщикToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem кодКВРToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пункт44ФЗToolStripMenuItem;
    }
}