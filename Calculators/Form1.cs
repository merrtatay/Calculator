using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculators
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double num1 = 0.0;
        double num2 = 0.0;
        double result=0.0;
        string input = string.Empty;
        string operation= string.Empty;
        string operand1 = string.Empty;
        string operand2= string.Empty;

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        protected void NumberBtn_Click(object sender, EventArgs e)
        {

            Button button = new Button();
            button.Click += new EventHandler(NumberBtn_Click);
            this.numberBoxTxt.Text = "";
            input += (sender as Button).Text;
            this.numberBoxTxt.Text += input;

        }
        protected void OperationBtn_Click(object sender, EventArgs e)
        {

            Button button = new Button();
            button.Click+= new EventHandler(OperationBtn_Click);
            operand1 = input;
            operation = (sender as Button).Text;
            this.numberBoxTxt.Text = "";
            this.input = String.Empty;

        }
        protected void CleanBtn_Click(object sender, EventArgs e)
        {
            this.numberBoxTxt.Text = "";
            this.input = String.Empty;
            this.operand1 = String.Empty;
            this.operation = String.Empty;
            


        }
        protected void DeletionBtn_Click(object sender, EventArgs e)
        {
            this.numberBoxTxt.Text = "";
            string deleting = input.Substring(0, input.Length - 1);
            input = deleting;
            this.numberBoxTxt.Text = deleting;



        }
        protected void EqualBtn_Click(object sender , EventArgs e)
        {
            operand2 = this.numberBoxTxt.Text;

            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);
            
            if (operation == "+")
                result=num1+num2;

            if (operation == "*")
                result = num1 * num2;

            if (operation == "/")
                result = num1 / num2;

            if (operation == "-")
                result = num1 - num2;


            this.numberBoxTxt.Text = result.ToString();
            input = result.ToString();
        }
        


    }

}
