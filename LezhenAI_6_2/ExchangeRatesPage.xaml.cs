// ExchangeRatesPage.xaml.cs
using System;
using Xamarin.Forms;

namespace CreditCalculator
{
    public partial class ExchangeRatesPage : ContentPage
    {
        public ExchangeRatesPage()
        {
            InitializeComponent();
            CurrentDateLabel.Text = DateTime.Now.ToString("dd.MM.yyyy");
            UsdRateLabel.Text = "80.000"; // Пример курса USD
            EurRateLabel.Text = "86.000"; // Пример курса EUR
        }
    }
}