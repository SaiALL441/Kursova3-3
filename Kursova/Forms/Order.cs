using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursova.Forms
{
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
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
            new Menu().Show();
            this.Hide();
        }

        private void вміст_постачанняBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.вміст_постачанняBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBCursDataSet);

        }

        private void Order_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBCursDataSet.Постачальники". При необходимости она может быть перемещена или удалена.
            this.постачальникиTableAdapter.Fill(this.dBCursDataSet.Постачальники);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBCursDataSet.Постачання". При необходимости она может быть перемещена или удалена.
            this.постачанняTableAdapter.Fill(this.dBCursDataSet.Постачання);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBCursDataSet.Вміст_постачання". При необходимости она может быть перемещена или удалена.
            this.вміст_постачанняTableAdapter.Fill(this.dBCursDataSet.Вміст_постачання);

        }

        
        

        private void button6_Click_1(object sender, EventArgs e)
        {
       
            постачальникиBindingSource.Filter = "Найменування=\'" + textBox1.Text + "\'";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            постачальникиBindingSource.Filter = null;
        }
    }
    }
    


