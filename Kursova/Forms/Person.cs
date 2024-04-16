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
            this.постачальникиBindingSource1.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.dBCursDataSet1);
            постачальникиBindingSource1.EndEdit();
            dBCursDataSet1.WriteXml($"{Application.StartupPath}/dataPerson.dat");
            
            MessageBox.Show("Дані збережено.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void Person_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBCursDataSet1.Постачальники". При необходимости она может быть перемещена или удалена.
            this.постачальникиTableAdapter1.Fill(this.dBCursDataSet1.Постачальники);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBCursDataSet1.Місто". При необходимости она может быть перемещена или удалена.
            this.містоTableAdapter1.Fill(this.dBCursDataSet1.Місто);

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
            
            
            містоBindingSource1.Filter = "НазваМісто=\'" + toolStripTextBox1.Text + "\'";
           
            постачальникиBindingSource1.Filter = "Найменування=\'" + toolStripTextBox1.Text + "\'";
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
           
            містоBindingSource1.Filter = null;
            
            постачальникиBindingSource1.Filter = null;
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

        private void адресаLabel_Click(object sender, EventArgs e)
        {

        }
    }
    }
    
        
    

