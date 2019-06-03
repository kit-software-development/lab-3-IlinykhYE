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
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        float a=0, b=0; //операнды
        string operation; //операция
        int cnt=0;

        private void DigitClick(object sender, EventArgs e) //нажатие на кнопку цифры
        {
            if (cnt < 10)
            {
                display.Text += Convert.ToString((sender as Button).Tag);
                cnt++;
            }
        }

        private void OperationClick(object sender, EventArgs e) //нажатие на кнопку операции
        {
            if (cnt != 0) //если был введен операнд, то записываем его значение в переменную а
            {
                a = float.Parse(display.Text);                
            }
            operation = Convert.ToString((sender as Button).Tag);
            middle.Text = a.ToString() + Convert.ToString((sender as Button).Tag);
            display.Text = "";
            cnt = 0;
        }

        private void CE_Click(object sender, EventArgs e) //нажатие на кнопку СЕ
        {
            display.Text = "";
            cnt = 0;
            b = 0;
        }

        private void dot_Click(object sender, EventArgs e) //нажатие на кнопку ","
        {
            if (!display.Text.Contains(","))
            {
                cnt++;
                display.Text += ",";
            }
        }
        
        private void PressKeys(object sender, KeyEventArgs e)
        {
            Button b = new Button();
            switch (e.KeyCode)
            {
                case (Keys.D0):
                case (Keys.NumPad0):
                    b.Tag = "0";
                    DigitClick(b, e);
                    break;
                case (Keys.D1):
                case (Keys.NumPad1):
                    b.Tag = "1";
                    DigitClick(b, e);
                    break;
                case (Keys.D2):
                case (Keys.NumPad2):
                    b.Tag = "2";
                    DigitClick(b, e);
                    break;
                case (Keys.D3):
                case (Keys.NumPad3):
                    b.Tag = "3";
                    DigitClick(b, e);
                    break;
                case (Keys.D4):
                case (Keys.NumPad4):
                    b.Tag = "4";
                    DigitClick(b, e);
                    break;
                case (Keys.D5):
                case (Keys.NumPad5):
                    b.Tag = "5";
                    DigitClick(b, e);
                    break;
                case (Keys.D6):
                case (Keys.NumPad6):
                    b.Tag = "6";
                    DigitClick(b, e);
                    break;
                case (Keys.D7):
                case (Keys.NumPad7):
                    b.Tag = "7";
                    DigitClick(b, e);
                    break;
                case (Keys.D8):
                case (Keys.NumPad8):
                    b.Tag = "8";
                    DigitClick(b, e);
                    break;
                case (Keys.D9):
                case (Keys.NumPad9):
                    b.Tag = "9";
                    DigitClick(b, e);
                    break;
                case (Keys.Delete):
                    b.Tag = "del";
                    CE_Click(b, e);
                    break;
                case (Keys.OemPeriod):
                case (Keys.Decimal):
                    b.Tag = ".";
                    dot_Click(b, e);
                    break;
                case Keys.Add:
                case Keys.Oemplus:
                    b.Tag = "+";
                    OperationClick(b, e);
                    break;
                case Keys.Subtract:
                case Keys.OemMinus:
                    b.Tag = "-";
                    OperationClick(b, e);
                    break;
                case Keys.Multiply:
                    b.Tag = "*";
                    OperationClick(b, e);
                    break;
                case Keys.OemQuestion:
                case Keys.Divide:
                    b.Tag = "/";
                    OperationClick(b, e);
                    break;
                case (Keys.Enter):
                    calculate(b, e);
                    break;
            }
        }
      
        private void calculate(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    b = a + float.Parse(display.Text);              
                    break;
                case "-":
                    b = a - float.Parse(display.Text);
                    break;
                case "*":
                    b = a * float.Parse(display.Text);
                    break;
                case "/":
                    b = a / float.Parse(display.Text);
                    break;               
            }
            middle.Text = "";
            Clipboard.SetText(b.ToString());
            display.Text = b.ToString();
            operation = ""; a = 0;
        }
    }
}
