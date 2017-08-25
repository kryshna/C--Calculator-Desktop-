using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Calculator
{
    public partial class Form1 : Form
    {
        private string sOperator = "";
        private string sFirstValue = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           


        }

        private void click1_Click(object sender, EventArgs e)
        {
            ResultText.Text += click1.Text;
        }

        private void click2_Click(object sender, EventArgs e)
        {
            ResultText.Text += click2.Text;
        }

        private void equals_Click(object sender, EventArgs e)
        {
            double Result = 0;

            switch (sOperator)
            {
                case "+":
                    Result = float.Parse(sFirstValue) + float.Parse(ResultText.Text);
                    break;

                case "-":
                    Result = float.Parse(sFirstValue) - float.Parse(ResultText.Text);
                    break;

                case "*":
                    Result = float.Parse(sFirstValue) * float.Parse(ResultText.Text);
                    break;

                case "/":
                    Result = float.Parse(sFirstValue) / float.Parse(ResultText.Text);
                    break;
                case "sin":
                    double val = double.Parse(sFirstValue);
                     Result =(double) Math.Sin(val);
                  //  Result = Math.Sin(float.Parse(sFirstValue));
                     break;
                case "cos":
                    double ans = double.Parse(sFirstValue);
                    Result = Math.Cos(ans);
                    break;
                case "tan":
                     ans = double.Parse(sFirstValue);
                    Result = Math.Tan(ans);
                    break;

                case "fact":
                    double fact = 1;
                    double value = double.Parse(sFirstValue);
                    for (double i = value; i >= 1; i--) {
                        fact = fact * i; }
                    Result = fact;
                            break;

                case "square":
                 Result =  float.Parse(sFirstValue) * float.Parse(sFirstValue);
                    break;
            }
            ResultText.ResetText();
            ResultText.Text = Convert.ToString(Result);
        }

        private void clickAdd_Click(object sender, EventArgs e)
        {
            sFirstValue = ResultText.Text;
            ResultText.ResetText();
            sOperator = clickAdd.Text;
        }

        private void product_Click(object sender, EventArgs e)
        {
            sFirstValue = ResultText.Text;
            ResultText.ResetText();
            sOperator = product.Text;
        }

        private void subtract_Click(object sender, EventArgs e)
        {
            sFirstValue = ResultText.Text;
            ResultText.ResetText();
            sOperator = subtract.Text;
        }

        private void divide_Click(object sender, EventArgs e)
        {
            sFirstValue = ResultText.Text;
            ResultText.ResetText();
            sOperator = divide.Text;
        }

        private void click3_Click(object sender, EventArgs e)
        {
            ResultText.Text += click3.Text;
        }

        private void click4_Click(object sender, EventArgs e)
        {
            ResultText.Text += click4.Text;
        }

        private void click5_Click(object sender, EventArgs e)
        {
            ResultText.Text += click5.Text;
        }

        private void click6_Click(object sender, EventArgs e)
        {
            ResultText.Text += click6.Text;
        }

        private void click7_Click(object sender, EventArgs e)
        {
            ResultText.Text += click7.Text;
        }

        private void click8_Click(object sender, EventArgs e)
        {
            ResultText.Text += click8.Text;
        }

        private void click9_Click(object sender, EventArgs e)
        {
            ResultText.Text += click9.Text;
        }

        private void click0_Click(object sender, EventArgs e)
        {
            ResultText.Text += click0.Text;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            ResultText.Clear();
        }

        private void factButton_Click(object sender, EventArgs e)
        {
            sFirstValue = ResultText.Text;
            ResultText.ResetText();
            sOperator = factButton.Text;
        }

        private void sineButton_Click(object sender, EventArgs e)
        {
            sFirstValue = ResultText.Text;
            ResultText.ResetText();
            sOperator = sineButton.Text;
        }

        private void squareButton_Click(object sender, EventArgs e)
        {
            sFirstValue = ResultText.Text;
            ResultText.ResetText();
            sOperator = squareButton.Text;
        }

        private void cosButton_Click(object sender, EventArgs e)
        {
            sFirstValue = ResultText.Text;
            ResultText.ResetText();
            sOperator = cosButton.Text;
        }

        private void tabButton_Click(object sender, EventArgs e)
        {
            sFirstValue = ResultText.Text;
            ResultText.ResetText();
            sOperator = tabButton.Text;
        }

        private void offButton_CheckedChanged(object sender, EventArgs e)
        {
            click1.Enabled = false;
            click0.Enabled = false;
            button00.Enabled = false;
            click1.Enabled = false;
            click2.Enabled = false;
            click3.Enabled = false;
            click4.Enabled = false;
            click5.Enabled = false;
            click6.Enabled = false;
            click7.Enabled = false;
            click8.Enabled = false;
            click9.Enabled = false;
            clickAdd.Enabled = false;
            subtract.Enabled = false;
            product.Enabled = false;
            divide.Enabled = false;
            squareButton.Enabled = false;
            sineButton.Enabled = false;
            cosButton.Enabled = false;
            tabButton.Enabled = false;
            factButton.Enabled = false;
        }

        private void onButton_CheckedChanged(object sender, EventArgs e)
        {
            click0.Enabled = true;
            button00.Enabled = true;
            click1.Enabled = true;
            click2.Enabled = true;
            click3.Enabled = true;
            click4.Enabled = true;
            click5.Enabled = true;
            click6.Enabled = true;
            click7.Enabled = true;
            click8.Enabled = true;
            click9.Enabled = true;
            clickAdd.Enabled = true;
            subtract.Enabled = true;
            product.Enabled = true;
            divide.Enabled = true;
            squareButton.Enabled = true;
            sineButton.Enabled = true;
            cosButton.Enabled = true;
            tabButton.Enabled = true;
            factButton.Enabled = true;
                
        }
    }
}