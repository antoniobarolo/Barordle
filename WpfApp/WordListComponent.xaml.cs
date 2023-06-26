using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public partial class WordListComponent : UserControl
    {
        public static readonly DependencyProperty WordsProperty =
            DependencyProperty.Register("Words", typeof(List<string>), typeof(WordListComponent), new PropertyMetadata(null));


        public List<string> Words
        {
            get { return (List<string>)GetValue(WordsProperty); }
            set { SetValue(WordsProperty, value); }
        }

        public WordListComponent()
        {
            InitializeComponent();
           
        }

        private void RemoveButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Palavra removida!");
            Button removeButton = (Button)sender;
            string wordToRemove = removeButton.Tag as string;

            if (Words != null && Words.Contains(wordToRemove))
            {
                Words.Remove(wordToRemove);
                OnPropertyChanged(nameof(Words));
            }

            userPage parentPage = FindParentPage();
            parentPage?.Reload();
            
        }

        private userPage FindParentPage()
        {
            DependencyObject parent = VisualTreeHelper.GetParent(this);

            while (parent != null && !(parent is userPage))
            {
                parent = VisualTreeHelper.GetParent(parent);
            }

            return parent as userPage;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}