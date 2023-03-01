using System;
using System.Windows.Forms;

namespace OOP1_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CheckText(object sender, EventArgs e)
        {
            int test;
            bool result = double.TryParse(textBox1.Text, out var number); //Преобразование ввода в число
            if (result == true)
            {
                test = (int)number;
                //Если введено было число, и при этом при переводе в int теряется дробная часть, то выводим
                if (number - test != 0)
                {
                    MessageBox.Show($"Число: {number}");
                }
                else
                    MessageBox.Show("Число не соответсвует установленному формату");
            }
            else
                MessageBox.Show("Число не соответсвует установленному формату");
        }
    }
}
