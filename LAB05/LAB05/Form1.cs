using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = GetNumber1();
                double num2 = GetNumber2();
                double result = num1 + num2;
                ShowResult(result.ToString());
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        // Кнопка "-"
        private void btnSub_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = GetNumber1();
                double num2 = GetNumber2();
                double result = num1 - num2;
                ShowResult(result.ToString());
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        // Кнопка "*"
        private void btnMul_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = GetNumber1();
                double num2 = GetNumber2();
                double result = num1 * num2;
                ShowResult(result.ToString());
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        // Кнопка "/"
        private void btnDiv_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = GetNumber1();
                double num2 = GetNumber2();

                if (num2 == 0)
                {
                    ShowError("Ошибка: Деление на ноль!");
                    return;
                }

                double result = num1 / num2;
                ShowResult(result.ToString());
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        // Кнопка "Очистить"
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNumber1.Text = "";
            txtNumber2.Text = "";
            lblResult.Text = "Результат:";
            lblResult.ForeColor = System.Drawing.Color.Black;
        }

        // Получить первое число
        private double GetNumber1()
        {
            if (string.IsNullOrWhiteSpace(txtNumber1.Text))
                throw new Exception("Ошибка: Введите первое число!");

            if (!double.TryParse(txtNumber1.Text, out double result))
                throw new Exception("Ошибка: Первое число должно быть числом!");

            return result;
        }

        // Получить второе число
        private double GetNumber2()
        {
            if (string.IsNullOrWhiteSpace(txtNumber2.Text))
                throw new Exception("Ошибка: Введите второе число!");

            if (!double.TryParse(txtNumber2.Text, out double result))
                throw new Exception("Ошибка: Второе число должно быть числом!");

            return result;
        }

        // Показать результат
        private void ShowResult(string result)
        {
            lblResult.Text = $"Результат: {result}";
            lblResult.ForeColor = System.Drawing.Color.Black;
        }

        // Показать ошибку (красным цветом)
        private void ShowError(string errorMessage)
        {
            lblResult.Text = errorMessage;
            lblResult.ForeColor = System.Drawing.Color.Red;
        }
    }
}
