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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int lives = 5;
        bool gameOn = true;
        string answer = "JORGE";
        public MainWindow()
        {
            InitializeComponent();
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
                case 0:
                    gameOn = false;
                    return;
                case 1:
                    currentText[0] = L51;
                    currentText[1] = L52;
                    currentText[2] = L53;
                    currentText[3] = L54;
                    currentText[4] = L55;
                    break;  
                case 2:
                    currentText[0] = L41;
                    currentText[1] =  L42;
                    currentText[2] =  L43;
                    currentText[3] =  L44;
                    currentText[4] =  L45;
                    break;  
                case 3:
                    currentText[0] = L31;
                   currentText[1] =   L32;
                   currentText[2] =   L33;
                   currentText[3] =   L34;
                   currentText[4] =   L35;
                    break;  
                case 4:
                    currentText[0] = L21;
                   currentText[1] =   L22;
                   currentText[2] =   L23;
                   currentText[3] =   L24;
                   currentText[4] =   L25;
                    break;  
                case 5:
                    currentText[0] =     L11;
                    currentText[1] =     L12;
                    currentText[2] =     L13;
                    currentText[3] =     L14;
                    currentText[4] =     L15;
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
        }
    }
}
