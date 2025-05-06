using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace midterm_exam_Q3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int total = 0;

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                radioButton1.Visible = true;
                radioButton2.Visible = true;
                radioButton3.Visible = true;
                radioButton4.Visible = true;
            }
            if(!(checkBox1.Checked) && radioButton1.Checked)
            {
                total -= 35;
            }
            else if (!(checkBox1.Checked) && radioButton2.Checked)
            {
                total -= 30;
            }
            else if (!(checkBox1.Checked) && radioButton3.Checked)
            {
                total -= 40;
            }
            else if (!(checkBox1.Checked) && radioButton4.Checked)
            {
                total -= 25;
            }
            label1.Text = $" NT $   {total}  元";
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                radioButton5.Visible = true;
                radioButton6.Visible = true;                
            }
            if (!(checkBox2.Checked) && radioButton5.Checked)
            {
                total -= 25;
            }
            else if (!(checkBox2.Checked) && radioButton6.Checked)
            {
                total -= 35;
            }
            label1.Text = $" NT $   {total}  元";
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                radioButton7.Visible = true;
                radioButton8.Visible = true;
                radioButton9.Visible = true;
            }
            if (checkBox3.Checked && !(radioButton7.Checked || radioButton8.Checked || radioButton9.Checked))
            {
                total += 20;
            }
            else if (!(checkBox3.Checked) && radioButton7.Checked)
            {
                total -= 25;
            }
            else if (!(checkBox3.Checked) && radioButton8.Checked)
            {
                total -= 30;
            }
            else if (!(checkBox3.Checked) && radioButton9.Checked)
            {
                total -= 20;
            }
            else if (checkBox3.Checked && radioButton7.Checked)
            {
                total += 25;
            }
            else if (checkBox3.Checked && radioButton8.Checked)
            {
                total += 30;
            }
            else if (checkBox3.Checked && radioButton9.Checked)
            {
                total += 20;
            }            
            label1.Text = $" NT $   {total}  元";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked && radioButton1.Checked)
            {
                total += 35;
            }
            else if (checkBox1.Checked && !(radioButton1.Checked))
            {
                total -= 35;
            }
            label1.Text = $" NT $   {total}  元";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked && radioButton2.Checked)
            {
                total += 30;
            }
            else if (checkBox1.Checked && !(radioButton2.Checked))
            {
                total -= 30;
            }
            label1.Text = $" NT $   {total}  元";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked && radioButton3.Checked)
            {
                total += 40;
            }
            else if (checkBox1.Checked && !(radioButton3.Checked))
            {
                total -= 40;
            }
            label1.Text = $" NT $   {total}  元";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked && radioButton4.Checked)
            {
                total += 25;
            }
            else if (checkBox1.Checked && !(radioButton4.Checked))
            {
                total -= 25;
            }
            label1.Text = $" NT $   {total}  元";
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked && radioButton5.Checked)
            {
                total += 25;
            }
            else if (checkBox2.Checked && !(radioButton5.Checked))
            {
                total -= 25;
            }
            label1.Text = $" NT $   {total}  元";
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked && radioButton6.Checked)
            {
                total += 35;
            }
            else if (checkBox2.Checked && !(radioButton6.Checked))
            {
                total -= 35;
            }
            label1.Text = $" NT $   {total}  元";
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked && radioButton7.Checked)
            {
                total += 5;
            }
            else if (checkBox3.Checked && !(radioButton7.Checked))
            {
                total -= 5;
            }
            label1.Text = $" NT $   {total}  元";
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked && radioButton8.Checked)
            {
                total += 10;
            }
            else if (checkBox3.Checked && !(radioButton8.Checked))
            {
                total -= 10;
            }
            label1.Text = $" NT $   {total}  元";
        }
    }    
}
