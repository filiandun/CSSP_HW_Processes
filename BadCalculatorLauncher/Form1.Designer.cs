namespace BadCalculatorLauncher
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.firstNumNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.resultButton = new System.Windows.Forms.Button();
            this.secondNumLabel = new System.Windows.Forms.Label();
            this.secondNumNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.operationListBox = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.firstNumLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.firstNumNumericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.secondNumNumericUpDown)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // firstNumNumericUpDown
            // 
            this.firstNumNumericUpDown.Location = new System.Drawing.Point(172, 24);
            this.firstNumNumericUpDown.Name = "firstNumNumericUpDown";
            this.firstNumNumericUpDown.Size = new System.Drawing.Size(131, 20);
            this.firstNumNumericUpDown.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.closeButton);
            this.groupBox1.Controls.Add(this.resultButton);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 297);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(5, 268);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(310, 23);
            this.closeButton.TabIndex = 8;
            this.closeButton.Text = "Закрыть окно с ответом";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // resultButton
            // 
            this.resultButton.Location = new System.Drawing.Point(6, 239);
            this.resultButton.Name = "resultButton";
            this.resultButton.Size = new System.Drawing.Size(309, 23);
            this.resultButton.TabIndex = 7;
            this.resultButton.Text = "Получить ответ";
            this.resultButton.UseVisualStyleBackColor = true;
            this.resultButton.Click += new System.EventHandler(this.resultButton_Click);
            // 
            // secondNumLabel
            // 
            this.secondNumLabel.AutoSize = true;
            this.secondNumLabel.Location = new System.Drawing.Point(5, 62);
            this.secondNumLabel.Name = "secondNumLabel";
            this.secondNumLabel.Size = new System.Drawing.Size(75, 13);
            this.secondNumLabel.TabIndex = 4;
            this.secondNumLabel.Text = "Второе число";
            // 
            // secondNumNumericUpDown
            // 
            this.secondNumNumericUpDown.Location = new System.Drawing.Point(172, 60);
            this.secondNumNumericUpDown.Name = "secondNumNumericUpDown";
            this.secondNumNumericUpDown.Size = new System.Drawing.Size(131, 20);
            this.secondNumNumericUpDown.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.operationListBox);
            this.groupBox2.Location = new System.Drawing.Point(6, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(309, 121);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Выберите оператор";
            // 
            // operationListBox
            // 
            this.operationListBox.FormattingEnabled = true;
            this.operationListBox.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/",
            "%",
            "x^2",
            "x^1/2"});
            this.operationListBox.Location = new System.Drawing.Point(6, 19);
            this.operationListBox.Name = "operationListBox";
            this.operationListBox.Size = new System.Drawing.Size(297, 95);
            this.operationListBox.TabIndex = 2;
            this.operationListBox.SelectedValueChanged += new System.EventHandler(this.operatorsListBox_SelectedValueChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.firstNumLabel);
            this.groupBox3.Controls.Add(this.firstNumNumericUpDown);
            this.groupBox3.Controls.Add(this.secondNumNumericUpDown);
            this.groupBox3.Controls.Add(this.secondNumLabel);
            this.groupBox3.Location = new System.Drawing.Point(6, 137);
            this.groupBox3.MaximumSize = new System.Drawing.Size(309, 96);
            this.groupBox3.MinimumSize = new System.Drawing.Size(309, 96);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(309, 96);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Введите числа";
            // 
            // firstNumLabel
            // 
            this.firstNumLabel.AutoSize = true;
            this.firstNumLabel.Location = new System.Drawing.Point(5, 26);
            this.firstNumLabel.Name = "firstNumLabel";
            this.firstNumLabel.Size = new System.Drawing.Size(77, 13);
            this.firstNumLabel.TabIndex = 3;
            this.firstNumLabel.Text = "Первое число";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 319);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(361, 358);
            this.MinimumSize = new System.Drawing.Size(361, 358);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лучший калькулятор";
            ((System.ComponentModel.ISupportInitialize)(this.firstNumNumericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.secondNumNumericUpDown)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown firstNumNumericUpDown;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown secondNumNumericUpDown;
        private System.Windows.Forms.Label secondNumLabel;
        private System.Windows.Forms.Label firstNumLabel;
        private System.Windows.Forms.ListBox operationListBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button resultButton;
    }
}

