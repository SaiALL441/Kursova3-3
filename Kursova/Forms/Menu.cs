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
        SqlConnection con = new SqlConnection(@"Data Source=lanister;Initial Catalog=DBCurs;User ID=sa;Password=***********");

        private void Menu_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBCursDataSet1.Країна". При необходимости она может быть перемещена или удалена.
            this.країнаTableAdapter1.Fill(this.dBCursDataSet1.Країна);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBCursDataSet1.Одиниця_вимірювання_кількості". При необходимости она может быть перемещена или удалена.
            this.одиниця_вимірювання_кількостіTableAdapter1.Fill(this.dBCursDataSet1.Одиниця_вимірювання_кількості);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBCursDataSet1.Сорт". При необходимости она может быть перемещена или удалена.
            this.сортTableAdapter1.Fill(this.dBCursDataSet1.Сорт);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBCursDataSet1.Місто". При необходимости она может быть перемещена или удалена.
            this.містоTableAdapter1.Fill(this.dBCursDataSet1.Місто);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBCursDataSet1.Тип". При необходимости она может быть перемещена или удалена.
            this.типTableAdapter1.Fill(this.dBCursDataSet1.Тип);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Order().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Person().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Product().Show();
            this.Hide();
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            містоBindingSource1.EndEdit();
            містоTableAdapter1.Update(dBCursDataSet1.Місто);
        }

        private void deletebt_Click(object sender, EventArgs e)
        {
            містоBindingSource1.RemoveCurrent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            типBindingSource1.EndEdit();
            типTableAdapter1.Update(dBCursDataSet1.Тип);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            типBindingSource1.RemoveCurrent();
        }

        private void saveSort_Click(object sender, EventArgs e)
        {
            сортBindingSource1.EndEdit();
            сортTableAdapter1.Update(dBCursDataSet1.Сорт);
        }

        private void deleteSort_Click(object sender, EventArgs e)
        {
            сортBindingSource1.RemoveCurrent();
        }

        private void saveQ_Click(object sender, EventArgs e)
        {
            одиниця_вимірювання_кількостіBindingSource1.EndEdit();
            одиниця_вимірювання_кількостіTableAdapter1.Update(dBCursDataSet1.Одиниця_вимірювання_кількості);
        }

        private void deleteQ_Click(object sender, EventArgs e)
        {
            одиниця_вимірювання_кількостіBindingSource1.RemoveCurrent();
        }

        private void saveCountry_Click(object sender, EventArgs e)
        {
            країнаBindingSource1.EndEdit();
            країнаTableAdapter1.Update(dBCursDataSet1.Країна);
        }

        private void deleteCountry_Click(object sender, EventArgs e)
        {
            країнаBindingSource1.RemoveCurrent();
        }
    }
}