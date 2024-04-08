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
using System.IO;

namespace Kursova.Forms
{
    public partial class Person : Form
    {
        public Person()
        {
            InitializeComponent();
           
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

       
       

        private void постачальникиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.постачальникиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBCursDataSet);
            постачальникиBindingSource.EndEdit();
            dBCursDataSet.WriteXml($"{Application.StartupPath}/dataPerson.dat");
            
            MessageBox.Show("Дані збережено.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void Person_Load(object sender, EventArgs e)
        {
            
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBCursDataSet.Місто". При необходимости она может быть перемещена или удалена.
            this.містоTableAdapter.Fill(this.dBCursDataSet.Місто);
            
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBCursDataSet.Постачальники". При необходимости она может быть перемещена или удалена.
            this.постачальникиTableAdapter.Fill(this.dBCursDataSet.Постачальники);
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Product().Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Order().Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Menu().Show();
            this.Hide();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            
            
            містоBindingSource.Filter = "НазваМісто=\'" + toolStripTextBox1.Text + "\'";
           
            постачальникиBindingSource.Filter = "Найменування=\'" + toolStripTextBox1.Text + "\'";
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
           
            містоBindingSource.Filter = null;
            
            постачальникиBindingSource.Filter = null;
        }

       

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            містоBindingSource.Filter = "IdМісто=\'" + toolStripTextBox2.Text + "\'";
            
            постачальникиBindingSource.Filter = "IdПостачальника=\'" + toolStripTextBox2.Text + "\'";
            постачальникиBindingSource.Filter = "IdМісто=\'" + toolStripTextBox2.Text + "\'";
        }

        
        List<Forms.Person> lsItems = new List<Forms.Person>();
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
           if(lsItems.Count > 0)
                постачальникиBindingSource.RemoveAt(постачальникиDataGridView.CurrentRow.Index);
           
                
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }
    }
    }
    
        
    

