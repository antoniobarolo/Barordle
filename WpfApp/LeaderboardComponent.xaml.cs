using System;
using System.Collections.Generic;
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
    /// Interação lógica para LeaderboardComponent.xaml
    /// </summary>
    public partial class LeaderboardComponent : UserControl
    {
        public List<User> Users { get; set; }

        public LeaderboardComponent()
        {
            InitializeComponent();
            Users = new List<User>(); // Inicialize a lista de usuários aqui
            DataContext = this;
        }
    }
}
