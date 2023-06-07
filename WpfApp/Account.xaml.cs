using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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


namespace WpfApp
{
    /// <summary>
    /// Lógica interna para Account.xaml
    /// </summary>
    public partial class Account : Window
    {
        List<User> userList = new List<User>();

        public Account()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
            if (!userList.Any(u => u.Name == SignInText.Text))
            {
                MessageBox.Show("Nome de usuário inexistente.");
                return;
            }

            MessageBox.Show("Login com sucesso!");
            MainWindow mainWindow = new MainWindow();

        }

        private void signupButton_Click(object sender, RoutedEventArgs e)
        {
            if(userList.Any(u => u.Name == SignUpText.Text)){
                MessageBox.Show("Nome de usuário já existe. Por favor, escolha outro nome de usuário.");
                return;
            }

            User newUser = new User(name: SignUpText.Text);
            userList.Add(newUser);


            MessageBox.Show("Usuário criado com sucesso!");

        }
    }
}
