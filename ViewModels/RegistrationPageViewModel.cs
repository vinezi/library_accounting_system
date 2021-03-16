using DevExpress.Mvvm;
using library_accounting_system.Services;
using System.Windows;
using System.Windows.Input;

namespace library_accounting_system.ViewModels
{
    class RegistrationPageViewModel : BindableBase
    {
        private readonly PageService _navigation;

        public string Passowrd { get; set; }

        public RegistrationPageViewModel(PageService navigation)
        {
            _navigation = navigation;
        }

        public ICommand Registration => new DelegateCommand(() =>
        {

            MessageBox.Show("rega BD");
            //check c bazi
            //_navigation.Navigate(new RegistrationPage());
        });

        /*public ICommand GoBack => new DelegateCommand(() =>
        {
            _navigation.Navigate(new LoginPage());
            //_navigation.Navigate(...);
        });*/
    }
}
