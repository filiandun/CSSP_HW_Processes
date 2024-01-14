using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

/*
 * Первые два задания я решил не делать, так как они выполняются в третьем.
 * 
 * ЗАДАНИЕ 1 
 * Разработайте приложение, которое умеет запускать дочерний процесс и ожидать его завершения. 
 * Когда дочерний процесс завершен, родительское приложение должно отобразить код завершения. 
 * 
 * ЗАДАНИЕ 2 
 * Разработайте приложение, которое умеет запускать дочерний процесс. 
 * В зависимости от выбора пользователя родительское приложение должно ожидать завершения дочернего процесса 
 * и отображать код завершения либо принудительно завершать работу дочернего процесса. 
 * 
 * ЗАДАНИЕ 3 
 * Разработайте приложение, которое умеет запускать дочерний процесс и передавать ему аргументы командной строки.
 * В качестве аргументов должно быть два числа и операция, которую необходимо выполнить. Например, аргументы: 
 *  ■ 7; 
 *  ■ 3;
 *  ■ +. 
 * Дочерний процесс должен отобразить аргументы и вывести результат сложения 10 на экран.
 */


namespace BadCalculatorLauncher
{
    enum Operations
    { 
        PERCENT, // первое число - без ограничений, второе от 1 до 100
        OTHER // никаких ограничений
    }

    public partial class Form1 : Form
    {
        private Process process;

        public Form1()
        {
            InitializeComponent();

            this.firstNumNumericUpDown.Minimum = decimal.MinValue;
            this.firstNumNumericUpDown.Maximum = decimal.MaxValue;

            this.secondNumNumericUpDown.Minimum = decimal.MinValue;
            this.secondNumNumericUpDown.Maximum = decimal.MaxValue;

            this.operationListBox.SelectedIndex = 0;
        }

        private void resultButton_Click(object sender, EventArgs e)
        {
            if (this.operationListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Вы не выбрали оператор!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Доконали эти пути, поэтому такая фигня получилась
                string mainPath = Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).FullName).FullName).FullName).FullName;
                string daughterPath = Path.Combine(mainPath, "MathOperationExecutor", "bin", "Debug", "MathOperationExecutor.exe");

                this.process = new Process();
                this.process.StartInfo.FileName = daughterPath;
                this.process.StartInfo.Arguments = this.GetArguments();

                this.process.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            if (this.process != null && !this.process.HasExited)
            {
                this.process.Kill();
            }
            this.process.Dispose();
        }

        private void operatorsListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (this.operationListBox.SelectedIndex)
            {
                case 0: this.SetNumericUpDownLimit(Operations.OTHER); this.firstNumLabel.Text = "Первое слагаемое"; this.secondNumLabel.Text = "Второе слагаемое"; break;
                case 1: this.SetNumericUpDownLimit(Operations.OTHER); this.firstNumLabel.Text = "Уменьшаемое"; this.secondNumLabel.Text = "Вычитаемое"; break;
                case 2: this.SetNumericUpDownLimit(Operations.OTHER); this.firstNumLabel.Text = "Первый множитель"; this.secondNumLabel.Text = "Второй множитель"; break;
                case 3: this.SetNumericUpDownLimit(Operations.OTHER); this.firstNumLabel.Text = "Делимое"; this.secondNumLabel.Text = "Делитель"; break;
                case 4: this.SetNumericUpDownLimit(Operations.PERCENT); this.firstNumLabel.Text = "Число"; this.secondNumLabel.Text = "Процент"; break;
                case 5: this.SetNumericUpDownLimit(Operations.OTHER); this.firstNumLabel.Text = "Возводимое число"; this.secondNumLabel.Text = "Степень"; break;
                case 6: this.SetNumericUpDownLimit(Operations.OTHER); this.firstNumLabel.Text = "Подставляемое число"; this.secondNumLabel.Text = "Степень"; break;
                default: break;
            }
        }

        private void SetNumericUpDownLimit(Operations operation)
        {
            switch (operation)
            { 
                case Operations.PERCENT: this.secondNumNumericUpDown.Minimum = 1; this.secondNumNumericUpDown.Maximum = 100; break;
                case Operations.OTHER: this.secondNumNumericUpDown.Minimum = decimal.MinValue; this.secondNumNumericUpDown.Maximum = decimal.MaxValue; break;
                default: break;
            }
        }

        private string GetArguments()
        {
            return $"{this.firstNumNumericUpDown.Value} {this.secondNumNumericUpDown.Value} {this.operationListBox.SelectedItem}";
        }
    }
}
