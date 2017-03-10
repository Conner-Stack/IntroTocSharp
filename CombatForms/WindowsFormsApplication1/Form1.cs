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


        public Form1()
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.Enabled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {



        private void progressBar2_Click(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Serializer<Container>.Serialize("GameSave", Singleton.Instance.entity);
        }

        private void Load_Click(object sender, EventArgs e)
        {
            private void Load_Game_Click(object sender, EventArgs e)
        {
            Singleton.Instance.entity = Serializer<Container>.Deserialize("GameSave");
        }
    } 
}

