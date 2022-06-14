using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace survey
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;       //현재 창 종료
            Form2 showForm2 = new Form2();
            showForm2.Show();
        }

        private void male_CheckedChanged(object sender, EventArgs e)
        {
            int sex_male = 0;
            if(male.Checked == true)
            {
                sex_male += 1;
            }
        }

        private void female_CheckedChanged(object sender, EventArgs e)
        {
            int sex_female = 0;
            if (female.Checked == true)
            {
                sex_female += 1;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Text = comboBox1.SelectedItem.ToString();
        }
    }
}
