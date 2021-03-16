using library_accounting_system.Services;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace library_accounting_system.Resources
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        DataBaseHelper db = new DataBaseHelper();
        public Page1()
        {
            InitializeComponent();
            
        }

        private void Button_SignIn(object sender, RoutedEventArgs e)
        {
            String loginUser = userLoginField.Text;
            String passwordUser = userPasswordField.Password;

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL AND `password` = @uP", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passwordUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
                MessageBox.Show("Yes");
            else
                MessageBox.Show("no");
        }

        private void Button_Register(object sender, RoutedEventArgs e)
        {
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

        }
    }
}
