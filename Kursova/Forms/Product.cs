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
            this.номенклатура_продуктуBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBCursDataSet);
            номенклатура_продуктуBindingSource.EndEdit();
            dBCursDataSet.WriteXml($"{Application.StartupPath}/dataProduct.dat");

            MessageBox.Show("Дані збережено.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void Product_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBCursDataSet.Одиниця_вимірювання_кількості". При необходимости она может быть перемещена или удалена.
            this.одиниця_вимірювання_кількостіTableAdapter.Fill(this.dBCursDataSet.Одиниця_вимірювання_кількості);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBCursDataSet.Країна". При необходимости она может быть перемещена или удалена.
            this.країнаTableAdapter.Fill(this.dBCursDataSet.Країна);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBCursDataSet.Склад". При необходимости она может быть перемещена или удалена.
            this.складTableAdapter.Fill(this.dBCursDataSet.Склад);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBCursDataSet.Сорт". При необходимости она может быть перемещена или удалена.
            this.сортTableAdapter.Fill(this.dBCursDataSet.Сорт);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBCursDataSet.Тип". При необходимости она может быть перемещена или удалена.
            this.типTableAdapter.Fill(this.dBCursDataSet.Тип);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBCursDataSet.Номенклатура_продукту". При необходимости она может быть перемещена или удалена.
            this.номенклатура_продуктуTableAdapter.Fill(this.dBCursDataSet.Номенклатура_продукту);

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
            сортBindingSource.Filter = "НазваСорт=\'" + tstBox1.Text + "\'";
            типBindingSource.Filter = "НазваТип=\'" + tstBox1.Text + "\'";
            одиниця_вимірювання_кількостіBindingSource.Filter = "НазваОдиниці=\'" + tstBox1.Text + "\'";
            країнаBindingSource.Filter = "НазваКр=\'" + tstBox1.Text + "\'";

        }

        private void tsbReload_Click(object sender, EventArgs e)
        {
            номенклатура_продуктуBindingSource.Filter = null;
            типBindingSource.Filter = null;
            одиниця_вимірювання_кількостіBindingSource.Filter = null;
            країнаBindingSource.Filter = null;
            сортBindingSource.Filter = null;
            складBindingSource.Filter = null;
        }
        
        private void tsbSearch2_Click(object sender, EventArgs e)
        {
            номенклатура_продуктуBindingSource.Filter = "IdТип=\'" + tstBox2.Text + "\'";
            номенклатура_продуктуBindingSource.Filter = "IdСорт=\'" + tstBox2.Text + "\'";
            номенклатура_продуктуBindingSource.Filter = "IdКраїна=\'" + tstBox2.Text + "\'";
            номенклатура_продуктуBindingSource.Filter = "Ціна_одиниці_продукту_ПДВ=\'" + tstBox2.Text + "\'";
            номенклатура_продуктуBindingSource.Filter = "Ціна_одиниці_продукту_безПДВ=\'" + tstBox2.Text + "\'";


            типBindingSource.Filter = "IdТип=\'" + tstBox2.Text + "\'";
            сортBindingSource.Filter = "IdСорт=\'" + tstBox2.Text + "\'";
            складBindingSource.Filter = "IdСклад=\'" + tstBox2.Text + "\'";
            країнаBindingSource.Filter = "IdКраїна=\'" + tstBox2.Text + "\'";
            одиниця_вимірювання_кількостіBindingSource.Filter = "IdОдиниця=\'" + tstBox2.Text + "\'";
            


        }

        private void tstBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
                if (e.KeyChar == (char)13)

                номенклатура_продуктуBindingSource.Filter = $"Ціна_одиниці_продукту_безПДВ like '*{tstBox2.Text}*' or Ціна_одиниці_продукту_ПДВ like '*{tstBox2.Text}*'";
            
        }

        
    }
    
}
