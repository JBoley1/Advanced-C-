using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Forms_Events
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Button.Click += Button1_myLabel2;
        }

        private void Button1_myLabel2(object sender, EventArgs e)
        {
            myLabel2.Text = "Hello Once Again!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            myLabel.Text = "Hello World!";
        }
    }
}
