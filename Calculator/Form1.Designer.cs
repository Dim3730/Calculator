namespace Calculator
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
            this.fourButton = new System.Windows.Forms.Button();
            this.fiveButton = new System.Windows.Forms.Button();
            this.sixButton = new System.Windows.Forms.Button();
            this.sevenButton = new System.Windows.Forms.Button();
            this.eightButton = new System.Windows.Forms.Button();
            this.nineButton = new System.Windows.Forms.Button();
            this.zeroButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.oneButton = new System.Windows.Forms.Button();
            this.twoButton = new System.Windows.Forms.Button();
            this.threeButton = new System.Windows.Forms.Button();
            this.multiplicationButton = new System.Windows.Forms.Button();
            this.minusButton = new System.Windows.Forms.Button();
            this.plusButton = new System.Windows.Forms.Button();
            this.divisionButton = new System.Windows.Forms.Button();
            this.equallyButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.labelA = new System.Windows.Forms.Label();
            this.whiteThemeButton = new System.Windows.Forms.Button();
            this.darkThemeButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.openResultButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fourButton
            // 
            this.fourButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fourButton.Location = new System.Drawing.Point(44, 90);
            this.fourButton.Name = "fourButton";
            this.fourButton.Size = new System.Drawing.Size(45, 42);
            this.fourButton.TabIndex = 3;
            this.fourButton.Text = "4";
            this.fourButton.UseVisualStyleBackColor = true;
            this.fourButton.Click += new System.EventHandler(this.fourButton_Click);
            // 
            // fiveButton
            // 
            this.fiveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fiveButton.Location = new System.Drawing.Point(95, 90);
            this.fiveButton.Name = "fiveButton";
            this.fiveButton.Size = new System.Drawing.Size(45, 42);
            this.fiveButton.TabIndex = 4;
            this.fiveButton.Text = "5";
            this.fiveButton.UseVisualStyleBackColor = true;
            this.fiveButton.Click += new System.EventHandler(this.fiveButton_Click);
            // 
            // sixButton
            // 
            this.sixButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sixButton.Location = new System.Drawing.Point(146, 90);
            this.sixButton.Name = "sixButton";
            this.sixButton.Size = new System.Drawing.Size(45, 42);
            this.sixButton.TabIndex = 5;
            this.sixButton.Text = "6";
            this.sixButton.UseVisualStyleBackColor = true;
            this.sixButton.Click += new System.EventHandler(this.sixButton_Click);
            // 
            // sevenButton
            // 
            this.sevenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sevenButton.Location = new System.Drawing.Point(44, 138);
            this.sevenButton.Name = "sevenButton";
            this.sevenButton.Size = new System.Drawing.Size(45, 42);
            this.sevenButton.TabIndex = 6;
            this.sevenButton.Text = "7";
            this.sevenButton.UseVisualStyleBackColor = true;
            this.sevenButton.Click += new System.EventHandler(this.sevenButton_Click);
            // 
            // eightButton
            // 
            this.eightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eightButton.Location = new System.Drawing.Point(95, 138);
            this.eightButton.Name = "eightButton";
            this.eightButton.Size = new System.Drawing.Size(45, 42);
            this.eightButton.TabIndex = 7;
            this.eightButton.Text = "8";
            this.eightButton.UseVisualStyleBackColor = true;
            this.eightButton.Click += new System.EventHandler(this.eightButton_Click);
            // 
            // nineButton
            // 
            this.nineButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nineButton.Location = new System.Drawing.Point(146, 138);
            this.nineButton.Name = "nineButton";
            this.nineButton.Size = new System.Drawing.Size(45, 42);
            this.nineButton.TabIndex = 8;
            this.nineButton.Text = "9";
            this.nineButton.UseVisualStyleBackColor = true;
            this.nineButton.Click += new System.EventHandler(this.nineButton_Click);
            // 
            // zeroButton
            // 
            this.zeroButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.zeroButton.Location = new System.Drawing.Point(95, 186);
            this.zeroButton.Name = "zeroButton";
            this.zeroButton.Size = new System.Drawing.Size(45, 42);
            this.zeroButton.TabIndex = 9;
            this.zeroButton.Text = "0";
            this.zeroButton.UseVisualStyleBackColor = true;
            this.zeroButton.Click += new System.EventHandler(this.zeroButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(44, 12);
            this.textBox1.MaxLength = 15;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(220, 20);
            this.textBox1.TabIndex = 10;
            // 
            // oneButton
            // 
            this.oneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oneButton.Location = new System.Drawing.Point(44, 42);
            this.oneButton.Name = "oneButton";
            this.oneButton.Size = new System.Drawing.Size(45, 42);
            this.oneButton.TabIndex = 0;
            this.oneButton.Text = "1";
            this.oneButton.UseVisualStyleBackColor = true;
            this.oneButton.Click += new System.EventHandler(this.oneButton_Click);
            // 
            // twoButton
            // 
            this.twoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.twoButton.Location = new System.Drawing.Point(95, 42);
            this.twoButton.Name = "twoButton";
            this.twoButton.Size = new System.Drawing.Size(45, 42);
            this.twoButton.TabIndex = 1;
            this.twoButton.Text = "2";
            this.twoButton.UseVisualStyleBackColor = true;
            this.twoButton.Click += new System.EventHandler(this.twoButton_Click);
            // 
            // threeButton
            // 
            this.threeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.threeButton.Location = new System.Drawing.Point(146, 42);
            this.threeButton.Name = "threeButton";
            this.threeButton.Size = new System.Drawing.Size(45, 42);
            this.threeButton.TabIndex = 2;
            this.threeButton.Text = "3";
            this.threeButton.UseVisualStyleBackColor = true;
            this.threeButton.Click += new System.EventHandler(this.threeButton_Click);
            // 
            // multiplicationButton
            // 
            this.multiplicationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.multiplicationButton.Location = new System.Drawing.Point(225, 138);
            this.multiplicationButton.Name = "multiplicationButton";
            this.multiplicationButton.Size = new System.Drawing.Size(45, 42);
            this.multiplicationButton.TabIndex = 13;
            this.multiplicationButton.Text = "*";
            this.multiplicationButton.UseVisualStyleBackColor = true;
            this.multiplicationButton.Click += new System.EventHandler(this.multiplicationButton_Click);
            // 
            // minusButton
            // 
            this.minusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minusButton.Location = new System.Drawing.Point(225, 90);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(45, 42);
            this.minusButton.TabIndex = 12;
            this.minusButton.Text = "-";
            this.minusButton.UseVisualStyleBackColor = true;
            this.minusButton.Click += new System.EventHandler(this.minusButton_Click);
            // 
            // plusButton
            // 
            this.plusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plusButton.Location = new System.Drawing.Point(225, 42);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(45, 42);
            this.plusButton.TabIndex = 11;
            this.plusButton.Text = "+";
            this.plusButton.UseVisualStyleBackColor = true;
            this.plusButton.Click += new System.EventHandler(this.plusButton_Click);
            // 
            // divisionButton
            // 
            this.divisionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.divisionButton.Location = new System.Drawing.Point(225, 186);
            this.divisionButton.Name = "divisionButton";
            this.divisionButton.Size = new System.Drawing.Size(45, 42);
            this.divisionButton.TabIndex = 14;
            this.divisionButton.Text = "/";
            this.divisionButton.UseVisualStyleBackColor = true;
            this.divisionButton.Click += new System.EventHandler(this.divisionButton_Click);
            // 
            // equallyButton
            // 
            this.equallyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 29F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.equallyButton.Location = new System.Drawing.Point(225, 234);
            this.equallyButton.Name = "equallyButton";
            this.equallyButton.Size = new System.Drawing.Size(45, 71);
            this.equallyButton.TabIndex = 15;
            this.equallyButton.Text = "=";
            this.equallyButton.UseVisualStyleBackColor = true;
            this.equallyButton.Click += new System.EventHandler(this.equallyButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearButton.Location = new System.Drawing.Point(11, 8);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(27, 30);
            this.clearButton.TabIndex = 16;
            this.clearButton.Text = "C";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelA.Location = new System.Drawing.Point(12, 243);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(16, 17);
            this.labelA.TabIndex = 17;
            this.labelA.Text = "0";
            // 
            // whiteThemeButton
            // 
            this.whiteThemeButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.whiteThemeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.whiteThemeButton.Location = new System.Drawing.Point(11, 276);
            this.whiteThemeButton.Name = "whiteThemeButton";
            this.whiteThemeButton.Size = new System.Drawing.Size(34, 29);
            this.whiteThemeButton.TabIndex = 18;
            this.whiteThemeButton.UseVisualStyleBackColor = false;
            this.whiteThemeButton.Click += new System.EventHandler(this.whiteThemeButton_Click);
            // 
            // darkThemeButton
            // 
            this.darkThemeButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.darkThemeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.darkThemeButton.Location = new System.Drawing.Point(55, 275);
            this.darkThemeButton.Name = "darkThemeButton";
            this.darkThemeButton.Size = new System.Drawing.Size(34, 29);
            this.darkThemeButton.TabIndex = 19;
            this.darkThemeButton.UseVisualStyleBackColor = false;
            this.darkThemeButton.Click += new System.EventHandler(this.darkThemeButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.Location = new System.Drawing.Point(138, 243);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(81, 26);
            this.saveButton.TabIndex = 20;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // openResultButton
            // 
            this.openResultButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openResultButton.Location = new System.Drawing.Point(138, 276);
            this.openResultButton.Name = "openResultButton";
            this.openResultButton.Size = new System.Drawing.Size(81, 26);
            this.openResultButton.TabIndex = 21;
            this.openResultButton.Text = "Открыть";
            this.openResultButton.UseVisualStyleBackColor = true;
            this.openResultButton.Click += new System.EventHandler(this.openResultButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(282, 316);
            this.Controls.Add(this.openResultButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.darkThemeButton);
            this.Controls.Add(this.whiteThemeButton);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.equallyButton);
            this.Controls.Add(this.divisionButton);
            this.Controls.Add(this.multiplicationButton);
            this.Controls.Add(this.minusButton);
            this.Controls.Add(this.plusButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.zeroButton);
            this.Controls.Add(this.nineButton);
            this.Controls.Add(this.eightButton);
            this.Controls.Add(this.sevenButton);
            this.Controls.Add(this.sixButton);
            this.Controls.Add(this.fiveButton);
            this.Controls.Add(this.fourButton);
            this.Controls.Add(this.threeButton);
            this.Controls.Add(this.twoButton);
            this.Controls.Add(this.oneButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button fourButton;
        private System.Windows.Forms.Button fiveButton;
        private System.Windows.Forms.Button sixButton;
        private System.Windows.Forms.Button sevenButton;
        private System.Windows.Forms.Button eightButton;
        private System.Windows.Forms.Button nineButton;
        private System.Windows.Forms.Button zeroButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button oneButton;
        private System.Windows.Forms.Button twoButton;
        private System.Windows.Forms.Button threeButton;
        private System.Windows.Forms.Button multiplicationButton;
        private System.Windows.Forms.Button minusButton;
        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.Button divisionButton;
        private System.Windows.Forms.Button equallyButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Button whiteThemeButton;
        private System.Windows.Forms.Button darkThemeButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button openResultButton;
    }
}

