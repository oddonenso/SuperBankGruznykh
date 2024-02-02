using System;
using System.Windows;
using System.Windows.Controls;

namespace wpfBank.Pages
{
    public partial class Calculator : Page
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void btnParam_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Получаем введенные значения
                double sum = Convert.ToDouble(tbsum.Text);
                double percent = Convert.ToDouble(tbsrok.Text);
                int months = Convert.ToInt32(tbpopolnit.Text);

                // Рассчитываем доход
                double rate = percent / 100 / 12; // Процентная ставка в месяц
                double futureValue = sum * Math.Pow(1 + rate, months); // Формула для ежемесячной капитализации

                // Выводим результат на интерфейс
                tbDohodStab.Text = futureValue.ToString("C2");
                tbDohodOptimal.Text = (futureValue - sum).ToString("C2");
                tbDohodStandart.Text = ((futureValue - sum) / months).ToString("C2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при расчете: " + ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
