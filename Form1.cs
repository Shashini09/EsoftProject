using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skin_Clinic___Booking_System_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Username;
            string Password;

            Username = textBox1.Text;
            Password = textBox2.Text;

            if (Username == "admin" && Password == "admin@123")
            {
                this.Hide();
                Form2 fr = new Form2();
                fr.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
