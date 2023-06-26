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
    public partial class userPage : Page, INotifyPropertyChanged
    
    {
    
        
        private User currentUser;
        public userPage(User user)
        {
           
            InitializeComponent();
            currentUser = user;
            DataContext = user;
            userGreet.Content = "Olá, " + currentUser.Name;
            pointLabel.Content = currentUser.Points + " pontos";
            if(currentUser.GamesPlayed != 0) {
            percentageLabel.Content = (currentUser.Points * 100 / currentUser.GamesPlayed) + "% de vitória";
            }
    
           
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

        private void newWordButton_Click(object sender, RoutedEventArgs e)
        {
            if(newWordText.Text.Length != 5)
            {
                MessageBox.Show("Palavra deve ter exatamente 5 letras");
                newWordText.Text = string.Empty;
                return;
            }
            MessageBox.Show("Palavra criada!");
            currentUser.Words.Add(newWordText.Text.ToUpper());
            newWordText.Text = string.Empty;

            Reload();

        }

        public void Reload()
        {
            NavigationService?.Navigate(new userPage(currentUser));
        }


        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private void newWordText_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void WordListComponent_Loaded_1(object sender, RoutedEventArgs e)
        {

        }

        private void toGameScreen_Click(object sender, RoutedEventArgs e)
        {

            NavigationService?.Navigate(new GameScreen(currentUser));
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
    }
}
