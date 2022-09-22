using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton1.Checked)
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("INF.02");
                comboBox2.Items.Add("INF.03");
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox2.SelectedItem == "INF.02")
            {
                label13.Text = "Administracja i eksploatacja systemów komputerowych, urządzeń\r\nperyferyjnych i lokalnych sieci komputerowych";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Add("styczeń");
            comboBox1.Items.Add("czerwiec");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("INF.03");
                comboBox2.Items.Add("INF.04");
            }
            else if (radioButton2.Checked)
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var Regex1 = new Regex(@"[A-Z][0-9]+\/");
            if (Regex1.IsMatch(tbb2.Text))
            {
                MessageBox.Show("Zły adres i ulica");
            }
        }
    }
}
