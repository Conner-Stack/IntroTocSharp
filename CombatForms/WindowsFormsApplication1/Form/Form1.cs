using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace combatForms
{

    public partial class Form1 : Form
    {
       
    public void ATB(Timer T, ProgressBar P)
        {
        if(P.Value == P.Maximum)
            {
                T.Stop();
                //will probably be moved to the FSM.cs, will have to add character state turnUp here
                P.Value = 0;

                T.Start();
            }
        }

       
    

        public Form1()
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeComponent();
            timer1.Enabled = true;
            timer1.Interval = 300;
            
            timer1.Start();
            timer2.Enabled = true;
            timer2.Interval = 300;
            timer2.Start();
            timer3.Enabled = true;
            timer3.Interval = 300;
            timer3.Start();
            timer4.Enabled = true;
            timer4.Interval = 300;
            timer4.Start();
            timer5.Enabled = true;
            timer5.Interval = 300;
            timer5.Start();
            timer6.Enabled = true;
            timer6.Interval = 300;
            timer6.Start();
            progressBar2.Maximum = 100;
            timer1.Tick += new EventHandler(timer1_Tick);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.Enabled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Enabled = true;
        }

        private void progressBar2_Click(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar2.Value != progressBar2.Maximum)
                progressBar2.Value++;
            else
            {
                timer1.Stop();

                progressBar2.Value = 0;

                timer1.Start();
            }

        }
    }
}
