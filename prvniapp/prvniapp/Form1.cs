using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prvniapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            text.Text = text.Text+this.but1.Text;
        }

        private void text_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void but2_Click(object sender, EventArgs e)
        {
            text.Text = text.Text + this.but2.Text;
        }

        private void but3_Click(object sender, EventArgs e)
        {
            text.Text = text.Text + this.but3.Text;
        }

        private void but4_Click(object sender, EventArgs e)
        {
            text.Text = text.Text + this.but4.Text;
        }

        private void but5_Click(object sender, EventArgs e)
        {
            text.Text = text.Text + this.but5.Text;
        }

        private void but6_Click(object sender, EventArgs e)
        {
            text.Text = text.Text + this.but6.Text;
        }

        private void but7_Click(object sender, EventArgs e)
        {
            text.Text = text.Text + this.but7.Text;
        }

        private void but8_Click(object sender, EventArgs e)
        {
            text.Text = text.Text + this.but8.Text;
        }

        private void but9_Click(object sender, EventArgs e)
        {
            text.Text = text.Text + this.but9.Text;
        }

        private void ok_Click(object sender, EventArgs e)
        {
            this.list.Items.Add(text.Text);
            text.Clear();
        }

        private void sum_Click(object sender, EventArgs e)
        {
            text.Text = text.Text + this.sum.Text;
        }

        private void result_Click(object sender, EventArgs e)
        {
            int x = 0;
            int y = 0;
            int result = 0;
            

            for (int i = 0; i < list.Items.Count; i++) {

                switch((string)list.Items[i]){
                 case "+":
                        list.Items.Remove((string)"+");
                        x = int.Parse((string)this.list.Items[i - 1].ToString());
                        y = int.Parse((string)this.list.Items[i].ToString());
                        result = x + y;
                        break;
                 case "-":
                        list.Items.Remove((string)"-");
                        x = int.Parse((string)this.list.Items[i - 1].ToString());
                        y = int.Parse((string)this.list.Items[i].ToString());
                        result = x - y;
                        break;

                }
            }
            this.list.Items.Add("---------");
            this.list.Items.Add(result);

        }

        private void minus_Click(object sender, EventArgs e)
        {
            this.text.Text = text.Text+ this.minus.Text;
        }
    }
}
