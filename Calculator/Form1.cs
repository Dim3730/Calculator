using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private bool firstTime = true;
        private float a;
        private int sign = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            try
            {
                Decision(1);
            }
            catch
            {
                return;
            }
            textBox1.Text = string.Empty;
            sign = 1;
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            try
            {
                Decision(2);
            }
            catch
            {
                return;
            }
            textBox1.Text = string.Empty;
            sign = 2;
        }

        private void multiplicationButton_Click(object sender, EventArgs e)
        {
            try
            {
                Decision(3);
            }
            catch
            {
                return;
            }
            textBox1.Text = string.Empty;
            sign = 3;
        }

        private void divisionButton_Click(object sender, EventArgs e)
        {
            try
            {
                Decision(4);
            }
            catch
            {
                return;
            }
            textBox1.Text = string.Empty;
            sign = 4;
        }

        private void equallyButton_Click(object sender, EventArgs e)
        {
            try
            {
                Modifiers();
                sign = 0;
            }
            catch
            {
                return;
            }
        }

        private void Decision(int character)
        {
            if (firstTime)
            {
                sign = character;
                a = float.Parse(textBox1.Text);
                labelA.Text = a.ToString();
                firstTime = false;
            }
            else
            {
                Modifiers();
            }
        }

        private void Modifiers()
        {
            switch (sign)
            {
                case 1:
                    a += float.Parse(textBox1.Text);
                    labelA.Text = a.ToString();
                    textBox1.Text = string.Empty;
                    break;
                case 2:
                    a -= float.Parse(textBox1.Text);
                    labelA.Text = a.ToString();
                    textBox1.Text = string.Empty;
                    break;
                case 3:
                    a *= float.Parse(textBox1.Text);
                    labelA.Text = a.ToString();
                    textBox1.Text = string.Empty;
                    break;
                case 4:
                    if (textBox1.Text == "0")
                    {
                        MessageBox.Show("Деление на 0 невозможно");
                        textBox1.Text = string.Empty;
                        return;
                    }

                    a /= float.Parse(textBox1.Text);
                    labelA.Text = a.ToString();
                    textBox1.Text = string.Empty;
                    break;
                default:
                    break;
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            labelA.Text = string.Empty;
            a = 0;
            sign = 0;
            firstTime = true;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFile1 = new SaveFileDialog();
                saveFile1.DefaultExt = "*.txt";
                saveFile1.Filter = "txt|*.txt";
                if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
                    saveFile1.FileName.Length > 0)
                {
                    using (StreamWriter sw = new StreamWriter(saveFile1.FileName, true))
                    {
                        sw.WriteLine(labelA.Text);
                        sw.Close();
                    }
                }
            }
            catch
            {
                return;
            }
        }

        private void openResultButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            if (openFileDialog.FileName == null) return;
            try
            {
                StreamReader reader = new StreamReader(openFileDialog.FileName);
                a = float.Parse(reader.ReadToEnd());
                labelA.Text = a.ToString();
                firstTime = false;
                reader.Close();
            }
            catch
            {
                return;
            }
        }


        private void oneButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length <= 14)
                textBox1.Text = textBox1.Text + 1;
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length <= 14)
                textBox1.Text = textBox1.Text + 2;
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length <= 14)
                textBox1.Text = textBox1.Text + 3;
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length <= 14)
                textBox1.Text = textBox1.Text + 4;
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length <= 14)
                textBox1.Text = textBox1.Text + 5;
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length <= 14)
                textBox1.Text = textBox1.Text + 6;
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length <= 14)
                textBox1.Text = textBox1.Text + 7;
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length <= 14)
                textBox1.Text = textBox1.Text + 8;
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length <= 14)
                textBox1.Text = textBox1.Text + 9;
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void whiteThemeButton_Click(object sender, EventArgs e)
        {
            BackColor = Color.White;
        }

        private void darkThemeButton_Click(object sender, EventArgs e)
        {
            BackColor = Color.Gray;
        }
    }
}