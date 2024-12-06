using System;
using Xamarin.Forms;
// CreditCalculatorPage.xaml.cs
using System;
using Xamarin.Forms;

namespace CreditCalculator
{
    public partial class CreditCalculatorPage : ContentPage
    {
        public CreditCalculatorPage()
        {
            InitializeComponent();
            UpdateInterestRateLabel(); // Обновляем значение при инициализации
        }

        private void InterestRateSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            UpdateInterestRateLabel();
        }

        private void UpdateInterestRateLabel()
        {
            InterestRateLabel.Text = $"{InterestRateSlider.Value:F1}%";
        }

        private void CalculateButton_Clicked(object sender, EventArgs e)
        {
            if (double.TryParse(LoanAmountEntry.Text, out double loanAmount) &&
                int.TryParse(LoanTermEntry.Text, out int loanTerm))
            {
                double interestRate = InterestRateSlider.Value / 100;
                double monthlyPayment = 0;
                double totalPayment = 0;
                double overpayment = 0;

                if (PaymentTypePicker.SelectedItem?.ToString() == "Аннуитетный")
                {
                    double monthlyRate = interestRate / 12;
                    monthlyPayment = loanAmount * monthlyRate / (1 - Math.Pow(1 + monthlyRate, -loanTerm));
                }
                else if (PaymentTypePicker.SelectedItem?.ToString() == "Дифференцированный")
                {
                    // Добавьте реализацию для дифференцированного платежа
                }

                totalPayment = monthlyPayment * loanTerm;
                overpayment = totalPayment - loanAmount;

                MonthlyPaymentLabel.Text = $"{monthlyPayment:F2} руб.";
                TotalAmountLabel.Text = $"{totalPayment:F2} руб.";
                OverpaymentLabel.Text = $"{overpayment:F2} руб.";
            }
            else
            {
                DisplayAlert("Ошибка", "Введите корректные данные", "OK");
            }
        }
    }
}