using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Kursova.Forms
{
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
        }

        private void номенклатура_продуктуBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.номенклатура_продуктуBindingSource1.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.dBCursDataSet1);
            номенклатура_продуктуBindingSource1.EndEdit();
            dBCursDataSet1.WriteXml($"{Application.StartupPath}/dataProduct.dat");

            MessageBox.Show("Дані збережено.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void Product_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBCursDataSet1.Склад". При необходимости она может быть перемещена или удалена.
            this.складTableAdapter1.Fill(this.dBCursDataSet1.Склад);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBCursDataSet1.Країна". При необходимости она может быть перемещена или удалена.
            this.країнаTableAdapter1.Fill(this.dBCursDataSet1.Країна);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBCursDataSet1.Сорт". При необходимости она может быть перемещена или удалена.
            this.сортTableAdapter1.Fill(this.dBCursDataSet1.Сорт);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBCursDataSet1.Одиниця_вимірювання_кількості". При необходимости она может быть перемещена или удалена.
            this.одиниця_вимірювання_кількостіTableAdapter1.Fill(this.dBCursDataSet1.Одиниця_вимірювання_кількості);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBCursDataSet1.Тип". При необходимости она может быть перемещена или удалена.
            this.типTableAdapter1.Fill(this.dBCursDataSet1.Тип);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBCursDataSet1.Номенклатура_продукту". При необходимости она может быть перемещена или удалена.
            this.номенклатура_продуктуTableAdapter1.Fill(this.dBCursDataSet1.Номенклатура_продукту);
            

        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Menu().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Person().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Order().Show();
            this.Hide();
        }

        private void tsbSearch1_Click(object sender, EventArgs e)
        {
            сортBindingSource1.Filter = "НазваСорт=\'" + tstBox1.Text + "\'";
            типBindingSource1.Filter = "НазваТип=\'" + tstBox1.Text + "\'";
            одиниця_вимірювання_кількостіBindingSource1.Filter = "НазваОдиниці=\'" + tstBox1.Text + "\'";
            країнаBindingSource1.Filter = "НазваКр=\'" + tstBox1.Text + "\'";

        }

        private void tsbReload_Click(object sender, EventArgs e)
        {
            номенклатура_продуктуBindingSource1.Filter = null;
            типBindingSource1.Filter = null;
            одиниця_вимірювання_кількостіBindingSource1.Filter = null;
            країнаBindingSource1.Filter = null;
            сортBindingSource1.Filter = null;
            складBindingSource1.Filter = null;
        }
        
        private void tsbSearch2_Click(object sender, EventArgs e)
        {
            номенклатура_продуктуBindingSource1.Filter = "IdТип=\'" + tstBox2.Text + "\'";
            номенклатура_продуктуBindingSource1.Filter = "IdСорт=\'" + tstBox2.Text + "\'";
            номенклатура_продуктуBindingSource1.Filter = "IdКраїна=\'" + tstBox2.Text + "\'";
            номенклатура_продуктуBindingSource1.Filter = "Ціна_одиниці_продукту_ПДВ=\'" + tstBox2.Text + "\'";
            номенклатура_продуктуBindingSource1.Filter = "Ціна_одиниці_продукту_безПДВ=\'" + tstBox2.Text + "\'";


            типBindingSource1.Filter = "IdТип=\'" + tstBox2.Text + "\'";
            сортBindingSource1.Filter = "IdСорт=\'" + tstBox2.Text + "\'";
            складBindingSource1.Filter = "IdСклад=\'" + tstBox2.Text + "\'";
            країнаBindingSource1.Filter = "IdКраїна=\'" + tstBox2.Text + "\'";
            одиниця_вимірювання_кількостіBindingSource1.Filter = "IdОдиниця=\'" + tstBox2.Text + "\'";
            


        }

        private void tstBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
                if (e.KeyChar == (char)13)

                номенклатура_продуктуBindingSource1.Filter = $"Ціна_одиниці_продукту_безПДВ like '*{tstBox2.Text}*' or Ціна_одиниці_продукту_ПДВ like '*{tstBox2.Text}*'";
            
        }

        
    }
    
}
