using DevExpress.Mvvm;
using library_accounting_system.Pages;
using library_accounting_system.Services;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows;
using System.Windows.Input;

namespace library_accounting_system.ViewModels
{
    class RegistrationPageViewModel : BindableBase
    {
        public string userLoginField { get; set; }
        public string Password { private get; set; }
        public string Confirm { private get; set; } 

        private readonly PageService _navigation;

        public RegistrationPageViewModel(PageService navigation)
        {
            _navigation = navigation;
        }

        public ICommand Registration => new DelegateCommand(() =>
        {
            DataBaseHelper db = new DataBaseHelper();

            //получаем поля
            String loginUser = userLoginField;
            String passwordUser = Password;
            String confirmUser = Confirm;

            //провереям на пустоту
            if (loginUser == null|| passwordUser == null || confirmUser == null)
            {
                MessageBox.Show("error empty field");
                return;
            }
                

            //проверяем существование
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            adapter.SelectCommand = command;
            try
            {
                adapter.Fill(table);
            }
            catch (Exception)
            {
                MessageBox.Show("error connect");
                return;
            }
            if (table.Rows.Count > 0 )
            {
                MessageBox.Show("уже есть");
                return;
            }

            //проверяем пароль
            if (passwordUser != confirmUser)
            {
                MessageBox.Show("пароль не совпадает");
                return;
            }

            MySqlCommand command2 = new MySqlCommand("INSERT INTO `users` (`login`, `password`, `is_admin`) VALUES (@newUserLogin, @newUserPassword, '')", db.getConnection());
            command2.Parameters.Add("@newUserLogin", MySqlDbType.VarChar).Value = loginUser;
            command2.Parameters.Add("@newUserPassword", MySqlDbType.VarChar).Value = passwordUser;


            db.openConnection();

            if (command2.ExecuteNonQuery() == 1)
                MessageBox.Show("reg? OK");
            else
                MessageBox.Show("reg? not OK");


            db.closeConnection();
            _navigation.Navigate(new MainLibraryPage());
        });
    }
}
