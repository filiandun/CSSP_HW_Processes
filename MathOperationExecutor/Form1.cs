using System;
using System.Windows.Forms;

namespace MathOperationExecutor
{
    public partial class Form1 : Form
    {
        public Form1(string[] args)
        {
            InitializeComponent();

            this.GetResult(args);
        }

        private void GetResult(string[] args)
        {
            if (args.Length == 3)
            {
                try
                {
                    double firstNumber = double.Parse(args[0]);
                    double secondNumber = double.Parse(args[1]);
                    string operation = args[2];

                    switch (operation)
                    { 
                        case "+": this.resultLabel.Text = $"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}"; break;
                        case "-": this.resultLabel.Text = $"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}"; break;
                        case "*": this.resultLabel.Text = $"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}"; break;
                        case "/": this.resultLabel.Text = $"{firstNumber} / {secondNumber} = {firstNumber / secondNumber}"; break;
                        case "%": this.resultLabel.Text = $"{firstNumber} % {secondNumber} = {firstNumber * secondNumber / 100}"; break;
                        case "x^2": this.resultLabel.Text = $"{firstNumber} ^ {secondNumber} = {Math.Pow(firstNumber, secondNumber)}"; break;
                        case "x^1/2": this.resultLabel.Text = $"{firstNumber} ^ 1 / {secondNumber} = {Math.Pow(firstNumber, 1 / secondNumber)}"; break;
                        default: break;
                    }
                }
                catch (Exception ex)
                {
                    this.resultLabel.Text = ex.Message;
                }
            }
            else
            {
                this.resultLabel.Text = "Что-то сломалось.";
            }
        }
    }
}
