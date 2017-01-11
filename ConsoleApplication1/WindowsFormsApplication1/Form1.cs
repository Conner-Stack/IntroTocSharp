using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public char achar = '1';
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             progressBar1.Value += 5;
            if (progressBar1.Maximum == 100)
                textBox1.Text = "lvl. 1" ;
            if (progressBar1.Maximum == 200)
                textBox1.Text = "lvl. 2";
            if(progressBar1.Value == progressBar1.Maximum)
            {
                progressBar1.Value = 0;
                progressBar1.Maximum += 100;
                textBox1.Text = "level up";
            }
        
        }
        private void subButton_Click_1(object sender, EventArgs e)
        {
            progressBar1.Increment(-5);
            if(progressBar1.Maximum == 100)
                textBox1.Text = "lvl. 1";           
            if(progressBar1.Maximum == 200)
                textBox1.Text = "lvl. 2";
            if (progressBar1.Value == progressBar1.Minimum)
            {
                progressBar1.Maximum += -100;
                progressBar1.Value = progressBar1.Maximum;
                textBox1.Text = "level down";
            }
        }
    
        private void progressBar1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
}
        
}
