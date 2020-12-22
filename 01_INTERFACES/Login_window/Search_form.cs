using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_window
{
    public partial class Search_form : Form
    {
        public Search_form()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Search_form_Load(object sender, EventArgs e)
        {

        }

        private void button_LogIn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 loginWindow = new Form1();
            loginWindow.Show();
        }
    }
}
