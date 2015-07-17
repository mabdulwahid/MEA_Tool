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
        int EPSCurrent;

        

        private void InitializeComboBox()
        {
            string[] aircraft = new string[] { "A350", "B787", "Other" };
            comboBox1.Items.AddRange(aircraft);

            string[] calcMethod = new string[] { "Calculation Method 1", 
                "Calculation Method 2", "Calculation Method 3" };

            
            //inserting calculation method options for the output combo boxes
            foreach (Control control in groupBox2.Controls)
            {
                ComboBox calcLabel = control as ComboBox;

                if (calcLabel != null)
                {
                    calcLabel.Items.AddRange(calcMethod);
                }
            }
                        

            //options for input combo boxes
            comboBox8.Items.Add("Aircraft");
            comboBox9.Items.Add("Aircraft");
            comboBox10.Items.Add("Aircraft");
            //comboBox11.Items.Add("Engines");
            comboBox12.Items.Add("Engines");


        }

        public Form1()
        {
            InitializeComponent();

            InitializeComboBox();
        }

        //attempt to make a calculation method
        private void CalculationMethod()
        {
            
        }
        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            EPSCurrent = Convert.ToInt32(textBox1.Text);
        }

        //when input box checked, enable/disable textboxes and comboboxes in EPS
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox1.Enabled = true;
                comboBox8.Enabled = false;
            }
            else
            {
                textBox1.Enabled = false;
                comboBox8.Enabled = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                textBox2.Enabled = true;
                comboBox9.Enabled = false;
            }
            else
            {
                textBox2.Enabled = false;
                comboBox9.Enabled = true;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                textBox3.Enabled = true;
                comboBox10.Enabled = false;
            }
            else
            {
                textBox3.Enabled = false;
                comboBox10.Enabled = true;
            }
        }
        
        //hardcode example for EPS parameter
        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox10.Text == "Aircraft")
            {
                textBox3.Text = "115";
            }
        }

        //when the button is pressed
        private void button1_Click(object sender, EventArgs e)
        {
            
            //Aircraft Passenger Parameter test
            int paxCountUser = Convert.ToInt32(textBox12.Text);

            Airplane plane = new Airplane(paxCountUser);

            if (paxCountUser > 150)
            {
                label34.Text = "Heavy";
            }
            else
            {
                label34.Text = "Light";
            }

            
            //when the button is pressed, automatically state the first calculation method
            comboBox2.SelectedIndex = comboBox2.Items.IndexOf("Calculation Method 1");
            comboBox3.SelectedIndex = comboBox3.Items.IndexOf("Calculation Method 1");
            comboBox4.SelectedIndex = comboBox4.Items.IndexOf("Calculation Method 1");
            comboBox5.SelectedIndex = comboBox5.Items.IndexOf("Calculation Method 1");
            comboBox6.SelectedIndex = comboBox6.Items.IndexOf("Calculation Method 1");
            //comboBox7.SelectedIndex = comboBox7.Items.IndexOf("Calculation Method 1");
            label4.Text = "Med";
            label9.Text = "Large";
            label10.Text = "Good";
            label11.Text = "###";
            label12.Text = "1750";
            label13.Text = "2 mil";
        }

        //expand/collapes subsystem panels
        private void label1_Click(object sender, EventArgs e)
        {
            if (epsPanel.Visible == true)
                epsPanel.Visible = false;
            else
                epsPanel.Visible = true;            
        }


        private void aircraftLabel_Click(object sender, EventArgs e)
        {
            if (aircraftPanel.Visible == true)
                aircraftPanel.Visible = false;
            else
                aircraftPanel.Visible = true;
        }

        private void apuLabel_Click(object sender, EventArgs e)
        {
            if (apuPanel.Visible == true)
                apuPanel.Visible = false;
            else
                apuPanel.Visible = true;
        }

        private void acsLabel_Click(object sender, EventArgs e)
        {
            if (acsPanel.Visible == true)
                acsPanel.Visible = false;
            else
                acsPanel.Visible = true;
        }

        private void basLabel_Click(object sender, EventArgs e)
        {
            if (basPanel.Visible == true)
                basPanel.Visible = false;
            else
                basPanel.Visible = true;
        }

        private void waiLabel_Click(object sender, EventArgs e)
        {
            if (waiPanel.Visible == true)
                waiPanel.Visible = false;
            else
                waiPanel.Visible = true;
        }

        private void enginesLabel_Click(object sender, EventArgs e)
        {
            if (enginesPanel.Visible == true)
                enginesPanel.Visible = false;
            else
                enginesPanel.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database2DataSet.Parameter_Def' table. You can move, or remove it, as needed.
            

        }

    }
}
