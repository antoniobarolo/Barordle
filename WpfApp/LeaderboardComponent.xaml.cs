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
    public partial class LeaderboardComponent : UserControl
    {
        public static readonly DependencyProperty UserListProperty =
          DependencyProperty.Register("UserList", typeof(List<User>), typeof(LeaderboardComponent), new PropertyMetadata(null));

        public List<User> UserList
        {
            get { return (List<User>)GetValue(UserListProperty); }
            set { SetValue(UserListProperty, value); }
        }
        
        public LeaderboardComponent()
        {
            InitializeComponent();
        }
    }
}
