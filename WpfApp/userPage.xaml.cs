using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interação lógica para userPage.xam
    /// </summary>
    public partial class userPage : Page, INotifyPropertyChanged
    
    {
        private User currentUser;
        public userPage(User user)
        {
            currentUser = user;
            InitializeComponent();
            DataContext = user;
            userGreet.Content = "Olá, " + currentUser.Name;
          
        }
        
   
        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            // Verifica se o caractere digitado é uma letra do alfabeto
            if (!char.IsLetter(e.Text, 0))
            {
                // Define o evento como manipulado para impedir a digitação do caractere
                e.Handled = true;
            }
        }

        private void newWordButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Palavra criada!");
            currentUser.Words.Add(newWordText.Text);
            newWordText.Text = string.Empty;

            OnPropertyChanged(nameof(currentUser.Words));
   
            MessageBox.Show(currentUser.Words.Last());
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
            this.Content = new GameScreen(User);
        }

    }
}
