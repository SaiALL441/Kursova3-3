namespace Kursova.Forms
{
    partial class Order
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
            System.Windows.Forms.Label датаВідправленняLabel;
            System.Windows.Forms.Label датаОтриманняLabel;
            System.Windows.Forms.Label idПостачальникаLabel;
            System.Windows.Forms.Label idПостачанняLabel;
            System.Windows.Forms.Label кількістьLabel;
            System.Windows.Forms.Label idПродуктуLabel;
            System.Windows.Forms.Label статусПоставкиLabel;
            System.Windows.Forms.Label idПостачанняLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dBCursDataSet = new Kursova.DBCursDataSet();
            this.вміст_постачанняBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.вміст_постачанняTableAdapter = new Kursova.DBCursDataSetTableAdapters.Вміст_постачанняTableAdapter();
            this.tableAdapterManager = new Kursova.DBCursDataSetTableAdapters.TableAdapterManager();
            this.постачанняTableAdapter = new Kursova.DBCursDataSetTableAdapters.ПостачанняTableAdapter();
            this.вміст_постачанняBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.вміст_постачанняBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.вміст_постачанняDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.постачанняBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.датаВідправленняDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.датаОтриманняDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.idПостачальникаTextBox = new System.Windows.Forms.TextBox();
            this.idПостачанняTextBox = new System.Windows.Forms.TextBox();
            this.idПродуктуTextBox = new System.Windows.Forms.TextBox();
            this.кількістьTextBox = new System.Windows.Forms.TextBox();
            this.постачанняDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.статусПоставкиComboBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.idПостачанняTextBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.постачальникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.постачальникиTableAdapter = new Kursova.DBCursDataSetTableAdapters.ПостачальникиTableAdapter();
            this.постачальникиDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            датаВідправленняLabel = new System.Windows.Forms.Label();
            датаОтриманняLabel = new System.Windows.Forms.Label();
            idПостачальникаLabel = new System.Windows.Forms.Label();
            idПостачанняLabel = new System.Windows.Forms.Label();
            кількістьLabel = new System.Windows.Forms.Label();
            idПродуктуLabel = new System.Windows.Forms.Label();
            статусПоставкиLabel = new System.Windows.Forms.Label();
            idПостачанняLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dBCursDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.вміст_постачанняBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.вміст_постачанняBindingNavigator)).BeginInit();
            this.вміст_постачанняBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.вміст_постачанняDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.постачанняBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.постачанняDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.постачальникиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.постачальникиDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // датаВідправленняLabel
            // 
            датаВідправленняLabel.AutoSize = true;
            датаВідправленняLabel.Location = new System.Drawing.Point(3, 124);
            датаВідправленняLabel.Name = "датаВідправленняLabel";
            датаВідправленняLabel.Size = new System.Drawing.Size(144, 18);
            датаВідправленняLabel.TabIndex = 0;
            датаВідправленняLabel.Text = "Дата відправлення:";
            // 
            // датаОтриманняLabel
            // 
            датаОтриманняLabel.AutoSize = true;
            датаОтриманняLabel.Location = new System.Drawing.Point(3, 171);
            датаОтриманняLabel.Name = "датаОтриманняLabel";
            датаОтриманняLabel.Size = new System.Drawing.Size(126, 18);
            датаОтриманняLabel.TabIndex = 2;
            датаОтриманняLabel.Text = "Дата отримання:";
            // 
            // idПостачальникаLabel
            // 
            idПостачальникаLabel.AutoSize = true;
            idПостачальникаLabel.Location = new System.Drawing.Point(6, 69);
            idПостачальникаLabel.Name = "idПостачальникаLabel";
            idПостачальникаLabel.Size = new System.Drawing.Size(135, 18);
            idПостачальникаLabel.TabIndex = 18;
            idПостачальникаLabel.Text = "Id Постачальника:";
            // 
            // idПостачанняLabel
            // 
            idПостачанняLabel.AutoSize = true;
            idПостачанняLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            idПостачанняLabel.Location = new System.Drawing.Point(6, 22);
            idПостачанняLabel.Name = "idПостачанняLabel";
            idПостачанняLabel.Size = new System.Drawing.Size(110, 18);
            idПостачанняLabel.TabIndex = 20;
            idПостачанняLabel.Text = "Id Постачання:";
            // 
            // кількістьLabel
            // 
            кількістьLabel.AutoSize = true;
            кількістьLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            кількістьLabel.Location = new System.Drawing.Point(40, 129);
            кількістьLabel.Name = "кількістьLabel";
            кількістьLabel.Size = new System.Drawing.Size(76, 18);
            кількістьLabel.TabIndex = 22;
            кількістьLabel.Text = "Кількість:";
            // 
            // idПродуктуLabel
            // 
            idПродуктуLabel.AutoSize = true;
            idПродуктуLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            idПродуктуLabel.Location = new System.Drawing.Point(34, 76);
            idПродуктуLabel.Name = "idПродуктуLabel";
            idПродуктуLabel.Size = new System.Drawing.Size(93, 18);
            idПродуктуLabel.TabIndex = 24;
            idПродуктуLabel.Text = "Id Продукту:";
            // 
            // статусПоставкиLabel
            // 
            статусПоставкиLabel.AutoSize = true;
            статусПоставкиLabel.Location = new System.Drawing.Point(6, 214);
            статусПоставкиLabel.Name = "статусПоставкиLabel";
            статусПоставкиLabel.Size = new System.Drawing.Size(128, 18);
            статусПоставкиLabel.TabIndex = 25;
            статусПоставкиLabel.Text = "Статус поставки:";
            // 
            // idПостачанняLabel1
            // 
            idПостачанняLabel1.AutoSize = true;
            idПостачанняLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            idПостачанняLabel1.Location = new System.Drawing.Point(13, 32);
            idПостачанняLabel1.Name = "idПостачанняLabel1";
            idПостачанняLabel1.Size = new System.Drawing.Size(110, 18);
            idПостачанняLabel1.TabIndex = 25;
            idПостачанняLabel1.Text = "Id Постачання:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "Довідник продуктів";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 208);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(173, 48);
            this.button2.TabIndex = 1;
            this.button2.Text = "Постачальники";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.BurlyWood;
            this.button3.Location = new System.Drawing.Point(12, 275);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(173, 48);
            this.button3.TabIndex = 2;
            this.button3.Text = "Постачання";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 349);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(173, 48);
            this.button4.TabIndex = 3;
            this.button4.Text = "Змінити дані";
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
            this.button5.TabIndex = 4;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dBCursDataSet
            // 
            this.dBCursDataSet.DataSetName = "DBCursDataSet";
            this.dBCursDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // вміст_постачанняBindingSource
            // 
            this.вміст_постачанняBindingSource.DataMember = "Вміст_постачання";
            this.вміст_постачанняBindingSource.DataSource = this.dBCursDataSet;
            // 
            // вміст_постачанняTableAdapter
            // 
            this.вміст_постачанняTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Kursova.DBCursDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Вміст_постачанняTableAdapter = this.вміст_постачанняTableAdapter;
            this.tableAdapterManager.ЗамовленняTableAdapter = null;
            this.tableAdapterManager.КраїнаTableAdapter = null;
            this.tableAdapterManager.МістоTableAdapter = null;
            this.tableAdapterManager.Номенклатура_продуктуTableAdapter = null;
            this.tableAdapterManager.Одиниця_вимірювання_кількостіTableAdapter = null;
            this.tableAdapterManager.ПостачальникиTableAdapter = null;
            this.tableAdapterManager.ПостачанняTableAdapter = this.постачанняTableAdapter;
            this.tableAdapterManager.СкладTableAdapter = null;
            this.tableAdapterManager.СортTableAdapter = null;
            this.tableAdapterManager.ТипTableAdapter = null;
            // 
            // постачанняTableAdapter
            // 
            this.постачанняTableAdapter.ClearBeforeFill = true;
            // 
            // вміст_постачанняBindingNavigator
            // 
            this.вміст_постачанняBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.вміст_постачанняBindingNavigator.BackColor = System.Drawing.Color.LightYellow;
            this.вміст_постачанняBindingNavigator.BindingSource = this.вміст_постачанняBindingSource;
            this.вміст_постачанняBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.вміст_постачанняBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.вміст_постачанняBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.вміст_постачанняBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.вміст_постачанняBindingNavigatorSaveItem});
            this.вміст_постачанняBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.вміст_постачанняBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.вміст_постачанняBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.вміст_постачанняBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.вміст_постачанняBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.вміст_постачанняBindingNavigator.Name = "вміст_постачанняBindingNavigator";
            this.вміст_постачанняBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.вміст_постачанняBindingNavigator.Size = new System.Drawing.Size(1582, 27);
            this.вміст_постачанняBindingNavigator.TabIndex = 5;
            this.вміст_постачанняBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // вміст_постачанняBindingNavigatorSaveItem
            // 
            this.вміст_постачанняBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.вміст_постачанняBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("вміст_постачанняBindingNavigatorSaveItem.Image")));
            this.вміст_постачанняBindingNavigatorSaveItem.Name = "вміст_постачанняBindingNavigatorSaveItem";
            this.вміст_постачанняBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.вміст_постачанняBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.вміст_постачанняBindingNavigatorSaveItem.Click += new System.EventHandler(this.вміст_постачанняBindingNavigatorSaveItem_Click);
            // 
            // вміст_постачанняDataGridView
            // 
            this.вміст_постачанняDataGridView.AutoGenerateColumns = false;
            this.вміст_постачанняDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.вміст_постачанняDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.вміст_постачанняDataGridView.DataSource = this.вміст_постачанняBindingSource;
            this.вміст_постачанняDataGridView.Location = new System.Drawing.Point(677, 298);
            this.вміст_постачанняDataGridView.Name = "вміст_постачанняDataGridView";
            this.вміст_постачанняDataGridView.RowHeadersVisible = false;
            this.вміст_постачанняDataGridView.RowHeadersWidth = 51;
            this.вміст_постачанняDataGridView.RowTemplate.Height = 24;
            this.вміст_постачанняDataGridView.Size = new System.Drawing.Size(391, 220);
            this.вміст_постачанняDataGridView.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdПостачання";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdПостачання";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "IdПродукту";
            this.dataGridViewTextBoxColumn2.HeaderText = "IdПродукту";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Кількість";
            this.dataGridViewTextBoxColumn3.HeaderText = "Кількість";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // постачанняBindingSource
            // 
            this.постачанняBindingSource.DataMember = "Постачання";
            this.постачанняBindingSource.DataSource = this.dBCursDataSet;
            // 
            // датаВідправленняDateTimePicker
            // 
            this.датаВідправленняDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.постачанняBindingSource, "ДатаВідправлення", true));
            this.датаВідправленняDateTimePicker.Location = new System.Drawing.Point(156, 124);
            this.датаВідправленняDateTimePicker.Name = "датаВідправленняDateTimePicker";
            this.датаВідправленняDateTimePicker.Size = new System.Drawing.Size(200, 24);
            this.датаВідправленняDateTimePicker.TabIndex = 1;
            // 
            // датаОтриманняDateTimePicker
            // 
            this.датаОтриманняDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.постачанняBindingSource, "ДатаОтримання", true));
            this.датаОтриманняDateTimePicker.Location = new System.Drawing.Point(156, 171);
            this.датаОтриманняDateTimePicker.Name = "датаОтриманняDateTimePicker";
            this.датаОтриманняDateTimePicker.Size = new System.Drawing.Size(200, 24);
            this.датаОтриманняDateTimePicker.TabIndex = 3;
            // 
            // idПостачальникаTextBox
            // 
            this.idПостачальникаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.постачанняBindingSource, "IdПостачальника", true));
            this.idПостачальникаTextBox.Location = new System.Drawing.Point(156, 69);
            this.idПостачальникаTextBox.Name = "idПостачальникаTextBox";
            this.idПостачальникаTextBox.Size = new System.Drawing.Size(100, 24);
            this.idПостачальникаTextBox.TabIndex = 19;
            // 
            // idПостачанняTextBox
            // 
            this.idПостачанняTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.постачанняBindingSource, "IdПостачання", true));
            this.idПостачанняTextBox.Location = new System.Drawing.Point(156, 16);
            this.idПостачанняTextBox.Name = "idПостачанняTextBox";
            this.idПостачанняTextBox.Size = new System.Drawing.Size(100, 24);
            this.idПостачанняTextBox.TabIndex = 21;
            // 
            // idПродуктуTextBox
            // 
            this.idПродуктуTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.вміст_постачанняBindingSource, "IdПродукту", true));
            this.idПродуктуTextBox.Location = new System.Drawing.Point(128, 73);
            this.idПродуктуTextBox.Name = "idПродуктуTextBox";
            this.idПродуктуTextBox.Size = new System.Drawing.Size(100, 22);
            this.idПродуктуTextBox.TabIndex = 25;
            // 
            // кількістьTextBox
            // 
            this.кількістьTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.вміст_постачанняBindingSource, "Кількість", true));
            this.кількістьTextBox.Location = new System.Drawing.Point(128, 127);
            this.кількістьTextBox.Name = "кількістьTextBox";
            this.кількістьTextBox.Size = new System.Drawing.Size(100, 22);
            this.кількістьTextBox.TabIndex = 23;
            // 
            // постачанняDataGridView
            // 
            this.постачанняDataGridView.AutoGenerateColumns = false;
            this.постачанняDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.постачанняDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.постачанняDataGridView.DataSource = this.постачанняBindingSource;
            this.постачанняDataGridView.Location = new System.Drawing.Point(677, 30);
            this.постачанняDataGridView.Name = "постачанняDataGridView";
            this.постачанняDataGridView.RowHeadersVisible = false;
            this.постачанняDataGridView.RowHeadersWidth = 51;
            this.постачанняDataGridView.RowTemplate.Height = 24;
            this.постачанняDataGridView.Size = new System.Drawing.Size(393, 220);
            this.постачанняDataGridView.TabIndex = 25;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "IdПостачання";
            this.dataGridViewTextBoxColumn4.HeaderText = "IdПостачання";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "IdПостачальника";
            this.dataGridViewTextBoxColumn5.HeaderText = "IdПостачальника";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ДатаВідправлення";
            this.dataGridViewTextBoxColumn6.HeaderText = "ДатаВідправлення";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ДатаОтримання";
            this.dataGridViewTextBoxColumn7.HeaderText = "ДатаОтримання";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "СтатусПоставки";
            this.dataGridViewTextBoxColumn8.HeaderText = "СтатусПоставки";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // статусПоставкиComboBox
            // 
            this.статусПоставкиComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.постачанняBindingSource, "СтатусПоставки", true));
            this.статусПоставкиComboBox.FormattingEnabled = true;
            this.статусПоставкиComboBox.Items.AddRange(new object[] {
            "відправлено",
            "не відпрвлено",
            "доставлено"});
            this.статусПоставкиComboBox.Location = new System.Drawing.Point(156, 217);
            this.статусПоставкиComboBox.Name = "статусПоставкиComboBox";
            this.статусПоставкиComboBox.Size = new System.Drawing.Size(166, 26);
            this.статусПоставкиComboBox.TabIndex = 26;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.Controls.Add(idПостачанняLabel1);
            this.panel1.Controls.Add(this.idПостачанняTextBox1);
            this.panel1.Controls.Add(this.idПродуктуTextBox);
            this.panel1.Controls.Add(this.кількістьTextBox);
            this.panel1.Controls.Add(кількістьLabel);
            this.panel1.Controls.Add(idПродуктуLabel);
            this.panel1.Location = new System.Drawing.Point(230, 339);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(313, 179);
            this.panel1.TabIndex = 27;
            // 
            // idПостачанняTextBox1
            // 
            this.idПостачанняTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.постачанняBindingSource, "IdПостачання", true));
            this.idПостачанняTextBox1.Location = new System.Drawing.Point(128, 29);
            this.idПостачанняTextBox1.Name = "idПостачанняTextBox1";
            this.idПостачанняTextBox1.Size = new System.Drawing.Size(100, 22);
            this.idПостачанняTextBox1.TabIndex = 26;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel2.Controls.Add(this.датаВідправленняDateTimePicker);
            this.panel2.Controls.Add(датаВідправленняLabel);
            this.panel2.Controls.Add(статусПоставкиLabel);
            this.panel2.Controls.Add(this.датаОтриманняDateTimePicker);
            this.panel2.Controls.Add(this.статусПоставкиComboBox);
            this.panel2.Controls.Add(датаОтриманняLabel);
            this.panel2.Controls.Add(this.idПостачанняTextBox);
            this.panel2.Controls.Add(this.idПостачальникаTextBox);
            this.panel2.Controls.Add(idПостачанняLabel);
            this.panel2.Controls.Add(idПостачальникаLabel);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel2.Location = new System.Drawing.Point(221, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(405, 256);
            this.panel2.TabIndex = 28;
            // 
            // постачальникиBindingSource
            // 
            this.постачальникиBindingSource.DataMember = "Постачальники";
            this.постачальникиBindingSource.DataSource = this.dBCursDataSet;
            // 
            // постачальникиTableAdapter
            // 
            this.постачальникиTableAdapter.ClearBeforeFill = true;
            // 
            // постачальникиDataGridView
            // 
            this.постачальникиDataGridView.AutoGenerateColumns = false;
            this.постачальникиDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.постачальникиDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15});
            this.постачальникиDataGridView.DataSource = this.постачальникиBindingSource;
            this.постачальникиDataGridView.Location = new System.Drawing.Point(1143, 187);
            this.постачальникиDataGridView.Name = "постачальникиDataGridView";
            this.постачальникиDataGridView.RowHeadersVisible = false;
            this.постачальникиDataGridView.RowHeadersWidth = 51;
            this.постачальникиDataGridView.RowTemplate.Height = 24;
            this.постачальникиDataGridView.Size = new System.Drawing.Size(427, 216);
            this.постачальникиDataGridView.TabIndex = 28;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "IdПостачальника";
            this.dataGridViewTextBoxColumn9.HeaderText = "IdПостачальника";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Найменування";
            this.dataGridViewTextBoxColumn10.HeaderText = "Найменування";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Продукт";
            this.dataGridViewTextBoxColumn11.HeaderText = "Продукт";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 125;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Телефон";
            this.dataGridViewTextBoxColumn12.HeaderText = "Телефон";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 125;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "ЕРДПОУ";
            this.dataGridViewTextBoxColumn13.HeaderText = "ЕРДПОУ";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Width = 125;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Адреса";
            this.dataGridViewTextBoxColumn14.HeaderText = "Адреса";
            this.dataGridViewTextBoxColumn14.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.Width = 125;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "IdМісто";
            this.dataGridViewTextBoxColumn15.HeaderText = "IdМісто";
            this.dataGridViewTextBoxColumn15.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.Width = 125;
            // 
            // button6
            // 
            this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.Location = new System.Drawing.Point(1190, 153);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(36, 30);
            this.button6.TabIndex = 29;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1232, 159);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(197, 22);
            this.textBox1.TabIndex = 30;
            // 
            // button7
            // 
            this.button7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button7.BackgroundImage")));
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.Location = new System.Drawing.Point(1148, 153);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(36, 30);
            this.button7.TabIndex = 31;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(1582, 556);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.постачальникиDataGridView);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.постачанняDataGridView);
            this.Controls.Add(this.вміст_постачанняDataGridView);
            this.Controls.Add(this.вміст_постачанняBindingNavigator);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Order";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dBCursDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.вміст_постачанняBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.вміст_постачанняBindingNavigator)).EndInit();
            this.вміст_постачанняBindingNavigator.ResumeLayout(false);
            this.вміст_постачанняBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.вміст_постачанняDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.постачанняBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.постачанняDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.постачальникиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.постачальникиDataGridView)).EndInit();
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
        private System.Windows.Forms.BindingSource вміст_постачанняBindingSource;
        private DBCursDataSetTableAdapters.Вміст_постачанняTableAdapter вміст_постачанняTableAdapter;
        private DBCursDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator вміст_постачанняBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton вміст_постачанняBindingNavigatorSaveItem;
        private DBCursDataSetTableAdapters.ПостачанняTableAdapter постачанняTableAdapter;
        private System.Windows.Forms.DataGridView вміст_постачанняDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.BindingSource постачанняBindingSource;
        private System.Windows.Forms.DateTimePicker датаВідправленняDateTimePicker;
        private System.Windows.Forms.DateTimePicker датаОтриманняDateTimePicker;
        private System.Windows.Forms.TextBox idПостачальникаTextBox;
        private System.Windows.Forms.TextBox idПостачанняTextBox;
        private System.Windows.Forms.TextBox idПродуктуTextBox;
        private System.Windows.Forms.TextBox кількістьTextBox;
        private System.Windows.Forms.DataGridView постачанняDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.ComboBox статусПоставкиComboBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox idПостачанняTextBox1;
        private System.Windows.Forms.BindingSource постачальникиBindingSource;
        private DBCursDataSetTableAdapters.ПостачальникиTableAdapter постачальникиTableAdapter;
        private System.Windows.Forms.DataGridView постачальникиDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button7;
    }
}