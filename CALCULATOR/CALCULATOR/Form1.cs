using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CALCULATOR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.ShowDialog();
            string file = this.openFileDialog1.FileName;
            if(file=="")
            {
                MessageBox.Show("Please Select an Image for uploading");
            }
            else
            {
                this.pictureBox1.Image = Image.FromFile(file);
            }  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.fontDialog1.ShowDialog();
            this.Font = this.fontDialog1.Font;
            this.textBox1.Font = this.fontDialog1.Font;
            this.textBox2.Font=this.fontDialog1.Font;
            this.textBox3.Font = this.fontDialog1.Font;
            this.textBox4.Font = this.fontDialog1.Font;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.colorDialog1.ShowDialog();
            this.button3.ForeColor = this.colorDialog1.Color;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.saveFileDialog1.ShowDialog();
            this.textBox3.Text = this.saveFileDialog1.FileName;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            //this.label5.Text = "";
            this.label5.ResetText();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.label5.Text = this.label5.Text +"0";
            
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.label5.Text = this.label5.Text + "1";
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.label5.Text = this.label5.Text + "2";
           
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.label5.Text = this.label5.Text + "3";
           
        }

        private void button20_Click(object sender, EventArgs e)
        {
            this.label5.Text = this.label5.Text + "4";
                
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.label5.Text= this.label5.Text + "5";
          ;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            this.label5.Text = this.label5.Text + "6";
           ;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.label5.Text = this.label5.Text + "7";
           
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.label5.Text = this.label5.Text + "8";
          
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.label5.Text = this.label5.Text + "9";
          
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.operator_label.Text = "+";
            if (this.label5.Text != "")
            {
                this.first_label.Text = this.label5.Text;
            }
            this.label5.Text = "";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            this.operator_label.Text = "-";
            if (this.label5.Text != "")
            {
                this.first_label.Text = this.label5.Text;
            }
            this.label5.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.operator_label.Text = "*";
            if (this.label5.Text != "")
            {
                this.first_label.Text = this.label5.Text;
            }
            this.label5.Text = "";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            this.operator_label.Text = "/";
            if (this.label5.Text != "")
            {
                this.first_label.Text = this.label5.Text;
            }
            this.label5.Text = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            double firstNumber;double.TryParse(this.first_label.Text, out firstNumber);
            double lastNumber;double.TryParse(this.label5.Text, out lastNumber);
            double result = 0;
            if(this.operator_label.Text=="+")
            {
                result = firstNumber + lastNumber;
            }
            if (this.operator_label.Text == "-")
            {
                result = firstNumber - lastNumber;
            }
            if (this.operator_label.Text == "*")
            {
                result = firstNumber * lastNumber;
            }
            if (this.operator_label.Text == "/")
            {
                result = firstNumber / lastNumber;
            }
            this.label5.Text = result.ToString();
            this.operator_label.Text = "";
            this.first_label.ResetText();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.label5.Text = this.label5.Text+".";
        }
    }
}
