using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace xml.serialization.winform
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
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
          
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Student curStudent = new Student(this.textBox1.Text, (int)this.numericUpDown1.Value, this.textBox2.Text);
            Serialization<Student>.Serialize("Student", curStudent);
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            Student lastStudent = Serialization<Student>.Deserialize("Student");
            this.textBox1.Text = lastStudent.Name;
            this.numericUpDown1.Value = lastStudent.Age;
            this.textBox2.Text = lastStudent.ID;
        }

        private void label1_Click(object sender, EventArgs e)
        {
          
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
