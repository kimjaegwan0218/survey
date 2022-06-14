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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            int korea = 0;
            if(radioButton1.Checked == true)
            {
                korea += 1;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            int china = 0;
            if(radioButton2.Checked == true)
            {
                china += 1;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            int usa = 0;
            if(radioButton3.Checked == true)
            {
                usa += 1;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            int japan = 0;
            if(radioButton4.Checked == true)
            {
                japan += 1;
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            int euro = 0;
            if(radioButton6.Checked == true) {
                euro += 1;
            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            int dong = 0;
            if(radioButton7.Checked == true)
            {
                dong += 1;
            }
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            string etc1;
            if(radioButton8.Checked == true)
            {
                if(textBox1.Text == "") MessageBox.Show("입력해주세요");
                else etc1 = textBox1.Text;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            int act = 0;
            if(checkBox1.Checked == true)
            {
                act += 1;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            int sports = 0;
            if(checkBox2.Checked == true)
            {
                sports += 1;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            int sf = 0;
            if(checkBox3.Checked == true)
            {
                sf += 1;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            int music = 0;
            if(checkBox4.Checked == true)
            {
                music += 1;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            int fantage = 0;
            if(checkBox5.Checked == true)
            {
                fantage += 1;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            int comedy = 0;
            if(checkBox6.Checked == true)
            {
                comedy += 1;
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            int horror = 0;
            if(checkBox7.Checked == true)
            {
                horror += 1;
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            int romance = 0;
            if(checkBox8.Checked == true)
            {
                romance += 1;
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            int musical = 0;
            if(checkBox9.Checked == true)
            {
                musical += 1;
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            string etc2;
            if(checkBox10.Checked == true)
            {
                if (textBox2.Text == "") MessageBox.Show("입력해주세요");
                else etc2 = textBox2.Text;
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            int fa_maleact = 0;
            if(radioButton5.Checked == true)
            {
                fa_maleact += 1;
            }
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            int fa_femaleact = 0;
            if(radioButton9.Checked == true)
            {
                fa_femaleact += 1;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string feedback;
            feedback = textBox3.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;       //현재 창 종료
            Form3 showForm3 = new Form3();
            showForm3.Show();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            string actorname;
            actorname = textBox4.Text;
        }
    }
}
