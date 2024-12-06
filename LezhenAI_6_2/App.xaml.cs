// App.xaml.cs
using Xamarin.Forms;

namespace CreditCalculator // Убедитесь, что это пространство имен соответствует вашему проекту
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new LoginPage();
        }
    }
}