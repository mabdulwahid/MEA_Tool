using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEA_Test
{
    public partial class Form1 : Form
    {
        private void InitializeComboBox()
        {
            string[] aircraft = new string[] { "A350", "B787", "Other" };
            comboBox1.Items.AddRange(aircraft);
        }

        public Form1()
        {
            InitializeComponent();

            InitializeComboBox();
        }

        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
