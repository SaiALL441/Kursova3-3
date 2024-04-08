using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursova
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtpass.UseSystemPasswordChar = true;
        }

        private void txtlog_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtpass.UseSystemPasswordChar = false;
            }

            else
            {
                txtpass.UseSystemPasswordChar = true;
            }
        }

        private void log_Click(object sender, EventArgs e)
        {
            if (txtlog.Text == "admin" && txtpass.Text == "1234")
            {
                new Forms.Menu().Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Неправильно введено логін чи пароль");

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
