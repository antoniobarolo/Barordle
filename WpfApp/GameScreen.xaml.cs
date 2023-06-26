﻿using System;
using System.Collections.Generic;
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
    /// <summary>
    /// Interação lógica para GameScreen.xam
    /// </summary>
    public partial class GameScreen : Page
    {
        private User currentUser;
        string answer;
        int lives = 5;
        bool gameOn = true;


        public GameScreen(User user)
        {
            currentUser = user;
            InitializeComponent();
            DataContext = user;
            answer = sortWord();
        }

        private string sortWord()
        {
            Random random = new Random();
            int index = random.Next(0, currentUser.Words.Count);

            return currentUser.Words[index];
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

        private void GuessText_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void guessButton_Click(object sender, RoutedEventArgs e)
        {
            if (gameOn == false)
            {
                return;
            }
            string guess = GuessText.Text.ToUpper();
            TextBlock[] currentText = new TextBlock[5];

            switch (lives)
            {
               
                    
                case 1:
                    currentText[0] = L51;
                    currentText[1] = L52;
                    currentText[2] = L53;
                    currentText[3] = L54;
                    currentText[4] = L55;
                    break;
                case 2:
                    currentText[0] = L41;
                    currentText[1] = L42;
                    currentText[2] = L43;
                    currentText[3] = L44;
                    currentText[4] = L45;
                    break;
                case 3:
                    currentText[0] = L31;
                    currentText[1] = L32;
                    currentText[2] = L33;
                    currentText[3] = L34;
                    currentText[4] = L35;
                    break;
                case 4:
                    currentText[0] = L21;
                    currentText[1] = L22;
                    currentText[2] = L23;
                    currentText[3] = L24;
                    currentText[4] = L25;
                    break;
                case 5:
                    currentText[0] = L11;
                    currentText[1] = L12;
                    currentText[2] = L13;
                    currentText[3] = L14;
                    currentText[4] = L15;
                    break;
                default:
                    break;
            }
            for (int i = 0; i < 5; i++)
            {
                currentText[i].Text = guess[i].ToString();

                if (guess[i] == answer[i])
                {
                    currentText[i].Background = Brushes.Green;
                }
                else if (answer.Contains(guess[i]))
                {
                    currentText[i].Background = Brushes.Yellow;
                }
            }

            if (guess != answer)
                lives--;

            if(lives <= 0)
            {
                gameOn = false;
                currentUser.GamesPlayed++;
                MessageBox.Show("Você perdeu.");
            }

            if(guess == answer)
            {
                currentUser.GamesPlayed++;
                currentUser.Points++;
                MessageBox.Show("Você venceu!");
            }
        }

        private void restart_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new GameScreen(currentUser));
        }

        private void signOut_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new loginPage());
        }

        private void toUserPage_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new userPage(currentUser));
        }
    }
}
