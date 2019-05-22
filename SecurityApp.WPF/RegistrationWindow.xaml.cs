using SecurityApp.DataAccess;
using SecurityApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace SecurityApp.WPF
{
    /// <summary>
    /// Логика взаимодействия для RegistrationWindow.xaml
    /// </summary>
    public partial class RegistrationWindow : Window
    {
        public RegistrationWindow(MainWindow mainWindow)
        {
            InitializeComponent();
        }

        private void AcceptButtonClick(object sender, RoutedEventArgs e)
        {
            if (loginText.Text.Length > 0 && passwordText.Password.Length > 0)
            {
                using (var context = new SecurityDataContext())
                {
                    string hashedPassword = SecurityApp.Services.CryptoService.HashPassword(passwordText.Password);
                    context.Users.Add(new User()
                    {
                        Login = loginText.Text,
                        Password = hashedPassword
                    });
                    context.SaveChanges();
                }
                MessageBox.Show("Регистрация выполнена");
                this.DialogResult = true;
            }
            else MessageBox.Show("Заполните все поля");
        }
    }
}