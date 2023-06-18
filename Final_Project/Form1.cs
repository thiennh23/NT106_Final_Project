using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Server sv = new Server();
            sv.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu mn = new Menu();
            mn.Show();
        }
    }
}
