namespace Kursova.Forms
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            System.Windows.Forms.Label idМістоLabel;
            System.Windows.Forms.Label назваМістоLabel;
            System.Windows.Forms.Label назваОбластіLabel;
            System.Windows.Forms.Label idТипLabel;
            System.Windows.Forms.Label назваТипLabel;
            System.Windows.Forms.Label idСортLabel;
            System.Windows.Forms.Label назваСортLabel;
            System.Windows.Forms.Label idОдиницяLabel;
            System.Windows.Forms.Label назваОдиниціLabel;
            System.Windows.Forms.Label idКраїнаLabel;
            System.Windows.Forms.Label назваКрLabel;
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dBCursDataSet = new Kursova.DBCursDataSet();
            this.містоBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.містоTableAdapter = new Kursova.DBCursDataSetTableAdapters.МістоTableAdapter();
            this.tableAdapterManager = new Kursova.DBCursDataSetTableAdapters.TableAdapterManager();
            this.містоBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.містоBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.містоDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.savebtn = new System.Windows.Forms.Button();
            this.idМістоTextBox = new System.Windows.Forms.TextBox();
            this.назваМістоTextBox = new System.Windows.Forms.TextBox();
            this.назваОбластіTextBox = new System.Windows.Forms.TextBox();
            this.типBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.типTableAdapter = new Kursova.DBCursDataSetTableAdapters.ТипTableAdapter();
            this.типDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deletebt = new System.Windows.Forms.Button();
            this.idТипTextBox = new System.Windows.Forms.TextBox();
            this.назваТипTextBox = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.сортBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сортTableAdapter = new Kursova.DBCursDataSetTableAdapters.СортTableAdapter();
            this.сортDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idСортTextBox = new System.Windows.Forms.TextBox();
            this.назваСортTextBox = new System.Windows.Forms.TextBox();
            this.saveSort = new System.Windows.Forms.Button();
            this.deleteSort = new System.Windows.Forms.Button();
            this.одиниця_вимірювання_кількостіBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.одиниця_вимірювання_кількостіTableAdapter = new Kursova.DBCursDataSetTableAdapters.Одиниця_вимірювання_кількостіTableAdapter();
            this.одиниця_вимірювання_кількостіDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idОдиницяTextBox = new System.Windows.Forms.TextBox();
            this.назваОдиниціTextBox = new System.Windows.Forms.TextBox();
            this.країнаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.країнаTableAdapter = new Kursova.DBCursDataSetTableAdapters.КраїнаTableAdapter();
            this.idКраїнаTextBox = new System.Windows.Forms.TextBox();
            this.назваКрTextBox = new System.Windows.Forms.TextBox();
            this.країнаDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveQ = new System.Windows.Forms.Button();
            this.deleteQ = new System.Windows.Forms.Button();
            this.saveCountry = new System.Windows.Forms.Button();
            this.deleteCountry = new System.Windows.Forms.Button();
            idМістоLabel = new System.Windows.Forms.Label();
            назваМістоLabel = new System.Windows.Forms.Label();
            назваОбластіLabel = new System.Windows.Forms.Label();
            idТипLabel = new System.Windows.Forms.Label();
            назваТипLabel = new System.Windows.Forms.Label();
            idСортLabel = new System.Windows.Forms.Label();
            назваСортLabel = new System.Windows.Forms.Label();
            idОдиницяLabel = new System.Windows.Forms.Label();
            назваОдиниціLabel = new System.Windows.Forms.Label();
            idКраїнаLabel = new System.Windows.Forms.Label();
            назваКрLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dBCursDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.містоBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.містоBindingNavigator)).BeginInit();
            this.містоBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.містоDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.типBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.типDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сортBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сортDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.одиниця_вимірювання_кількостіBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.одиниця_вимірювання_кількостіDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.країнаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.країнаDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 48);
            this.button1.TabIndex = 2;
            this.button1.Text = "Довідник продуктів";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 208);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(173, 48);
            this.button2.TabIndex = 0;
            this.button2.Text = "Постачальники";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.BurlyWood;
            this.button3.Location = new System.Drawing.Point(12, 349);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(173, 48);
            this.button3.TabIndex = 1;
            this.button3.Text = "Змінити дані";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 275);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(173, 48);
            this.button4.TabIndex = 2;
            this.button4.Text = "Постачання";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Info;
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button5.Location = new System.Drawing.Point(26, 478);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(61, 40);
            this.button5.TabIndex = 3;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dBCursDataSet
            // 
            this.dBCursDataSet.DataSetName = "DBCursDataSet";
            this.dBCursDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // містоBindingSource
            // 
            this.містоBindingSource.DataMember = "Місто";
            this.містоBindingSource.DataSource = this.dBCursDataSet;
            // 
            // містоTableAdapter
            // 
            this.містоTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Kursova.DBCursDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Вміст_постачанняTableAdapter = null;
            this.tableAdapterManager.ЗамовленняTableAdapter = null;
            this.tableAdapterManager.КраїнаTableAdapter = this.країнаTableAdapter;
            this.tableAdapterManager.МістоTableAdapter = this.містоTableAdapter;
            this.tableAdapterManager.Номенклатура_продуктуTableAdapter = null;
            this.tableAdapterManager.Одиниця_вимірювання_кількостіTableAdapter = this.одиниця_вимірювання_кількостіTableAdapter;
            this.tableAdapterManager.ПостачальникиTableAdapter = null;
            this.tableAdapterManager.ПостачанняTableAdapter = null;
            this.tableAdapterManager.СкладTableAdapter = null;
            this.tableAdapterManager.СортTableAdapter = this.сортTableAdapter;
            this.tableAdapterManager.ТипTableAdapter = this.типTableAdapter;
            // 
            // містоBindingNavigator
            // 
            this.містоBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.містоBindingNavigator.BindingSource = this.містоBindingSource;
            this.містоBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.містоBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.містоBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.містоBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.містоBindingNavigatorSaveItem});
            this.містоBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.містоBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.містоBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.містоBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.містоBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.містоBindingNavigator.Name = "містоBindingNavigator";
            this.містоBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.містоBindingNavigator.Size = new System.Drawing.Size(1582, 31);
            this.містоBindingNavigator.TabIndex = 4;
            this.містоBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 28);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // містоBindingNavigatorSaveItem
            // 
            this.містоBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.містоBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("містоBindingNavigatorSaveItem.Image")));
            this.містоBindingNavigatorSaveItem.Name = "містоBindingNavigatorSaveItem";
            this.містоBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.містоBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.містоBindingNavigatorSaveItem.Click += new System.EventHandler(this.містоBindingNavigatorSaveItem_Click);
            // 
            // містоDataGridView
            // 
            this.містоDataGridView.AutoGenerateColumns = false;
            this.містоDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.містоDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.містоDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.містоDataGridView.DataSource = this.містоBindingSource;
            this.містоDataGridView.Location = new System.Drawing.Point(263, 445);
            this.містоDataGridView.Name = "містоDataGridView";
            this.містоDataGridView.RowHeadersVisible = false;
            this.містоDataGridView.RowHeadersWidth = 51;
            this.містоDataGridView.RowTemplate.Height = 24;
            this.містоDataGridView.Size = new System.Drawing.Size(380, 200);
            this.містоDataGridView.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdМісто";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdМісто";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "НазваМісто";
            this.dataGridViewTextBoxColumn2.HeaderText = "НазваМісто";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "НазваОбласті";
            this.dataGridViewTextBoxColumn3.HeaderText = "НазваОбласті";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // savebtn
            // 
            this.savebtn.Location = new System.Drawing.Point(533, 349);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(93, 31);
            this.savebtn.TabIndex = 3;
            this.savebtn.Text = "Зберегти";
            this.savebtn.UseVisualStyleBackColor = true;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // idМістоLabel
            // 
            idМістоLabel.AutoSize = true;
            idМістоLabel.Location = new System.Drawing.Point(264, 349);
            idМістоLabel.Name = "idМістоLabel";
            idМістоLabel.Size = new System.Drawing.Size(60, 16);
            idМістоLabel.TabIndex = 8;
            idМістоLabel.Text = "Id Місто:";
            // 
            // idМістоTextBox
            // 
            this.idМістоTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.містоBindingSource, "IdМісто", true));
            this.idМістоTextBox.Location = new System.Drawing.Point(376, 346);
            this.idМістоTextBox.Name = "idМістоTextBox";
            this.idМістоTextBox.Size = new System.Drawing.Size(140, 22);
            this.idМістоTextBox.TabIndex = 0;
            // 
            // назваМістоLabel
            // 
            назваМістоLabel.AutoSize = true;
            назваМістоLabel.Location = new System.Drawing.Point(264, 377);
            назваМістоLabel.Name = "назваМістоLabel";
            назваМістоLabel.Size = new System.Drawing.Size(91, 16);
            назваМістоLabel.TabIndex = 10;
            назваМістоLabel.Text = "Назва Місто:";
            // 
            // назваМістоTextBox
            // 
            this.назваМістоTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.містоBindingSource, "НазваМісто", true));
            this.назваМістоTextBox.Location = new System.Drawing.Point(376, 374);
            this.назваМістоTextBox.Name = "назваМістоTextBox";
            this.назваМістоTextBox.Size = new System.Drawing.Size(140, 22);
            this.назваМістоTextBox.TabIndex = 1;
            // 
            // назваОбластіLabel
            // 
            назваОбластіLabel.AutoSize = true;
            назваОбластіLabel.Location = new System.Drawing.Point(264, 405);
            назваОбластіLabel.Name = "назваОбластіLabel";
            назваОбластіLabel.Size = new System.Drawing.Size(106, 16);
            назваОбластіLabel.TabIndex = 12;
            назваОбластіLabel.Text = "Назва Області:";
            // 
            // назваОбластіTextBox
            // 
            this.назваОбластіTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.містоBindingSource, "НазваОбласті", true));
            this.назваОбластіTextBox.Location = new System.Drawing.Point(376, 402);
            this.назваОбластіTextBox.Name = "назваОбластіTextBox";
            this.назваОбластіTextBox.Size = new System.Drawing.Size(140, 22);
            this.назваОбластіTextBox.TabIndex = 2;
            // 
            // типBindingSource
            // 
            this.типBindingSource.DataMember = "Тип";
            this.типBindingSource.DataSource = this.dBCursDataSet;
            // 
            // типTableAdapter
            // 
            this.типTableAdapter.ClearBeforeFill = true;
            // 
            // типDataGridView
            // 
            this.типDataGridView.AutoGenerateColumns = false;
            this.типDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.типDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.типDataGridView.DataSource = this.типBindingSource;
            this.типDataGridView.Location = new System.Drawing.Point(263, 123);
            this.типDataGridView.Name = "типDataGridView";
            this.типDataGridView.RowHeadersVisible = false;
            this.типDataGridView.RowHeadersWidth = 51;
            this.типDataGridView.RowTemplate.Height = 24;
            this.типDataGridView.Size = new System.Drawing.Size(373, 200);
            this.типDataGridView.TabIndex = 14;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "IdТип";
            this.dataGridViewTextBoxColumn4.HeaderText = "IdТип";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "НазваТип";
            this.dataGridViewTextBoxColumn5.HeaderText = "НазваТип";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // deletebt
            // 
            this.deletebt.Location = new System.Drawing.Point(533, 398);
            this.deletebt.Name = "deletebt";
            this.deletebt.Size = new System.Drawing.Size(93, 31);
            this.deletebt.TabIndex = 15;
            this.deletebt.Text = "Видалити";
            this.deletebt.UseVisualStyleBackColor = true;
            this.deletebt.Click += new System.EventHandler(this.deletebt_Click);
            // 
            // idТипLabel
            // 
            idТипLabel.AutoSize = true;
            idТипLabel.Location = new System.Drawing.Point(264, 57);
            idТипLabel.Name = "idТипLabel";
            idТипLabel.Size = new System.Drawing.Size(49, 16);
            idТипLabel.TabIndex = 16;
            idТипLabel.Text = "Id Тип:";
            // 
            // idТипTextBox
            // 
            this.idТипTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.типBindingSource, "IdТип", true));
            this.idТипTextBox.Location = new System.Drawing.Point(350, 54);
            this.idТипTextBox.Name = "idТипTextBox";
            this.idТипTextBox.Size = new System.Drawing.Size(177, 22);
            this.idТипTextBox.TabIndex = 17;
            // 
            // назваТипLabel
            // 
            назваТипLabel.AutoSize = true;
            назваТипLabel.Location = new System.Drawing.Point(264, 85);
            назваТипLabel.Name = "назваТипLabel";
            назваТипLabel.Size = new System.Drawing.Size(80, 16);
            назваТипLabel.TabIndex = 18;
            назваТипLabel.Text = "Назва Тип:";
            // 
            // назваТипTextBox
            // 
            this.назваТипTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.типBindingSource, "НазваТип", true));
            this.назваТипTextBox.Location = new System.Drawing.Point(350, 82);
            this.назваТипTextBox.Name = "назваТипTextBox";
            this.назваТипTextBox.Size = new System.Drawing.Size(177, 22);
            this.назваТипTextBox.TabIndex = 19;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(543, 45);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(93, 31);
            this.button6.TabIndex = 20;
            this.button6.Text = "Зберегти";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(543, 85);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(93, 31);
            this.button7.TabIndex = 21;
            this.button7.Text = "Видалити";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // сортBindingSource
            // 
            this.сортBindingSource.DataMember = "Сорт";
            this.сортBindingSource.DataSource = this.dBCursDataSet;
            // 
            // сортTableAdapter
            // 
            this.сортTableAdapter.ClearBeforeFill = true;
            // 
            // сортDataGridView
            // 
            this.сортDataGridView.AutoGenerateColumns = false;
            this.сортDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.сортDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.сортDataGridView.DataSource = this.сортBindingSource;
            this.сортDataGridView.Location = new System.Drawing.Point(651, 123);
            this.сортDataGridView.Name = "сортDataGridView";
            this.сортDataGridView.RowHeadersVisible = false;
            this.сортDataGridView.RowHeadersWidth = 51;
            this.сортDataGridView.RowTemplate.Height = 24;
            this.сортDataGridView.Size = new System.Drawing.Size(373, 200);
            this.сортDataGridView.TabIndex = 22;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "IdСорт";
            this.dataGridViewTextBoxColumn6.HeaderText = "IdСорт";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "НазваСорт";
            this.dataGridViewTextBoxColumn7.HeaderText = "НазваСорт";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // idСортLabel
            // 
            idСортLabel.AutoSize = true;
            idСортLabel.Location = new System.Drawing.Point(657, 57);
            idСортLabel.Name = "idСортLabel";
            idСортLabel.Size = new System.Drawing.Size(56, 16);
            idСортLabel.TabIndex = 23;
            idСортLabel.Text = "Id Сорт:";
            // 
            // idСортTextBox
            // 
            this.idСортTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сортBindingSource, "IdСорт", true));
            this.idСортTextBox.Location = new System.Drawing.Point(750, 54);
            this.idСортTextBox.Name = "idСортTextBox";
            this.idСортTextBox.Size = new System.Drawing.Size(177, 22);
            this.idСортTextBox.TabIndex = 24;
            // 
            // назваСортLabel
            // 
            назваСортLabel.AutoSize = true;
            назваСортLabel.Location = new System.Drawing.Point(657, 85);
            назваСортLabel.Name = "назваСортLabel";
            назваСортLabel.Size = new System.Drawing.Size(87, 16);
            назваСортLabel.TabIndex = 25;
            назваСортLabel.Text = "Назва Сорт:";
            // 
            // назваСортTextBox
            // 
            this.назваСортTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сортBindingSource, "НазваСорт", true));
            this.назваСортTextBox.Location = new System.Drawing.Point(750, 82);
            this.назваСортTextBox.Name = "назваСортTextBox";
            this.назваСортTextBox.Size = new System.Drawing.Size(177, 22);
            this.назваСортTextBox.TabIndex = 26;
            // 
            // saveSort
            // 
            this.saveSort.Location = new System.Drawing.Point(943, 50);
            this.saveSort.Name = "saveSort";
            this.saveSort.Size = new System.Drawing.Size(93, 31);
            this.saveSort.TabIndex = 27;
            this.saveSort.Text = "Зберегти";
            this.saveSort.UseVisualStyleBackColor = true;
            this.saveSort.Click += new System.EventHandler(this.saveSort_Click);
            // 
            // deleteSort
            // 
            this.deleteSort.Location = new System.Drawing.Point(943, 86);
            this.deleteSort.Name = "deleteSort";
            this.deleteSort.Size = new System.Drawing.Size(93, 31);
            this.deleteSort.TabIndex = 28;
            this.deleteSort.Text = "Видалити";
            this.deleteSort.UseVisualStyleBackColor = true;
            this.deleteSort.Click += new System.EventHandler(this.deleteSort_Click);
            // 
            // одиниця_вимірювання_кількостіBindingSource
            // 
            this.одиниця_вимірювання_кількостіBindingSource.DataMember = "Одиниця_вимірювання_кількості";
            this.одиниця_вимірювання_кількостіBindingSource.DataSource = this.dBCursDataSet;
            // 
            // одиниця_вимірювання_кількостіTableAdapter
            // 
            this.одиниця_вимірювання_кількостіTableAdapter.ClearBeforeFill = true;
            // 
            // одиниця_вимірювання_кількостіDataGridView
            // 
            this.одиниця_вимірювання_кількостіDataGridView.AutoGenerateColumns = false;
            this.одиниця_вимірювання_кількостіDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.одиниця_вимірювання_кількостіDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.одиниця_вимірювання_кількостіDataGridView.DataSource = this.одиниця_вимірювання_кількостіBindingSource;
            this.одиниця_вимірювання_кількостіDataGridView.Location = new System.Drawing.Point(676, 445);
            this.одиниця_вимірювання_кількостіDataGridView.Name = "одиниця_вимірювання_кількостіDataGridView";
            this.одиниця_вимірювання_кількостіDataGridView.RowHeadersVisible = false;
            this.одиниця_вимірювання_кількостіDataGridView.RowHeadersWidth = 51;
            this.одиниця_вимірювання_кількостіDataGridView.RowTemplate.Height = 24;
            this.одиниця_вимірювання_кількостіDataGridView.Size = new System.Drawing.Size(348, 200);
            this.одиниця_вимірювання_кількостіDataGridView.TabIndex = 29;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "IdОдиниця";
            this.dataGridViewTextBoxColumn8.HeaderText = "IdОдиниця";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "НазваОдиниці";
            this.dataGridViewTextBoxColumn9.HeaderText = "НазваОдиниці";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // idОдиницяLabel
            // 
            idОдиницяLabel.AutoSize = true;
            idОдиницяLabel.Location = new System.Drawing.Point(675, 361);
            idОдиницяLabel.Name = "idОдиницяLabel";
            idОдиницяLabel.Size = new System.Drawing.Size(81, 16);
            idОдиницяLabel.TabIndex = 30;
            idОдиницяLabel.Text = "Id Одиниця:";
            // 
            // idОдиницяTextBox
            // 
            this.idОдиницяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.одиниця_вимірювання_кількостіBindingSource, "IdОдиниця", true));
            this.idОдиницяTextBox.Location = new System.Drawing.Point(789, 358);
            this.idОдиницяTextBox.Name = "idОдиницяTextBox";
            this.idОдиницяTextBox.Size = new System.Drawing.Size(95, 22);
            this.idОдиницяTextBox.TabIndex = 31;
            // 
            // назваОдиниціLabel
            // 
            назваОдиниціLabel.AutoSize = true;
            назваОдиниціLabel.Location = new System.Drawing.Point(675, 389);
            назваОдиниціLabel.Name = "назваОдиниціLabel";
            назваОдиниціLabel.Size = new System.Drawing.Size(108, 16);
            назваОдиниціLabel.TabIndex = 32;
            назваОдиниціLabel.Text = "Назва Одиниці:";
            // 
            // назваОдиниціTextBox
            // 
            this.назваОдиниціTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.одиниця_вимірювання_кількостіBindingSource, "НазваОдиниці", true));
            this.назваОдиниціTextBox.Location = new System.Drawing.Point(789, 386);
            this.назваОдиниціTextBox.Name = "назваОдиниціTextBox";
            this.назваОдиниціTextBox.Size = new System.Drawing.Size(95, 22);
            this.назваОдиниціTextBox.TabIndex = 33;
            // 
            // країнаBindingSource
            // 
            this.країнаBindingSource.DataMember = "Країна";
            this.країнаBindingSource.DataSource = this.dBCursDataSet;
            // 
            // країнаTableAdapter
            // 
            this.країнаTableAdapter.ClearBeforeFill = true;
            // 
            // idКраїнаLabel
            // 
            idКраїнаLabel.AutoSize = true;
            idКраїнаLabel.Location = new System.Drawing.Point(1069, 57);
            idКраїнаLabel.Name = "idКраїнаLabel";
            idКраїнаLabel.Size = new System.Drawing.Size(67, 16);
            idКраїнаLabel.TabIndex = 34;
            idКраїнаLabel.Text = "Id Країна:";
            // 
            // idКраїнаTextBox
            // 
            this.idКраїнаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.країнаBindingSource, "IdКраїна", true));
            this.idКраїнаTextBox.Location = new System.Drawing.Point(1146, 54);
            this.idКраїнаTextBox.Name = "idКраїнаTextBox";
            this.idКраїнаTextBox.Size = new System.Drawing.Size(144, 22);
            this.idКраїнаTextBox.TabIndex = 35;
            // 
            // назваКрLabel
            // 
            назваКрLabel.AutoSize = true;
            назваКрLabel.Location = new System.Drawing.Point(1069, 85);
            назваКрLabel.Name = "назваКрLabel";
            назваКрLabel.Size = new System.Drawing.Size(71, 16);
            назваКрLabel.TabIndex = 36;
            назваКрLabel.Text = "Назва Кр:";
            // 
            // назваКрTextBox
            // 
            this.назваКрTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.країнаBindingSource, "НазваКр", true));
            this.назваКрTextBox.Location = new System.Drawing.Point(1146, 82);
            this.назваКрTextBox.Name = "назваКрTextBox";
            this.назваКрTextBox.Size = new System.Drawing.Size(144, 22);
            this.назваКрTextBox.TabIndex = 37;
            // 
            // країнаDataGridView
            // 
            this.країнаDataGridView.AutoGenerateColumns = false;
            this.країнаDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.країнаDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.країнаDataGridView.DataSource = this.країнаBindingSource;
            this.країнаDataGridView.Location = new System.Drawing.Point(1070, 123);
            this.країнаDataGridView.Name = "країнаDataGridView";
            this.країнаDataGridView.RowHeadersVisible = false;
            this.країнаDataGridView.RowHeadersWidth = 51;
            this.країнаDataGridView.RowTemplate.Height = 24;
            this.країнаDataGridView.Size = new System.Drawing.Size(300, 476);
            this.країнаDataGridView.TabIndex = 38;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "IdКраїна";
            this.dataGridViewTextBoxColumn10.HeaderText = "IdКраїна";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "НазваКр";
            this.dataGridViewTextBoxColumn11.HeaderText = "НазваКр";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 125;
            // 
            // saveQ
            // 
            this.saveQ.Location = new System.Drawing.Point(922, 354);
            this.saveQ.Name = "saveQ";
            this.saveQ.Size = new System.Drawing.Size(93, 31);
            this.saveQ.TabIndex = 39;
            this.saveQ.Text = "Зберегти";
            this.saveQ.UseVisualStyleBackColor = true;
            this.saveQ.Click += new System.EventHandler(this.saveQ_Click);
            // 
            // deleteQ
            // 
            this.deleteQ.Location = new System.Drawing.Point(922, 399);
            this.deleteQ.Name = "deleteQ";
            this.deleteQ.Size = new System.Drawing.Size(93, 31);
            this.deleteQ.TabIndex = 40;
            this.deleteQ.Text = "Видалити";
            this.deleteQ.UseVisualStyleBackColor = true;
            this.deleteQ.Click += new System.EventHandler(this.deleteQ_Click);
            // 
            // saveCountry
            // 
            this.saveCountry.Location = new System.Drawing.Point(1311, 45);
            this.saveCountry.Name = "saveCountry";
            this.saveCountry.Size = new System.Drawing.Size(93, 31);
            this.saveCountry.TabIndex = 41;
            this.saveCountry.Text = "Зберегти";
            this.saveCountry.UseVisualStyleBackColor = true;
            this.saveCountry.Click += new System.EventHandler(this.saveCountry_Click);
            // 
            // deleteCountry
            // 
            this.deleteCountry.Location = new System.Drawing.Point(1311, 84);
            this.deleteCountry.Name = "deleteCountry";
            this.deleteCountry.Size = new System.Drawing.Size(93, 31);
            this.deleteCountry.TabIndex = 42;
            this.deleteCountry.Text = "Видалити";
            this.deleteCountry.UseVisualStyleBackColor = true;
            this.deleteCountry.Click += new System.EventHandler(this.deleteCountry_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1582, 655);
            this.Controls.Add(this.deleteCountry);
            this.Controls.Add(this.saveCountry);
            this.Controls.Add(this.deleteQ);
            this.Controls.Add(this.saveQ);
            this.Controls.Add(this.країнаDataGridView);
            this.Controls.Add(idКраїнаLabel);
            this.Controls.Add(this.idКраїнаTextBox);
            this.Controls.Add(назваКрLabel);
            this.Controls.Add(this.назваКрTextBox);
            this.Controls.Add(idОдиницяLabel);
            this.Controls.Add(this.idОдиницяTextBox);
            this.Controls.Add(назваОдиниціLabel);
            this.Controls.Add(this.назваОдиниціTextBox);
            this.Controls.Add(this.одиниця_вимірювання_кількостіDataGridView);
            this.Controls.Add(this.deleteSort);
            this.Controls.Add(this.saveSort);
            this.Controls.Add(idСортLabel);
            this.Controls.Add(this.idСортTextBox);
            this.Controls.Add(назваСортLabel);
            this.Controls.Add(this.назваСортTextBox);
            this.Controls.Add(this.сортDataGridView);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(idТипLabel);
            this.Controls.Add(this.idТипTextBox);
            this.Controls.Add(назваТипLabel);
            this.Controls.Add(this.назваТипTextBox);
            this.Controls.Add(this.deletebt);
            this.Controls.Add(this.типDataGridView);
            this.Controls.Add(idМістоLabel);
            this.Controls.Add(this.idМістоTextBox);
            this.Controls.Add(назваМістоLabel);
            this.Controls.Add(this.назваМістоTextBox);
            this.Controls.Add(назваОбластіLabel);
            this.Controls.Add(this.назваОбластіTextBox);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.містоDataGridView);
            this.Controls.Add(this.містоBindingNavigator);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dBCursDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.містоBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.містоBindingNavigator)).EndInit();
            this.містоBindingNavigator.ResumeLayout(false);
            this.містоBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.містоDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.типBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.типDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сортBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сортDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.одиниця_вимірювання_кількостіBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.одиниця_вимірювання_кількостіDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.країнаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.країнаDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private DBCursDataSet dBCursDataSet;
        private System.Windows.Forms.BindingSource містоBindingSource;
        private DBCursDataSetTableAdapters.МістоTableAdapter містоTableAdapter;
        private DBCursDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator містоBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton містоBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView містоDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.TextBox idМістоTextBox;
        private System.Windows.Forms.TextBox назваМістоTextBox;
        private System.Windows.Forms.TextBox назваОбластіTextBox;
        private DBCursDataSetTableAdapters.ТипTableAdapter типTableAdapter;
        private System.Windows.Forms.BindingSource типBindingSource;
        private System.Windows.Forms.DataGridView типDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button deletebt;
        private DBCursDataSetTableAdapters.СортTableAdapter сортTableAdapter;
        private System.Windows.Forms.TextBox idТипTextBox;
        private System.Windows.Forms.TextBox назваТипTextBox;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.BindingSource сортBindingSource;
        private System.Windows.Forms.DataGridView сортDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.TextBox idСортTextBox;
        private System.Windows.Forms.TextBox назваСортTextBox;
        private System.Windows.Forms.Button saveSort;
        private System.Windows.Forms.Button deleteSort;
        private DBCursDataSetTableAdapters.Одиниця_вимірювання_кількостіTableAdapter одиниця_вимірювання_кількостіTableAdapter;
        private System.Windows.Forms.BindingSource одиниця_вимірювання_кількостіBindingSource;
        private DBCursDataSetTableAdapters.КраїнаTableAdapter країнаTableAdapter;
        private System.Windows.Forms.DataGridView одиниця_вимірювання_кількостіDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.TextBox idОдиницяTextBox;
        private System.Windows.Forms.TextBox назваОдиниціTextBox;
        private System.Windows.Forms.BindingSource країнаBindingSource;
        private System.Windows.Forms.TextBox idКраїнаTextBox;
        private System.Windows.Forms.TextBox назваКрTextBox;
        private System.Windows.Forms.DataGridView країнаDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.Button saveQ;
        private System.Windows.Forms.Button deleteQ;
        private System.Windows.Forms.Button saveCountry;
        private System.Windows.Forms.Button deleteCountry;
    }
}