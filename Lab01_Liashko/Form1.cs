using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01_Liashko
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            if (textBox_login.Text == "Dmytro" && textBox_password.Text == "123")
            {
                label_ok.BackColor = Color.Green;
                MessageBox.Show("Hello, Dmytro");
            }
            else
            {
                label_ok.BackColor = Color.Red;
                MessageBox.Show("error login or password");
            }
        }
    }
}
