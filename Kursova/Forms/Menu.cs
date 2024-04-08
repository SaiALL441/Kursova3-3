using FastReport.Design;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Kursova.Forms
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=lanister;Initial Catalog=DBCurs;Integrated Security=True");

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Product().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Person().Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Order().Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void містоBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.містоBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBCursDataSet);

        }

        private void Menu_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBCursDataSet.Країна". При необходимости она может быть перемещена или удалена.
            this.країнаTableAdapter.Fill(this.dBCursDataSet.Країна);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBCursDataSet.Одиниця_вимірювання_кількості". При необходимости она может быть перемещена или удалена.
            this.одиниця_вимірювання_кількостіTableAdapter.Fill(this.dBCursDataSet.Одиниця_вимірювання_кількості);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBCursDataSet.Сорт". При необходимости она может быть перемещена или удалена.
            this.сортTableAdapter.Fill(this.dBCursDataSet.Сорт);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBCursDataSet.Тип". При необходимости она может быть перемещена или удалена.
            this.типTableAdapter.Fill(this.dBCursDataSet.Тип);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBCursDataSet.Місто". При необходимости она может быть перемещена или удалена.
            this.містоTableAdapter.Fill(this.dBCursDataSet.Місто);

        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            містоBindingSource.EndEdit();
            містоTableAdapter.Update(dBCursDataSet.Місто);
        }

        private void deletebt_Click(object sender, EventArgs e)
        {
            містоBindingSource.RemoveCurrent();
          
        }

        private void button6_Click(object sender, EventArgs e)
        {
            типBindingSource.EndEdit();
            типTableAdapter.Update(dBCursDataSet.Тип);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            типBindingSource.RemoveCurrent();
        }

        private void saveSort_Click(object sender, EventArgs e)
        {
            сортBindingSource.EndEdit();
            сортTableAdapter.Update(dBCursDataSet.Сорт);
        }

        private void deleteSort_Click(object sender, EventArgs e)
        {
            сортBindingSource.RemoveCurrent();
        }

        private void saveQ_Click(object sender, EventArgs e)
        {
            одиниця_вимірювання_кількостіBindingSource.EndEdit();
            одиниця_вимірювання_кількостіTableAdapter.Update(dBCursDataSet.Одиниця_вимірювання_кількості);
        }

        private void deleteQ_Click(object sender, EventArgs e)
        {
            
            одиниця_вимірювання_кількостіBindingSource.RemoveCurrent();
        }

        private void saveCountry_Click(object sender, EventArgs e)
        {
            країнаBindingSource.EndEdit();
            країнаTableAdapter.Update(dBCursDataSet.Країна);
        }

        private void deleteCountry_Click(object sender, EventArgs e)
        {
            країнаBindingSource.RemoveCurrent();
        }
    }
}
