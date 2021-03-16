using DevExpress.Mvvm;
using library_accounting_system.Pages;
using library_accounting_system.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace library_accounting_system.ViewModels
{
    class LoginPageViewModel : BindableBase
    {
        public string userLoginField { get; set; }
        public string Password { private get; set; } //не безопасно

        private readonly PageService _navigation;

        public LoginPageViewModel(PageService navigation)
        {
            _navigation = navigation;
        }
        public ICommand SignIn => new DelegateCommand(() =>
        {
            /*DataBaseHelper db = new DataBaseHelper();

            String loginUser = userLoginField;
            String passwordUser = Password;
            bool isConnect = true;

            DataTable table = new DataTable();
            
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL AND `password` = @uP", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passwordUser;

            adapter.SelectCommand = command;
            try
            {
                adapter.Fill(table);
            }
            catch (Exception)
            {
                isConnect = false;
                MessageBox.Show("error connect");
            }

            if (table.Rows.Count > 0 && isConnect)
            {
                //MessageBox.Show("Yes");
                _navigation.Navigate(new MainLibraryPage());
            }
            else
                MessageBox.Show("no login");    */
            _navigation.Navigate(new MainLibraryPage());
        });

        public ICommand Registration => new DelegateCommand(() =>
        {
            //Visibility.Visible = Visibility.Collapsed;
            _navigation.Navigate(new RegistrationPage());
        });


    }
}
