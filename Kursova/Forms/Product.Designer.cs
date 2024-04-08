namespace Kursova.Forms
{
    partial class Product
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
            System.Windows.Forms.Label idПродуктуLabel;
            System.Windows.Forms.Label idТипLabel;
            System.Windows.Forms.Label idСортLabel;
            System.Windows.Forms.Label idКраїнаLabel;
            System.Windows.Forms.Label idСкладLabel;
            System.Windows.Forms.Label idОдиницяLabel;
            System.Windows.Forms.Label ціна_одиниці_продукту_ПДВLabel;
            System.Windows.Forms.Label ціна_одиниці_продукту_безПДВLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Product));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dBCursDataSet = new Kursova.DBCursDataSet();
            this.номенклатура_продуктуBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.номенклатура_продуктуTableAdapter = new Kursova.DBCursDataSetTableAdapters.Номенклатура_продуктуTableAdapter();
            this.tableAdapterManager = new Kursova.DBCursDataSetTableAdapters.TableAdapterManager();
            this.країнаTableAdapter = new Kursova.DBCursDataSetTableAdapters.КраїнаTableAdapter();
            this.одиниця_вимірювання_кількостіTableAdapter = new Kursova.DBCursDataSetTableAdapters.Одиниця_вимірювання_кількостіTableAdapter();
            this.складTableAdapter = new Kursova.DBCursDataSetTableAdapters.СкладTableAdapter();
            this.сортTableAdapter = new Kursova.DBCursDataSetTableAdapters.СортTableAdapter();
            this.типTableAdapter = new Kursova.DBCursDataSetTableAdapters.ТипTableAdapter();
            this.номенклатура_продуктуBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.номенклатура_продуктуBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tstBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.tsbSearch1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.tstBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.tsbSearch2 = new System.Windows.Forms.ToolStripButton();
            this.tsbReload = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.номенклатура_продуктуDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idПродуктуTextBox = new System.Windows.Forms.TextBox();
            this.idТипTextBox = new System.Windows.Forms.TextBox();
            this.idСортTextBox = new System.Windows.Forms.TextBox();
            this.idКраїнаTextBox = new System.Windows.Forms.TextBox();
            this.idСкладTextBox = new System.Windows.Forms.TextBox();
            this.idОдиницяTextBox = new System.Windows.Forms.TextBox();
            this.ціна_одиниці_продукту_ПДВTextBox = new System.Windows.Forms.TextBox();
            this.ціна_одиниці_продукту_безПДВTextBox = new System.Windows.Forms.TextBox();
            this.типBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.типDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сортBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сортDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.складBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.країнаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.країнаDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.складDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.одиниця_вимірювання_кількостіBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.одиниця_вимірювання_кількостіDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idПродуктуLabel = new System.Windows.Forms.Label();
            idТипLabel = new System.Windows.Forms.Label();
            idСортLabel = new System.Windows.Forms.Label();
            idКраїнаLabel = new System.Windows.Forms.Label();
            idСкладLabel = new System.Windows.Forms.Label();
            idОдиницяLabel = new System.Windows.Forms.Label();
            ціна_одиниці_продукту_ПДВLabel = new System.Windows.Forms.Label();
            ціна_одиниці_продукту_безПДВLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dBCursDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.номенклатура_продуктуBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.номенклатура_продуктуBindingNavigator)).BeginInit();
            this.номенклатура_продуктуBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.номенклатура_продуктуDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.типBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.типDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сортBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сортDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.складBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.країнаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.країнаDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.складDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.одиниця_вимірювання_кількостіBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.одиниця_вимірювання_кількостіDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idПродуктуLabel
            // 
            idПродуктуLabel.AutoSize = true;
            idПродуктуLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            idПродуктуLabel.Location = new System.Drawing.Point(210, 70);
            idПродуктуLabel.Name = "idПродуктуLabel";
            idПродуктуLabel.Size = new System.Drawing.Size(112, 20);
            idПродуктуLabel.TabIndex = 8;
            idПродуктуLabel.Text = "Id Продукту:";
            // 
            // idТипLabel
            // 
            idТипLabel.AutoSize = true;
            idТипLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            idТипLabel.Location = new System.Drawing.Point(210, 98);
            idТипLabel.Name = "idТипLabel";
            idТипLabel.Size = new System.Drawing.Size(62, 20);
            idТипLabel.TabIndex = 10;
            idТипLabel.Text = "Id Тип:";
            // 
            // idСортLabel
            // 
            idСортLabel.AutoSize = true;
            idСортLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            idСортLabel.Location = new System.Drawing.Point(210, 126);
            idСортLabel.Name = "idСортLabel";
            idСортLabel.Size = new System.Drawing.Size(74, 20);
            idСортLabel.TabIndex = 12;
            idСортLabel.Text = "Id Сорт:";
            // 
            // idКраїнаLabel
            // 
            idКраїнаLabel.AutoSize = true;
            idКраїнаLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            idКраїнаLabel.Location = new System.Drawing.Point(210, 154);
            idКраїнаLabel.Name = "idКраїнаLabel";
            idКраїнаLabel.Size = new System.Drawing.Size(89, 20);
            idКраїнаLabel.TabIndex = 14;
            idКраїнаLabel.Text = "Id Країна:";
            // 
            // idСкладLabel
            // 
            idСкладLabel.AutoSize = true;
            idСкладLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            idСкладLabel.Location = new System.Drawing.Point(493, 73);
            idСкладLabel.Name = "idСкладLabel";
            idСкладLabel.Size = new System.Drawing.Size(85, 20);
            idСкладLabel.TabIndex = 16;
            idСкладLabel.Text = "Id Склад:";
            // 
            // idОдиницяLabel
            // 
            idОдиницяLabel.AutoSize = true;
            idОдиницяLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            idОдиницяLabel.Location = new System.Drawing.Point(493, 101);
            idОдиницяLabel.Name = "idОдиницяLabel";
            idОдиницяLabel.Size = new System.Drawing.Size(107, 20);
            idОдиницяLabel.TabIndex = 18;
            idОдиницяLabel.Text = "Id Одиниця:";
            // 
            // ціна_одиниці_продукту_ПДВLabel
            // 
            ціна_одиниці_продукту_ПДВLabel.AutoSize = true;
            ціна_одиниці_продукту_ПДВLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            ціна_одиниці_продукту_ПДВLabel.Location = new System.Drawing.Point(493, 129);
            ціна_одиниці_продукту_ПДВLabel.Name = "ціна_одиниці_продукту_ПДВLabel";
            ціна_одиниці_продукту_ПДВLabel.Size = new System.Drawing.Size(247, 20);
            ціна_одиниці_продукту_ПДВLabel.TabIndex = 20;
            ціна_одиниці_продукту_ПДВLabel.Text = "Ціна одиниці продукту ПДВ:";
            // 
            // ціна_одиниці_продукту_безПДВLabel
            // 
            ціна_одиниці_продукту_безПДВLabel.AutoSize = true;
            ціна_одиниці_продукту_безПДВLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            ціна_одиниці_продукту_безПДВLabel.Location = new System.Drawing.Point(493, 157);
            ціна_одиниці_продукту_безПДВLabel.Name = "ціна_одиниці_продукту_безПДВLabel";
            ціна_одиниці_продукту_безПДВLabel.Size = new System.Drawing.Size(281, 20);
            ціна_одиниці_продукту_безПДВLabel.TabIndex = 22;
            ціна_одиниці_продукту_безПДВLabel.Text = "Ціна одиниці продукту без ПДВ:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.BurlyWood;
            this.button1.Location = new System.Drawing.Point(12, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "Довідник продуктів";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 208);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 47);
            this.button2.TabIndex = 1;
            this.button2.Text = "Постачальники";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 275);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(162, 47);
            this.button3.TabIndex = 2;
            this.button3.Text = "Постачання";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 349);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(162, 47);
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
            // номенклатура_продуктуBindingSource
            // 
            this.номенклатура_продуктуBindingSource.DataMember = "Номенклатура_продукту";
            this.номенклатура_продуктуBindingSource.DataSource = this.dBCursDataSet;
            // 
            // номенклатура_продуктуTableAdapter
            // 
            this.номенклатура_продуктуTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Kursova.DBCursDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Вміст_постачанняTableAdapter = null;
            this.tableAdapterManager.ЗамовленняTableAdapter = null;
            this.tableAdapterManager.КраїнаTableAdapter = this.країнаTableAdapter;
            this.tableAdapterManager.МістоTableAdapter = null;
            this.tableAdapterManager.Номенклатура_продуктуTableAdapter = this.номенклатура_продуктуTableAdapter;
            this.tableAdapterManager.Одиниця_вимірювання_кількостіTableAdapter = this.одиниця_вимірювання_кількостіTableAdapter;
            this.tableAdapterManager.ПостачальникиTableAdapter = null;
            this.tableAdapterManager.ПостачанняTableAdapter = null;
            this.tableAdapterManager.СкладTableAdapter = this.складTableAdapter;
            this.tableAdapterManager.СортTableAdapter = this.сортTableAdapter;
            this.tableAdapterManager.ТипTableAdapter = this.типTableAdapter;
            // 
            // країнаTableAdapter
            // 
            this.країнаTableAdapter.ClearBeforeFill = true;
            // 
            // одиниця_вимірювання_кількостіTableAdapter
            // 
            this.одиниця_вимірювання_кількостіTableAdapter.ClearBeforeFill = true;
            // 
            // складTableAdapter
            // 
            this.складTableAdapter.ClearBeforeFill = true;
            // 
            // сортTableAdapter
            // 
            this.сортTableAdapter.ClearBeforeFill = true;
            // 
            // типTableAdapter
            // 
            this.типTableAdapter.ClearBeforeFill = true;
            // 
            // номенклатура_продуктуBindingNavigator
            // 
            this.номенклатура_продуктуBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.номенклатура_продуктуBindingNavigator.BackColor = System.Drawing.Color.LightYellow;
            this.номенклатура_продуктуBindingNavigator.BindingSource = this.номенклатура_продуктуBindingSource;
            this.номенклатура_продуктуBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.номенклатура_продуктуBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.номенклатура_продуктуBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.номенклатура_продуктуBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.номенклатура_продуктуBindingNavigatorSaveItem,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.tstBox1,
            this.tsbSearch1,
            this.toolStripLabel2,
            this.tstBox2,
            this.tsbSearch2,
            this.tsbReload,
            this.toolStripSeparator2});
            this.номенклатура_продуктуBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.номенклатура_продуктуBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.номенклатура_продуктуBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.номенклатура_продуктуBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.номенклатура_продуктуBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.номенклатура_продуктуBindingNavigator.Name = "номенклатура_продуктуBindingNavigator";
            this.номенклатура_продуктуBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.номенклатура_продуктуBindingNavigator.Size = new System.Drawing.Size(1582, 31);
            this.номенклатура_продуктуBindingNavigator.TabIndex = 6;
            this.номенклатура_продуктуBindingNavigator.Text = "bindingNavigator1";
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
            // номенклатура_продуктуBindingNavigatorSaveItem
            // 
            this.номенклатура_продуктуBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.номенклатура_продуктуBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("номенклатура_продуктуBindingNavigatorSaveItem.Image")));
            this.номенклатура_продуктуBindingNavigatorSaveItem.Name = "номенклатура_продуктуBindingNavigatorSaveItem";
            this.номенклатура_продуктуBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.номенклатура_продуктуBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.номенклатура_продуктуBindingNavigatorSaveItem.Click += new System.EventHandler(this.номенклатура_продуктуBindingNavigatorSaveItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(131, 24);
            this.toolStripLabel1.Text = "Пошук за назвою";
            // 
            // tstBox1
            // 
            this.tstBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tstBox1.Name = "tstBox1";
            this.tstBox1.Size = new System.Drawing.Size(100, 27);
            this.tstBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tstBox1_KeyPress);
            // 
            // tsbSearch1
            // 
            this.tsbSearch1.BackColor = System.Drawing.Color.Olive;
            this.tsbSearch1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSearch1.Image = ((System.Drawing.Image)(resources.GetObject("tsbSearch1.Image")));
            this.tsbSearch1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSearch1.Name = "tsbSearch1";
            this.tsbSearch1.Size = new System.Drawing.Size(29, 24);
            this.tsbSearch1.Click += new System.EventHandler(this.tsbSearch1_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(91, 24);
            this.toolStripLabel2.Text = "Пошук за id";
            // 
            // tstBox2
            // 
            this.tstBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tstBox2.Name = "tstBox2";
            this.tstBox2.Size = new System.Drawing.Size(100, 27);
            // 
            // tsbSearch2
            // 
            this.tsbSearch2.BackColor = System.Drawing.Color.Olive;
            this.tsbSearch2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSearch2.Image = ((System.Drawing.Image)(resources.GetObject("tsbSearch2.Image")));
            this.tsbSearch2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSearch2.Name = "tsbSearch2";
            this.tsbSearch2.Size = new System.Drawing.Size(29, 24);
            this.tsbSearch2.Click += new System.EventHandler(this.tsbSearch2_Click);
            // 
            // tsbReload
            // 
            this.tsbReload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbReload.Image = ((System.Drawing.Image)(resources.GetObject("tsbReload.Image")));
            this.tsbReload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbReload.Name = "tsbReload";
            this.tsbReload.Size = new System.Drawing.Size(29, 24);
            this.tsbReload.Click += new System.EventHandler(this.tsbReload_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // номенклатура_продуктуDataGridView
            // 
            this.номенклатура_продуктуDataGridView.AutoGenerateColumns = false;
            this.номенклатура_продуктуDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.номенклатура_продуктуDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.номенклатура_продуктуDataGridView.DataSource = this.номенклатура_продуктуBindingSource;
            this.номенклатура_продуктуDataGridView.Location = new System.Drawing.Point(232, 198);
            this.номенклатура_продуктуDataGridView.Name = "номенклатура_продуктуDataGridView";
            this.номенклатура_продуктуDataGridView.RowHeadersVisible = false;
            this.номенклатура_продуктуDataGridView.RowHeadersWidth = 51;
            this.номенклатура_продуктуDataGridView.RowTemplate.Height = 24;
            this.номенклатура_продуктуDataGridView.Size = new System.Drawing.Size(634, 396);
            this.номенклатура_продуктуDataGridView.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdПродукту";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdПродукту";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "IdТип";
            this.dataGridViewTextBoxColumn2.HeaderText = "IdТип";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "IdСорт";
            this.dataGridViewTextBoxColumn3.HeaderText = "IdСорт";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "IdКраїна";
            this.dataGridViewTextBoxColumn4.HeaderText = "IdКраїна";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "IdСклад";
            this.dataGridViewTextBoxColumn5.HeaderText = "IdСклад";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "IdОдиниця";
            this.dataGridViewTextBoxColumn6.HeaderText = "IdОдиниця";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Ціна_одиниці_продукту_ПДВ";
            this.dataGridViewTextBoxColumn7.HeaderText = "Ціна_одиниці_продукту_ПДВ";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Ціна_одиниці_продукту_безПДВ";
            this.dataGridViewTextBoxColumn8.HeaderText = "Ціна_одиниці_продукту_безПДВ";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // idПродуктуTextBox
            // 
            this.idПродуктуTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.номенклатура_продуктуBindingSource, "IdПродукту", true));
            this.idПродуктуTextBox.Location = new System.Drawing.Point(327, 70);
            this.idПродуктуTextBox.Name = "idПродуктуTextBox";
            this.idПродуктуTextBox.Size = new System.Drawing.Size(149, 22);
            this.idПродуктуTextBox.TabIndex = 9;
            // 
            // idТипTextBox
            // 
            this.idТипTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.номенклатура_продуктуBindingSource, "IdТип", true));
            this.idТипTextBox.Location = new System.Drawing.Point(327, 98);
            this.idТипTextBox.Name = "idТипTextBox";
            this.idТипTextBox.Size = new System.Drawing.Size(149, 22);
            this.idТипTextBox.TabIndex = 11;
            // 
            // idСортTextBox
            // 
            this.idСортTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.номенклатура_продуктуBindingSource, "IdСорт", true));
            this.idСортTextBox.Location = new System.Drawing.Point(327, 126);
            this.idСортTextBox.Name = "idСортTextBox";
            this.idСортTextBox.Size = new System.Drawing.Size(149, 22);
            this.idСортTextBox.TabIndex = 13;
            // 
            // idКраїнаTextBox
            // 
            this.idКраїнаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.номенклатура_продуктуBindingSource, "IdКраїна", true));
            this.idКраїнаTextBox.Location = new System.Drawing.Point(327, 154);
            this.idКраїнаTextBox.Name = "idКраїнаTextBox";
            this.idКраїнаTextBox.Size = new System.Drawing.Size(149, 22);
            this.idКраїнаTextBox.TabIndex = 15;
            // 
            // idСкладTextBox
            // 
            this.idСкладTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.номенклатура_продуктуBindingSource, "IdСклад", true));
            this.idСкладTextBox.Location = new System.Drawing.Point(781, 71);
            this.idСкладTextBox.Name = "idСкладTextBox";
            this.idСкладTextBox.Size = new System.Drawing.Size(92, 22);
            this.idСкладTextBox.TabIndex = 17;
            // 
            // idОдиницяTextBox
            // 
            this.idОдиницяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.номенклатура_продуктуBindingSource, "IdОдиниця", true));
            this.idОдиницяTextBox.Location = new System.Drawing.Point(781, 99);
            this.idОдиницяTextBox.Name = "idОдиницяTextBox";
            this.idОдиницяTextBox.Size = new System.Drawing.Size(92, 22);
            this.idОдиницяTextBox.TabIndex = 19;
            // 
            // ціна_одиниці_продукту_ПДВTextBox
            // 
            this.ціна_одиниці_продукту_ПДВTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.номенклатура_продуктуBindingSource, "Ціна_одиниці_продукту_ПДВ", true));
            this.ціна_одиниці_продукту_ПДВTextBox.Location = new System.Drawing.Point(781, 127);
            this.ціна_одиниці_продукту_ПДВTextBox.Name = "ціна_одиниці_продукту_ПДВTextBox";
            this.ціна_одиниці_продукту_ПДВTextBox.Size = new System.Drawing.Size(92, 22);
            this.ціна_одиниці_продукту_ПДВTextBox.TabIndex = 21;
            // 
            // ціна_одиниці_продукту_безПДВTextBox
            // 
            this.ціна_одиниці_продукту_безПДВTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.номенклатура_продуктуBindingSource, "Ціна_одиниці_продукту_безПДВ", true));
            this.ціна_одиниці_продукту_безПДВTextBox.Location = new System.Drawing.Point(781, 155);
            this.ціна_одиниці_продукту_безПДВTextBox.Name = "ціна_одиниці_продукту_безПДВTextBox";
            this.ціна_одиниці_продукту_безПДВTextBox.Size = new System.Drawing.Size(92, 22);
            this.ціна_одиниці_продукту_безПДВTextBox.TabIndex = 23;
            // 
            // типBindingSource
            // 
            this.типBindingSource.DataMember = "Тип";
            this.типBindingSource.DataSource = this.dBCursDataSet;
            // 
            // типDataGridView
            // 
            this.типDataGridView.AutoGenerateColumns = false;
            this.типDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.типDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.типDataGridView.DataSource = this.типBindingSource;
            this.типDataGridView.Location = new System.Drawing.Point(1233, 49);
            this.типDataGridView.Name = "типDataGridView";
            this.типDataGridView.RowHeadersVisible = false;
            this.типDataGridView.RowHeadersWidth = 51;
            this.типDataGridView.RowTemplate.Height = 24;
            this.типDataGridView.Size = new System.Drawing.Size(337, 148);
            this.типDataGridView.TabIndex = 24;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "IdТип";
            this.dataGridViewTextBoxColumn9.HeaderText = "IdТип";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "НазваТип";
            this.dataGridViewTextBoxColumn10.HeaderText = "НазваТип";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // сортBindingSource
            // 
            this.сортBindingSource.DataMember = "Сорт";
            this.сортBindingSource.DataSource = this.dBCursDataSet;
            // 
            // сортDataGridView
            // 
            this.сортDataGridView.AutoGenerateColumns = false;
            this.сортDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.сортDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.сортDataGridView.DataSource = this.сортBindingSource;
            this.сортDataGridView.Location = new System.Drawing.Point(892, 221);
            this.сортDataGridView.Name = "сортDataGridView";
            this.сортDataGridView.RowHeadersVisible = false;
            this.сортDataGridView.RowHeadersWidth = 51;
            this.сортDataGridView.RowTemplate.Height = 24;
            this.сортDataGridView.Size = new System.Drawing.Size(300, 159);
            this.сортDataGridView.TabIndex = 25;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "IdСорт";
            this.dataGridViewTextBoxColumn11.HeaderText = "IdСорт";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 125;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "НазваСорт";
            this.dataGridViewTextBoxColumn12.HeaderText = "НазваСорт";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 125;
            // 
            // складBindingSource
            // 
            this.складBindingSource.DataMember = "Склад";
            this.складBindingSource.DataSource = this.dBCursDataSet;
            // 
            // країнаBindingSource
            // 
            this.країнаBindingSource.DataMember = "Країна";
            this.країнаBindingSource.DataSource = this.dBCursDataSet;
            // 
            // країнаDataGridView
            // 
            this.країнаDataGridView.AutoGenerateColumns = false;
            this.країнаDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.країнаDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14});
            this.країнаDataGridView.DataSource = this.країнаBindingSource;
            this.країнаDataGridView.Location = new System.Drawing.Point(892, 409);
            this.країнаDataGridView.Name = "країнаDataGridView";
            this.країнаDataGridView.RowHeadersVisible = false;
            this.країнаDataGridView.RowHeadersWidth = 51;
            this.країнаDataGridView.RowTemplate.Height = 24;
            this.країнаDataGridView.Size = new System.Drawing.Size(300, 182);
            this.країнаDataGridView.TabIndex = 26;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "IdКраїна";
            this.dataGridViewTextBoxColumn13.HeaderText = "IdКраїна";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Width = 125;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "НазваКр";
            this.dataGridViewTextBoxColumn14.HeaderText = "НазваКр";
            this.dataGridViewTextBoxColumn14.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.Width = 125;
            // 
            // складDataGridView
            // 
            this.складDataGridView.AutoGenerateColumns = false;
            this.складDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.складDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17});
            this.складDataGridView.DataSource = this.складBindingSource;
            this.складDataGridView.Location = new System.Drawing.Point(1227, 409);
            this.складDataGridView.Name = "складDataGridView";
            this.складDataGridView.RowHeadersVisible = false;
            this.складDataGridView.RowHeadersWidth = 51;
            this.складDataGridView.RowTemplate.Height = 24;
            this.складDataGridView.Size = new System.Drawing.Size(343, 182);
            this.складDataGridView.TabIndex = 27;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "IdСклад";
            this.dataGridViewTextBoxColumn15.HeaderText = "IdСклад";
            this.dataGridViewTextBoxColumn15.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.Width = 125;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "IdМісто";
            this.dataGridViewTextBoxColumn16.HeaderText = "IdМісто";
            this.dataGridViewTextBoxColumn16.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.Width = 125;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Адреса";
            this.dataGridViewTextBoxColumn17.HeaderText = "Адреса";
            this.dataGridViewTextBoxColumn17.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.Width = 125;
            // 
            // одиниця_вимірювання_кількостіBindingSource
            // 
            this.одиниця_вимірювання_кількостіBindingSource.DataMember = "Одиниця_вимірювання_кількості";
            this.одиниця_вимірювання_кількостіBindingSource.DataSource = this.dBCursDataSet;
            // 
            // одиниця_вимірювання_кількостіDataGridView
            // 
            this.одиниця_вимірювання_кількостіDataGridView.AutoGenerateColumns = false;
            this.одиниця_вимірювання_кількостіDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.одиниця_вимірювання_кількостіDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19});
            this.одиниця_вимірювання_кількостіDataGridView.DataSource = this.одиниця_вимірювання_кількостіBindingSource;
            this.одиниця_вимірювання_кількостіDataGridView.Location = new System.Drawing.Point(1233, 221);
            this.одиниця_вимірювання_кількостіDataGridView.Name = "одиниця_вимірювання_кількостіDataGridView";
            this.одиниця_вимірювання_кількостіDataGridView.RowHeadersVisible = false;
            this.одиниця_вимірювання_кількостіDataGridView.RowHeadersWidth = 51;
            this.одиниця_вимірювання_кількостіDataGridView.RowTemplate.Height = 24;
            this.одиниця_вимірювання_кількостіDataGridView.Size = new System.Drawing.Size(337, 159);
            this.одиниця_вимірювання_кількостіDataGridView.TabIndex = 28;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "IdОдиниця";
            this.dataGridViewTextBoxColumn18.HeaderText = "IdОдиниця";
            this.dataGridViewTextBoxColumn18.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.Width = 125;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "НазваОдиниці";
            this.dataGridViewTextBoxColumn19.HeaderText = "НазваОдиниці";
            this.dataGridViewTextBoxColumn19.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.Width = 125;
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(1582, 603);
            this.Controls.Add(this.одиниця_вимірювання_кількостіDataGridView);
            this.Controls.Add(this.складDataGridView);
            this.Controls.Add(this.країнаDataGridView);
            this.Controls.Add(this.сортDataGridView);
            this.Controls.Add(this.типDataGridView);
            this.Controls.Add(idПродуктуLabel);
            this.Controls.Add(this.idПродуктуTextBox);
            this.Controls.Add(idТипLabel);
            this.Controls.Add(this.idТипTextBox);
            this.Controls.Add(idСортLabel);
            this.Controls.Add(this.idСортTextBox);
            this.Controls.Add(idКраїнаLabel);
            this.Controls.Add(this.idКраїнаTextBox);
            this.Controls.Add(idСкладLabel);
            this.Controls.Add(this.idСкладTextBox);
            this.Controls.Add(idОдиницяLabel);
            this.Controls.Add(this.idОдиницяTextBox);
            this.Controls.Add(ціна_одиниці_продукту_ПДВLabel);
            this.Controls.Add(this.ціна_одиниці_продукту_ПДВTextBox);
            this.Controls.Add(ціна_одиниці_продукту_безПДВLabel);
            this.Controls.Add(this.ціна_одиниці_продукту_безПДВTextBox);
            this.Controls.Add(this.номенклатура_продуктуDataGridView);
            this.Controls.Add(this.номенклатура_продуктуBindingNavigator);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Product";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product";
            this.Load += new System.EventHandler(this.Product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dBCursDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.номенклатура_продуктуBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.номенклатура_продуктуBindingNavigator)).EndInit();
            this.номенклатура_продуктуBindingNavigator.ResumeLayout(false);
            this.номенклатура_продуктуBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.номенклатура_продуктуDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.типBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.типDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сортBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сортDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.складBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.країнаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.країнаDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.складDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.одиниця_вимірювання_кількостіBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.одиниця_вимірювання_кількостіDataGridView)).EndInit();
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
        private System.Windows.Forms.BindingSource номенклатура_продуктуBindingSource;
        private DBCursDataSetTableAdapters.Номенклатура_продуктуTableAdapter номенклатура_продуктуTableAdapter;
        private DBCursDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator номенклатура_продуктуBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton номенклатура_продуктуBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView номенклатура_продуктуDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DBCursDataSetTableAdapters.ТипTableAdapter типTableAdapter;
        private System.Windows.Forms.TextBox idПродуктуTextBox;
        private System.Windows.Forms.TextBox idТипTextBox;
        private System.Windows.Forms.TextBox idСортTextBox;
        private System.Windows.Forms.TextBox idКраїнаTextBox;
        private System.Windows.Forms.TextBox idСкладTextBox;
        private System.Windows.Forms.TextBox idОдиницяTextBox;
        private System.Windows.Forms.TextBox ціна_одиниці_продукту_ПДВTextBox;
        private System.Windows.Forms.TextBox ціна_одиниці_продукту_безПДВTextBox;
        private System.Windows.Forms.BindingSource типBindingSource;
        private DBCursDataSetTableAdapters.СортTableAdapter сортTableAdapter;
        private System.Windows.Forms.DataGridView типDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.BindingSource сортBindingSource;
        private DBCursDataSetTableAdapters.СкладTableAdapter складTableAdapter;
        private System.Windows.Forms.DataGridView сортDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.BindingSource складBindingSource;
        private DBCursDataSetTableAdapters.КраїнаTableAdapter країнаTableAdapter;
        private System.Windows.Forms.BindingSource країнаBindingSource;
        private DBCursDataSetTableAdapters.Одиниця_вимірювання_кількостіTableAdapter одиниця_вимірювання_кількостіTableAdapter;
        private System.Windows.Forms.DataGridView країнаDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridView складDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.BindingSource одиниця_вимірювання_кількостіBindingSource;
        private System.Windows.Forms.DataGridView одиниця_вимірювання_кількостіDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox tstBox1;
        private System.Windows.Forms.ToolStripButton tsbSearch1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox tstBox2;
        private System.Windows.Forms.ToolStripButton tsbSearch2;
        private System.Windows.Forms.ToolStripButton tsbReload;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}