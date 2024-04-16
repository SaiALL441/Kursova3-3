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

        private void Order_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBCursDataSet1.Постачальники". При необходимости она может быть перемещена или удалена.
            this.постачальникиTableAdapter1.Fill(this.dBCursDataSet1.Постачальники);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBCursDataSet2.Замовлення". При необходимости она может быть перемещена или удалена.
            this.замовленняTableAdapter.Fill(this.dBCursDataSet2.Замовлення);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBCursDataSet1.Номенклатура_продукту". При необходимости она может быть перемещена или удалена.
            this.номенклатура_продуктуTableAdapter.Fill(this.dBCursDataSet1.Номенклатура_продукту);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBCursDataSet1.Вміст_постачання". При необходимости она может быть перемещена или удалена.
            this.вміст_постачанняTableAdapter1.Fill(this.dBCursDataSet1.Вміст_постачання);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBCursDataSet1.Постачання". При необходимости она может быть перемещена или удалена.
            this.постачанняTableAdapter1.Fill(this.dBCursDataSet1.Постачання);

        }

       

        

     

       
       

        private void savePurchase_Click(object sender, EventArgs e)
        {
            вміст_постачанняBindingSource1.EndEdit();
            вміст_постачанняTableAdapter1.Update(dBCursDataSet1.Вміст_постачання);
            MessageBox.Show("Дані збережено.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void deletePurchase_Click(object sender, EventArgs e)
        {
            вміст_постачанняBindingSource1.RemoveCurrent();
        }

        private void buttonsave_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.постачанняBindingSource1.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.dBCursDataSet1);
            MessageBox.Show("Дані збережено.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void buttondelete_Click(object sender, EventArgs e)
        {
            постачанняBindingSource1.RemoveCurrent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.замовленняBindingSource.EndEdit();
            this.tableAdapterManager2.UpdateAll(this.dBCursDataSet2);
            MessageBox.Show("Дані збережено.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            замовленняBindingSource.RemoveCurrent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            постачальникиBindingSource1.Filter = "Найменування=\'" + textBox1.Text + "\'";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            постачальникиBindingSource1.Filter = null;
        }

        
    }
    }
    


