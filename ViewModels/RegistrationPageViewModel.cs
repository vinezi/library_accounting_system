using DevExpress.Mvvm;
using library_accounting_system.Services;
using System;
using System.Windows;
using System.Windows.Input;

namespace library_accounting_system.ViewModels
{
    class RegistrationPageViewModel : BindableBase
    {
        public string userLoginField { get; set; }
        public string Password { private get; set; } //не безопасно
        public string Confirm { private get; set; } //не безопасно

        private readonly PageService _navigation;

        public RegistrationPageViewModel(PageService navigation)
        {
            _navigation = navigation;
        }

        public ICommand Registration => new DelegateCommand(() =>
        {
            DataBaseHelper db = new DataBaseHelper();

            String loginUser = userLoginField;
            String passwordUser = Password;
            String confirmdUser = Confirm;
            /*
             String loginUser = NewUserLoginField.Text;
            String passwordUser = NewUserPasswordField.Password;
            String confirmUser = NewUserConfirmField.Password;

            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `password`, `is_admin`) VALUES (@newUserLogin, @newUserPassword, '')", db.getConnection());

            if (passwordUser == confirmUser)
            {
                command.Parameters.Add("@newUserLogin", MySqlDbType.VarChar).Value = loginUser;
                command.Parameters.Add("@newUserPassword", MySqlDbType.VarChar).Value = passwordUser;
            }
            else
            {
                MessageBox.Show("error");

            }

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("reg? OK");
            else
                MessageBox.Show("reg? not OK");


            db.closeConnection();
             */



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
