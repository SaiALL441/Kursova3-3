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
            System.Windows.Forms.Label idПостачанняLabel2;
            System.Windows.Forms.Label idПостачальникаLabel1;
            System.Windows.Forms.Label датаВідправленняLabel1;
            System.Windows.Forms.Label датаОтриманняLabel1;
            System.Windows.Forms.Label статусПоставкиLabel1;
            System.Windows.Forms.Label idПостачанняLabel3;
            System.Windows.Forms.Label idПродуктуLabel1;
            System.Windows.Forms.Label кількістьLabel1;
            System.Windows.Forms.Label idЗамовленняLabel;
            System.Windows.Forms.Label idПродуктуLabel;
            System.Windows.Forms.Label кількістьLabel;
            System.Windows.Forms.Label датаОплатиLabel;
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
            this.постачанняBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.idПостачанняTextBox3 = new System.Windows.Forms.TextBox();
            this.вміст_постачанняBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dBCursDataSet1 = new Kursova.DBCursDataSet1();
            this.кількістьTextBox1 = new System.Windows.Forms.TextBox();
            this.idПродуктуTextBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.датаОтриманняDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.постачанняBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idПостачанняTextBox2 = new System.Windows.Forms.TextBox();
            this.статусПоставкиCheckBox = new System.Windows.Forms.CheckBox();
            this.idПостачальникаTextBox1 = new System.Windows.Forms.TextBox();
            this.датаВідправленняDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.постачальникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.постачальникиTableAdapter = new Kursova.DBCursDataSetTableAdapters.ПостачальникиTableAdapter();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.постачанняTableAdapter1 = new Kursova.DBCursDataSet1TableAdapters.ПостачанняTableAdapter();
            this.tableAdapterManager1 = new Kursova.DBCursDataSet1TableAdapters.TableAdapterManager();
            this.вміст_постачанняTableAdapter1 = new Kursova.DBCursDataSet1TableAdapters.Вміст_постачанняTableAdapter();
            this.постачанняDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.вміст_постачанняDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номенклатура_продуктуBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.номенклатура_продуктуTableAdapter = new Kursova.DBCursDataSet1TableAdapters.Номенклатура_продуктуTableAdapter();
            this.dBCursDataSet2 = new Kursova.DBCursDataSet2();
            this.замовленняBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.замовленняTableAdapter = new Kursova.DBCursDataSet2TableAdapters.ЗамовленняTableAdapter();
            this.tableAdapterManager2 = new Kursova.DBCursDataSet2TableAdapters.TableAdapterManager();
            this.замовленняDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.savePurchase = new System.Windows.Forms.Button();
            this.deletePurchase = new System.Windows.Forms.Button();
            this.buttonsave = new System.Windows.Forms.Button();
            this.buttondelete = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.idЗамовленняTextBox = new System.Windows.Forms.TextBox();
            this.idПродуктуTextBox = new System.Windows.Forms.TextBox();
            this.кількістьTextBox = new System.Windows.Forms.TextBox();
            this.датаОплатиDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.постачальникиBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.постачальникиTableAdapter1 = new Kursova.DBCursDataSet1TableAdapters.ПостачальникиTableAdapter();
            this.постачальникиDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idПостачанняLabel2 = new System.Windows.Forms.Label();
            idПостачальникаLabel1 = new System.Windows.Forms.Label();
            датаВідправленняLabel1 = new System.Windows.Forms.Label();
            датаОтриманняLabel1 = new System.Windows.Forms.Label();
            статусПоставкиLabel1 = new System.Windows.Forms.Label();
            idПостачанняLabel3 = new System.Windows.Forms.Label();
            idПродуктуLabel1 = new System.Windows.Forms.Label();
            кількістьLabel1 = new System.Windows.Forms.Label();
            idЗамовленняLabel = new System.Windows.Forms.Label();
            idПродуктуLabel = new System.Windows.Forms.Label();
            кількістьLabel = new System.Windows.Forms.Label();
            датаОплатиLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dBCursDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.вміст_постачанняBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.постачанняBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.вміст_постачанняBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBCursDataSet1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.постачанняBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.постачальникиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.постачанняDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.вміст_постачанняDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.номенклатура_продуктуBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBCursDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.замовленняBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.замовленняDataGridView)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.постачальникиBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.постачальникиDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idПостачанняLabel2
            // 
            idПостачанняLabel2.AutoSize = true;
            idПостачанняLabel2.Location = new System.Drawing.Point(15, 29);
            idПостачанняLabel2.Name = "idПостачанняLabel2";
            idПостачанняLabel2.Size = new System.Drawing.Size(110, 18);
            idПостачанняLabel2.TabIndex = 31;
            idПостачанняLabel2.Text = "Id Постачання:";
            // 
            // idПостачальникаLabel1
            // 
            idПостачальникаLabel1.AutoSize = true;
            idПостачальникаLabel1.Location = new System.Drawing.Point(15, 70);
            idПостачальникаLabel1.Name = "idПостачальникаLabel1";
            idПостачальникаLabel1.Size = new System.Drawing.Size(135, 18);
            idПостачальникаLabel1.TabIndex = 33;
            idПостачальникаLabel1.Text = "Id Постачальника:";
            // 
            // датаВідправленняLabel1
            // 
            датаВідправленняLabel1.AutoSize = true;
            датаВідправленняLabel1.Location = new System.Drawing.Point(13, 114);
            датаВідправленняLabel1.Name = "датаВідправленняLabel1";
            датаВідправленняLabel1.Size = new System.Drawing.Size(144, 18);
            датаВідправленняLabel1.TabIndex = 35;
            датаВідправленняLabel1.Text = "Дата відправлення:";
            // 
            // датаОтриманняLabel1
            // 
            датаОтриманняLabel1.AutoSize = true;
            датаОтриманняLabel1.Location = new System.Drawing.Point(13, 154);
            датаОтриманняLabel1.Name = "датаОтриманняLabel1";
            датаОтриманняLabel1.Size = new System.Drawing.Size(126, 18);
            датаОтриманняLabel1.TabIndex = 37;
            датаОтриманняLabel1.Text = "Дата отримання:";
            // 
            // статусПоставкиLabel1
            // 
            статусПоставкиLabel1.AutoSize = true;
            статусПоставкиLabel1.Location = new System.Drawing.Point(13, 210);
            статусПоставкиLabel1.Name = "статусПоставкиLabel1";
            статусПоставкиLabel1.Size = new System.Drawing.Size(128, 18);
            статусПоставкиLabel1.TabIndex = 39;
            статусПоставкиLabel1.Text = "Статус поставки:";
            // 
            // idПостачанняLabel3
            // 
            idПостачанняLabel3.AutoSize = true;
            idПостачанняLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            idПостачанняLabel3.Location = new System.Drawing.Point(30, 35);
            idПостачанняLabel3.Name = "idПостачанняLabel3";
            idПостачанняLabel3.Size = new System.Drawing.Size(110, 18);
            idПостачанняLabel3.TabIndex = 40;
            idПостачанняLabel3.Text = "Id Постачання:";
            // 
            // idПродуктуLabel1
            // 
            idПродуктуLabel1.AutoSize = true;
            idПродуктуLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            idПродуктуLabel1.Location = new System.Drawing.Point(30, 83);
            idПродуктуLabel1.Name = "idПродуктуLabel1";
            idПродуктуLabel1.Size = new System.Drawing.Size(93, 18);
            idПродуктуLabel1.TabIndex = 42;
            idПродуктуLabel1.Text = "Id Продукту:";
            // 
            // кількістьLabel1
            // 
            кількістьLabel1.AutoSize = true;
            кількістьLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            кількістьLabel1.Location = new System.Drawing.Point(30, 132);
            кількістьLabel1.Name = "кількістьLabel1";
            кількістьLabel1.Size = new System.Drawing.Size(76, 18);
            кількістьLabel1.TabIndex = 44;
            кількістьLabel1.Text = "Кількість:";
            // 
            // idЗамовленняLabel
            // 
            idЗамовленняLabel.AutoSize = true;
            idЗамовленняLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            idЗамовленняLabel.Location = new System.Drawing.Point(15, 27);
            idЗамовленняLabel.Name = "idЗамовленняLabel";
            idЗамовленняLabel.Size = new System.Drawing.Size(114, 18);
            idЗамовленняLabel.TabIndex = 38;
            idЗамовленняLabel.Text = "Id Замовлення:";
            // 
            // idПродуктуLabel
            // 
            idПродуктуLabel.AutoSize = true;
            idПродуктуLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            idПродуктуLabel.Location = new System.Drawing.Point(15, 62);
            idПродуктуLabel.Name = "idПродуктуLabel";
            idПродуктуLabel.Size = new System.Drawing.Size(93, 18);
            idПродуктуLabel.TabIndex = 40;
            idПродуктуLabel.Text = "Id Продукту:";
            // 
            // кількістьLabel
            // 
            кількістьLabel.AutoSize = true;
            кількістьLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            кількістьLabel.Location = new System.Drawing.Point(15, 100);
            кількістьLabel.Name = "кількістьLabel";
            кількістьLabel.Size = new System.Drawing.Size(76, 18);
            кількістьLabel.TabIndex = 42;
            кількістьLabel.Text = "Кількість:";
            // 
            // датаОплатиLabel
            // 
            датаОплатиLabel.AutoSize = true;
            датаОплатиLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            датаОплатиLabel.Location = new System.Drawing.Point(15, 140);
            датаОплатиLabel.Name = "датаОплатиLabel";
            датаОплатиLabel.Size = new System.Drawing.Size(100, 18);
            датаОплатиLabel.TabIndex = 44;
            датаОплатиLabel.Text = "Дата оплати:";
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
            // постачанняBindingSource
            // 
            this.постачанняBindingSource.DataMember = "Постачання";
            this.постачанняBindingSource.DataSource = this.dBCursDataSet;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.Controls.Add(idПостачанняLabel3);
            this.panel1.Controls.Add(this.idПостачанняTextBox3);
            this.panel1.Controls.Add(this.кількістьTextBox1);
            this.panel1.Controls.Add(idПродуктуLabel1);
            this.panel1.Controls.Add(кількістьLabel1);
            this.panel1.Controls.Add(this.idПродуктуTextBox1);
            this.panel1.Location = new System.Drawing.Point(209, 384);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(313, 179);
            this.panel1.TabIndex = 27;
            // 
            // idПостачанняTextBox3
            // 
            this.idПостачанняTextBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.вміст_постачанняBindingSource1, "IdПостачання", true));
            this.idПостачанняTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idПостачанняTextBox3.Location = new System.Drawing.Point(175, 32);
            this.idПостачанняTextBox3.Name = "idПостачанняTextBox3";
            this.idПостачанняTextBox3.Size = new System.Drawing.Size(100, 24);
            this.idПостачанняTextBox3.TabIndex = 41;
            // 
            // вміст_постачанняBindingSource1
            // 
            this.вміст_постачанняBindingSource1.DataMember = "Вміст_постачання";
            this.вміст_постачанняBindingSource1.DataSource = this.dBCursDataSet1;
            // 
            // dBCursDataSet1
            // 
            this.dBCursDataSet1.DataSetName = "DBCursDataSet1";
            this.dBCursDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // кількістьTextBox1
            // 
            this.кількістьTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.вміст_постачанняBindingSource1, "Кількість", true));
            this.кількістьTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.кількістьTextBox1.Location = new System.Drawing.Point(175, 129);
            this.кількістьTextBox1.Name = "кількістьTextBox1";
            this.кількістьTextBox1.Size = new System.Drawing.Size(100, 24);
            this.кількістьTextBox1.TabIndex = 45;
            // 
            // idПродуктуTextBox1
            // 
            this.idПродуктуTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.вміст_постачанняBindingSource1, "IdПродукту", true));
            this.idПродуктуTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idПродуктуTextBox1.Location = new System.Drawing.Point(175, 77);
            this.idПродуктуTextBox1.Name = "idПродуктуTextBox1";
            this.idПродуктуTextBox1.Size = new System.Drawing.Size(100, 24);
            this.idПродуктуTextBox1.TabIndex = 43;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel2.Controls.Add(idПостачанняLabel2);
            this.panel2.Controls.Add(this.датаОтриманняDateTimePicker1);
            this.panel2.Controls.Add(this.idПостачанняTextBox2);
            this.panel2.Controls.Add(this.статусПоставкиCheckBox);
            this.panel2.Controls.Add(idПостачальникаLabel1);
            this.panel2.Controls.Add(статусПоставкиLabel1);
            this.panel2.Controls.Add(this.idПостачальникаTextBox1);
            this.panel2.Controls.Add(датаОтриманняLabel1);
            this.panel2.Controls.Add(датаВідправленняLabel1);
            this.panel2.Controls.Add(this.датаВідправленняDateTimePicker1);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel2.Location = new System.Drawing.Point(209, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(389, 256);
            this.panel2.TabIndex = 28;
            // 
            // датаОтриманняDateTimePicker1
            // 
            this.датаОтриманняDateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.постачанняBindingSource1, "ДатаОтримання", true));
            this.датаОтриманняDateTimePicker1.Location = new System.Drawing.Point(175, 154);
            this.датаОтриманняDateTimePicker1.Name = "датаОтриманняDateTimePicker1";
            this.датаОтриманняDateTimePicker1.Size = new System.Drawing.Size(200, 24);
            this.датаОтриманняDateTimePicker1.TabIndex = 38;
            // 
            // постачанняBindingSource1
            // 
            this.постачанняBindingSource1.DataMember = "Постачання";
            this.постачанняBindingSource1.DataSource = this.dBCursDataSet1;
            // 
            // idПостачанняTextBox2
            // 
            this.idПостачанняTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.постачанняBindingSource1, "IdПостачання", true));
            this.idПостачанняTextBox2.Location = new System.Drawing.Point(175, 29);
            this.idПостачанняTextBox2.Name = "idПостачанняTextBox2";
            this.idПостачанняTextBox2.Size = new System.Drawing.Size(72, 24);
            this.idПостачанняTextBox2.TabIndex = 32;
            // 
            // статусПоставкиCheckBox
            // 
            this.статусПоставкиCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.постачанняBindingSource1, "СтатусПоставки", true));
            this.статусПоставкиCheckBox.Location = new System.Drawing.Point(175, 210);
            this.статусПоставкиCheckBox.Name = "статусПоставкиCheckBox";
            this.статусПоставкиCheckBox.Size = new System.Drawing.Size(200, 24);
            this.статусПоставкиCheckBox.TabIndex = 40;
            this.статусПоставкиCheckBox.Text = "поставлено";
            this.статусПоставкиCheckBox.UseVisualStyleBackColor = true;
            // 
            // idПостачальникаTextBox1
            // 
            this.idПостачальникаTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.постачанняBindingSource1, "IdПостачальника", true));
            this.idПостачальникаTextBox1.Location = new System.Drawing.Point(175, 70);
            this.idПостачальникаTextBox1.Name = "idПостачальникаTextBox1";
            this.idПостачальникаTextBox1.Size = new System.Drawing.Size(72, 24);
            this.idПостачальникаTextBox1.TabIndex = 34;
            // 
            // датаВідправленняDateTimePicker1
            // 
            this.датаВідправленняDateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.постачанняBindingSource1, "ДатаВідправлення", true));
            this.датаВідправленняDateTimePicker1.Location = new System.Drawing.Point(175, 114);
            this.датаВідправленняDateTimePicker1.Name = "датаВідправленняDateTimePicker1";
            this.датаВідправленняDateTimePicker1.Size = new System.Drawing.Size(200, 24);
            this.датаВідправленняDateTimePicker1.TabIndex = 36;
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
            // button6
            // 
            this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.Location = new System.Drawing.Point(1374, 369);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(36, 30);
            this.button6.TabIndex = 29;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1416, 375);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(197, 22);
            this.textBox1.TabIndex = 30;
            // 
            // button7
            // 
            this.button7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button7.BackgroundImage")));
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.Location = new System.Drawing.Point(1332, 369);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(36, 30);
            this.button7.TabIndex = 31;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // постачанняTableAdapter1
            // 
            this.постачанняTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.UpdateOrder = Kursova.DBCursDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.Вміст_постачанняTableAdapter = this.вміст_постачанняTableAdapter1;
            this.tableAdapterManager1.ЗамовленняTableAdapter = null;
            this.tableAdapterManager1.КраїнаTableAdapter = null;
            this.tableAdapterManager1.МістоTableAdapter = null;
            this.tableAdapterManager1.Номенклатура_продуктуTableAdapter = null;
            this.tableAdapterManager1.Одиниця_вимірювання_кількостіTableAdapter = null;
            this.tableAdapterManager1.ПостачальникиTableAdapter = null;
            this.tableAdapterManager1.ПостачанняTableAdapter = this.постачанняTableAdapter1;
            this.tableAdapterManager1.СкладTableAdapter = null;
            this.tableAdapterManager1.СортTableAdapter = null;
            this.tableAdapterManager1.ТипTableAdapter = null;
            // 
            // вміст_постачанняTableAdapter1
            // 
            this.вміст_постачанняTableAdapter1.ClearBeforeFill = true;
            // 
            // постачанняDataGridView
            // 
            this.постачанняDataGridView.AutoGenerateColumns = false;
            this.постачанняDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.постачанняDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewCheckBoxColumn1});
            this.постачанняDataGridView.DataSource = this.постачанняBindingSource1;
            this.постачанняDataGridView.Location = new System.Drawing.Point(616, 51);
            this.постачанняDataGridView.Name = "постачанняDataGridView";
            this.постачанняDataGridView.RowHeadersVisible = false;
            this.постачанняDataGridView.RowHeadersWidth = 51;
            this.постачанняDataGridView.RowTemplate.Height = 24;
            this.постачанняDataGridView.Size = new System.Drawing.Size(579, 282);
            this.постачанняDataGridView.TabIndex = 31;
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "IdПостачальника";
            this.dataGridViewTextBoxColumn2.HeaderText = "IdПостачальника";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ДатаВідправлення";
            this.dataGridViewTextBoxColumn3.HeaderText = "ДатаВідправлення";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ДатаОтримання";
            this.dataGridViewTextBoxColumn4.HeaderText = "ДатаОтримання";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "СтатусПоставки";
            this.dataGridViewCheckBoxColumn1.HeaderText = "СтатусПоставки";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 125;
            // 
            // вміст_постачанняDataGridView
            // 
            this.вміст_постачанняDataGridView.AutoGenerateColumns = false;
            this.вміст_постачанняDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.вміст_постачанняDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.вміст_постачанняDataGridView.DataSource = this.вміст_постачанняBindingSource1;
            this.вміст_постачанняDataGridView.Location = new System.Drawing.Point(635, 394);
            this.вміст_постачанняDataGridView.Name = "вміст_постачанняDataGridView";
            this.вміст_постачанняDataGridView.RowHeadersVisible = false;
            this.вміст_постачанняDataGridView.RowHeadersWidth = 51;
            this.вміст_постачанняDataGridView.RowTemplate.Height = 24;
            this.вміст_постачанняDataGridView.Size = new System.Drawing.Size(551, 256);
            this.вміст_постачанняDataGridView.TabIndex = 31;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "IdПостачання";
            this.dataGridViewTextBoxColumn5.HeaderText = "IdПостачання";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "IdПродукту";
            this.dataGridViewTextBoxColumn6.HeaderText = "IdПродукту";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Кількість";
            this.dataGridViewTextBoxColumn7.HeaderText = "Кількість";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // номенклатура_продуктуBindingSource
            // 
            this.номенклатура_продуктуBindingSource.DataMember = "Номенклатура_продукту";
            this.номенклатура_продуктуBindingSource.DataSource = this.dBCursDataSet1;
            // 
            // номенклатура_продуктуTableAdapter
            // 
            this.номенклатура_продуктуTableAdapter.ClearBeforeFill = true;
            // 
            // dBCursDataSet2
            // 
            this.dBCursDataSet2.DataSetName = "DBCursDataSet2";
            this.dBCursDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // замовленняBindingSource
            // 
            this.замовленняBindingSource.DataMember = "Замовлення";
            this.замовленняBindingSource.DataSource = this.dBCursDataSet2;
            // 
            // замовленняTableAdapter
            // 
            this.замовленняTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager2
            // 
            this.tableAdapterManager2.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager2.UpdateOrder = Kursova.DBCursDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager2.ЗамовленняTableAdapter = this.замовленняTableAdapter;
            // 
            // замовленняDataGridView
            // 
            this.замовленняDataGridView.AutoGenerateColumns = false;
            this.замовленняDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.замовленняDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19});
            this.замовленняDataGridView.DataSource = this.замовленняBindingSource;
            this.замовленняDataGridView.Location = new System.Drawing.Point(1536, 51);
            this.замовленняDataGridView.Name = "замовленняDataGridView";
            this.замовленняDataGridView.RowHeadersVisible = false;
            this.замовленняDataGridView.RowHeadersWidth = 51;
            this.замовленняDataGridView.RowTemplate.Height = 24;
            this.замовленняDataGridView.Size = new System.Drawing.Size(386, 271);
            this.замовленняDataGridView.TabIndex = 32;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "IdЗамовлення";
            this.dataGridViewTextBoxColumn16.HeaderText = "IdЗамовлення";
            this.dataGridViewTextBoxColumn16.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.Width = 125;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "IdПродукту";
            this.dataGridViewTextBoxColumn17.HeaderText = "IdПродукту";
            this.dataGridViewTextBoxColumn17.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.Width = 125;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "Кількість";
            this.dataGridViewTextBoxColumn18.HeaderText = "Кількість";
            this.dataGridViewTextBoxColumn18.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.Width = 125;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "ДатаОплати";
            this.dataGridViewTextBoxColumn19.HeaderText = "ДатаОплати";
            this.dataGridViewTextBoxColumn19.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.Width = 125;
            // 
            // savePurchase
            // 
            this.savePurchase.BackColor = System.Drawing.Color.LemonChiffon;
            this.savePurchase.Location = new System.Drawing.Point(409, 596);
            this.savePurchase.Name = "savePurchase";
            this.savePurchase.Size = new System.Drawing.Size(113, 38);
            this.savePurchase.TabIndex = 33;
            this.savePurchase.Text = "Зберегти";
            this.savePurchase.UseVisualStyleBackColor = false;
            this.savePurchase.Click += new System.EventHandler(this.savePurchase_Click);
            // 
            // deletePurchase
            // 
            this.deletePurchase.BackColor = System.Drawing.Color.LemonChiffon;
            this.deletePurchase.Location = new System.Drawing.Point(237, 596);
            this.deletePurchase.Name = "deletePurchase";
            this.deletePurchase.Size = new System.Drawing.Size(113, 38);
            this.deletePurchase.TabIndex = 34;
            this.deletePurchase.Text = "Видалити";
            this.deletePurchase.UseVisualStyleBackColor = false;
            this.deletePurchase.Click += new System.EventHandler(this.deletePurchase_Click);
            // 
            // buttonsave
            // 
            this.buttonsave.BackColor = System.Drawing.Color.LemonChiffon;
            this.buttonsave.Location = new System.Drawing.Point(409, 295);
            this.buttonsave.Name = "buttonsave";
            this.buttonsave.Size = new System.Drawing.Size(113, 38);
            this.buttonsave.TabIndex = 35;
            this.buttonsave.Text = "Зберегти";
            this.buttonsave.UseVisualStyleBackColor = false;
            this.buttonsave.Click += new System.EventHandler(this.buttonsave_Click);
            // 
            // buttondelete
            // 
            this.buttondelete.BackColor = System.Drawing.Color.LemonChiffon;
            this.buttondelete.Location = new System.Drawing.Point(241, 295);
            this.buttondelete.Name = "buttondelete";
            this.buttondelete.Size = new System.Drawing.Size(113, 38);
            this.buttondelete.TabIndex = 36;
            this.buttondelete.Text = "Видалити";
            this.buttondelete.UseVisualStyleBackColor = false;
            this.buttondelete.Click += new System.EventHandler(this.buttondelete_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.LemonChiffon;
            this.button8.Location = new System.Drawing.Point(1250, 255);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(113, 38);
            this.button8.TabIndex = 37;
            this.button8.Text = "Видалити";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.LemonChiffon;
            this.button9.Location = new System.Drawing.Point(1403, 255);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(113, 38);
            this.button9.TabIndex = 38;
            this.button9.Text = "Зберегти";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // idЗамовленняTextBox
            // 
            this.idЗамовленняTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.замовленняBindingSource, "IdЗамовлення", true));
            this.idЗамовленняTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idЗамовленняTextBox.Location = new System.Drawing.Point(143, 24);
            this.idЗамовленняTextBox.Name = "idЗамовленняTextBox";
            this.idЗамовленняTextBox.Size = new System.Drawing.Size(103, 24);
            this.idЗамовленняTextBox.TabIndex = 39;
            // 
            // idПродуктуTextBox
            // 
            this.idПродуктуTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.замовленняBindingSource, "IdПродукту", true));
            this.idПродуктуTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idПродуктуTextBox.Location = new System.Drawing.Point(143, 59);
            this.idПродуктуTextBox.Name = "idПродуктуTextBox";
            this.idПродуктуTextBox.Size = new System.Drawing.Size(103, 24);
            this.idПродуктуTextBox.TabIndex = 41;
            // 
            // кількістьTextBox
            // 
            this.кількістьTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.замовленняBindingSource, "Кількість", true));
            this.кількістьTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.кількістьTextBox.Location = new System.Drawing.Point(143, 94);
            this.кількістьTextBox.Name = "кількістьTextBox";
            this.кількістьTextBox.Size = new System.Drawing.Size(103, 24);
            this.кількістьTextBox.TabIndex = 43;
            // 
            // датаОплатиDateTimePicker
            // 
            this.датаОплатиDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.замовленняBindingSource, "ДатаОплати", true));
            this.датаОплатиDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.датаОплатиDateTimePicker.Location = new System.Drawing.Point(143, 136);
            this.датаОплатиDateTimePicker.Name = "датаОплатиDateTimePicker";
            this.датаОплатиDateTimePicker.Size = new System.Drawing.Size(167, 24);
            this.датаОплатиDateTimePicker.TabIndex = 45;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel3.Controls.Add(this.idПродуктуTextBox);
            this.panel3.Controls.Add(idЗамовленняLabel);
            this.panel3.Controls.Add(this.датаОплатиDateTimePicker);
            this.panel3.Controls.Add(this.idЗамовленняTextBox);
            this.panel3.Controls.Add(датаОплатиLabel);
            this.panel3.Controls.Add(idПродуктуLabel);
            this.panel3.Controls.Add(this.кількістьTextBox);
            this.panel3.Controls.Add(кількістьLabel);
            this.panel3.Location = new System.Drawing.Point(1218, 51);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(313, 179);
            this.panel3.TabIndex = 46;
            // 
            // постачальникиBindingSource1
            // 
            this.постачальникиBindingSource1.DataMember = "Постачальники";
            this.постачальникиBindingSource1.DataSource = this.dBCursDataSet1;
            // 
            // постачальникиTableAdapter1
            // 
            this.постачальникиTableAdapter1.ClearBeforeFill = true;
            // 
            // постачальникиDataGridView
            // 
            this.постачальникиDataGridView.AutoGenerateColumns = false;
            this.постачальникиDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.постачальникиDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13});
            this.постачальникиDataGridView.DataSource = this.постачальникиBindingSource1;
            this.постачальникиDataGridView.Location = new System.Drawing.Point(1324, 414);
            this.постачальникиDataGridView.Name = "постачальникиDataGridView";
            this.постачальникиDataGridView.RowHeadersVisible = false;
            this.постачальникиDataGridView.RowHeadersWidth = 51;
            this.постачальникиDataGridView.RowTemplate.Height = 24;
            this.постачальникиDataGridView.Size = new System.Drawing.Size(418, 220);
            this.постачальникиDataGridView.TabIndex = 46;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "IdПостачальника";
            this.dataGridViewTextBoxColumn8.HeaderText = "IdПостачальника";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Найменування";
            this.dataGridViewTextBoxColumn9.HeaderText = "Найменування";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Телефон";
            this.dataGridViewTextBoxColumn10.HeaderText = "Телефон";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Visible = false;
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "ЕРДПОУ";
            this.dataGridViewTextBoxColumn11.HeaderText = "ЕРДПОУ";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Visible = false;
            this.dataGridViewTextBoxColumn11.Width = 125;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Адреса";
            this.dataGridViewTextBoxColumn12.HeaderText = "Адреса";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Visible = false;
            this.dataGridViewTextBoxColumn12.Width = 125;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "IdМісто";
            this.dataGridViewTextBoxColumn13.HeaderText = "IdМісто";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Width = 125;
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(1924, 760);
            this.Controls.Add(this.постачальникиDataGridView);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.buttondelete);
            this.Controls.Add(this.buttonsave);
            this.Controls.Add(this.deletePurchase);
            this.Controls.Add(this.savePurchase);
            this.Controls.Add(this.замовленняDataGridView);
            this.Controls.Add(this.вміст_постачанняDataGridView);
            this.Controls.Add(this.постачанняDataGridView);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Order";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dBCursDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.вміст_постачанняBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.постачанняBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.вміст_постачанняBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBCursDataSet1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.постачанняBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.постачальникиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.постачанняDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.вміст_постачанняDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.номенклатура_продуктуBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBCursDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.замовленняBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.замовленняDataGridView)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.постачальникиBindingSource1)).EndInit();
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
        private DBCursDataSetTableAdapters.ПостачанняTableAdapter постачанняTableAdapter;
        private System.Windows.Forms.BindingSource постачанняBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.BindingSource постачальникиBindingSource;
        private DBCursDataSetTableAdapters.ПостачальникиTableAdapter постачальникиTableAdapter;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button7;
        private DBCursDataSet1 dBCursDataSet1;
        private System.Windows.Forms.BindingSource постачанняBindingSource1;
        private DBCursDataSet1TableAdapters.ПостачанняTableAdapter постачанняTableAdapter1;
        private DBCursDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView постачанняDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private DBCursDataSet1TableAdapters.Вміст_постачанняTableAdapter вміст_постачанняTableAdapter1;
        private System.Windows.Forms.TextBox idПостачанняTextBox2;
        private System.Windows.Forms.TextBox idПостачальникаTextBox1;
        private System.Windows.Forms.DateTimePicker датаВідправленняDateTimePicker1;
        private System.Windows.Forms.DateTimePicker датаОтриманняDateTimePicker1;
        private System.Windows.Forms.CheckBox статусПоставкиCheckBox;
        private System.Windows.Forms.BindingSource вміст_постачанняBindingSource1;
        private System.Windows.Forms.TextBox idПостачанняTextBox3;
        private System.Windows.Forms.TextBox кількістьTextBox1;
        private System.Windows.Forms.TextBox idПродуктуTextBox1;
        private System.Windows.Forms.DataGridView вміст_постачанняDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.BindingSource номенклатура_продуктуBindingSource;
        private DBCursDataSet1TableAdapters.Номенклатура_продуктуTableAdapter номенклатура_продуктуTableAdapter;
        private DBCursDataSet2 dBCursDataSet2;
        private System.Windows.Forms.BindingSource замовленняBindingSource;
        private DBCursDataSet2TableAdapters.ЗамовленняTableAdapter замовленняTableAdapter;
        private DBCursDataSet2TableAdapters.TableAdapterManager tableAdapterManager2;
        private System.Windows.Forms.DataGridView замовленняDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.Button savePurchase;
        private System.Windows.Forms.Button deletePurchase;
        private System.Windows.Forms.Button buttonsave;
        private System.Windows.Forms.Button buttondelete;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TextBox idЗамовленняTextBox;
        private System.Windows.Forms.TextBox idПродуктуTextBox;
        private System.Windows.Forms.TextBox кількістьTextBox;
        private System.Windows.Forms.DateTimePicker датаОплатиDateTimePicker;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.BindingSource постачальникиBindingSource1;
        private DBCursDataSet1TableAdapters.ПостачальникиTableAdapter постачальникиTableAdapter1;
        private System.Windows.Forms.DataGridView постачальникиDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
    }
}