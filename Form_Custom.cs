using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LurpsTools
{
    public partial class Form_Custom : Form
    {
        public string response;

        public Form_Custom(string message)
        {
            InitializeComponent();
            label_Message.Text = message;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            response = textBox1.Text;
        }
    }
}
