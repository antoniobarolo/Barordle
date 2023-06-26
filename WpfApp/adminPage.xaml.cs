using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    public partial class adminPage : Page, INotifyPropertyChanged
    
    {
        public List<User> userList;
        public adminPage()
        {
            InitializeComponent();
            var mainWindow = (MainWindow)Application.Current.MainWindow;
            userList = mainWindow.userList;
        }
        
   
        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            // Verifica se o caractere digitado é uma letra do alfabeto
            if (!char.IsLetter(e.Text, 0) && !Regex.IsMatch(e.Text, @"^[a-zA-Z]+$"))
            {
                // Define o evento como manipulado para impedir a digitação do caractere
                e.Handled = true;
            }
        }

        public void Reload()
        {
            NavigationService?.Navigate(new adminPage());
        }


        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void signOut_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new loginPage());
        }

        private void LeaderboardComponent_Loaded_1(object sender, RoutedEventArgs e)
        {
            var leaderboardComponent = (LeaderboardComponent)sender;
            List<User> userList;
            var mainWindow = (MainWindow)Application.Current.MainWindow;
            userList = mainWindow.userList;
            foreach(User u in userList)
            {
                if(u.Points !=0) u.PercentageWin = u.Points * 100 / u.GamesPlayed;
                else u.PercentageWin = 0;
            }
            leaderboardComponent.UserList = userList;
      
        }

        private void deleteUserButton_Click(object sender, RoutedEventArgs e)
        {
            if (!userList.Any(u => u.Name == usernameText.Text))
            {
                MessageBox.Show("Nome de usuário inexistente.");
                return;
            }

            userList.Remove(userList.FirstOrDefault(u => u.Name == usernameText.Text));
            MessageBox.Show("Usuário deletado!");
            Reload();
        }
    }
}
