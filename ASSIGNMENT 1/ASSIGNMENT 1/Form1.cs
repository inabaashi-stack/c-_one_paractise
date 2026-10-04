using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASSIGNMENT_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void dataoutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void yeartextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void shiwdateboton_Click(object sender, EventArgs e)
        {
            //creating variables
            string dayofTheweek, nameofthemonth, numericdayOM, year, concat;
            dayofTheweek = dayofweek.Text;
            nameofthemonth = monthtextbox.Text;
            numericdayOM = dayofmonthtextbox.Text;
            year = yeartextbox.Text;

            concat = dayofTheweek + "  " + nameofthemonth + "/" + numericdayOM + "/" + year;
            dateoutput.Text = concat;



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void clearbotton_Click(object sender, EventArgs e)
        {
            dayofweek.Text = "";
            monthtextbox.Text = "";
            monthtextbox.Text = "";
            yeartextbox.Text = "";
            dateoutput.Text = "";
        }

        private void exitbuton_Click(object sender, EventArgs e)
        {
         this.Close();
        }
    }
}
