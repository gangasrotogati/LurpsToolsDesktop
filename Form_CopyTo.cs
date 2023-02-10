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
    public partial class Form_CopyTo : Form
    {
        public int ProfileSelection;
        public Form_CopyTo()
        {
            InitializeComponent();
            foreach(Profile profile in Core.ProfilesList)
            {
                comboBox1.Items.Add(profile.ProfileName);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProfileSelection = comboBox1.SelectedIndex;
        }
    }
}
