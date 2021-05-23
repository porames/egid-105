using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        int calculation;
        string operation = null;
        string saved_input = null;
        string new_input = null;
        private void operation_click(object sender, EventArgs e)
        {
            if (saved_input != null)
            {
                string s = (sender as Button).Text;
                operation = s;
                answer.Text = answer.Text + s;
            }
            
        }
        private void return_click(object sender, EventArgs e)
        {
            if (saved_input != null)
            {
                answer.Text = Convert.ToString(Convert.ToInt32(saved_input) + Convert.ToInt32(new_input));
            }
        }
        private void numpad_Click(object sender, EventArgs e)
        {
            string s = (sender as Button).Text;
            if (operation == null)
            {

                saved_input = saved_input + s;
            }
            else
            {
                new_input = new_input+s;
            }
            answer.Text = answer.Text + s;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("button1 was clicked");
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
