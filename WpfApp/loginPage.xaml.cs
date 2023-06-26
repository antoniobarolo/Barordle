using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp
{
    /// <summary>
    /// Interação lógica para loginPage.xam
    /// </summary>
    public partial class loginPage : Page
    {
        List<User> userList;
        public loginPage()
        {
            InitializeComponent();

            var mainWindow = (MainWindow)Application.Current.MainWindow;

             userList = mainWindow.userList;

        }
       
        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
            if (SignInText.Text == "admin")
            {
                NavigationService?.Navigate(new adminPage());
                MessageBox.Show("Login de administrador");
                return;
            }

            if (!userList.Any(u => u.Name == SignInText.Text))
            {
                MessageBox.Show("Nome de usuário inexistente.");
                return;
            }

            MessageBox.Show("Login com sucesso!");

            NavigationService?.Navigate(new userPage(userList.FirstOrDefault(u => u.Name == SignInText.Text)));

        }

        private void signupButton_Click(object sender, RoutedEventArgs e)
        {
            if (userList.Any(u => u.Name == SignUpText.Text) | SignUpText.Text == "admin")
            {
                MessageBox.Show("Nome de usuário já existe. Por favor, escolha outro nome de usuário.");
                return;
            }

            User newUser = new User(name: SignUpText.Text);
            userList.Add(newUser);


            MessageBox.Show("Usuário criado com sucesso!");

        }
    }
}

