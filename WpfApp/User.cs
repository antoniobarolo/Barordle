using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Runtime.CompilerServices;

namespace WpfApp
{
   public class User : INotifyPropertyChanged
    {
        public string Name { get; set; }
        
        public int Points { get; set; }

        public int GamesPlayed { get; set; }
        public List<string> Words { get; set; }

        private static List<string> defaultWords = new List<string> { "JORGE", "ARANA", "TESTE" };

        public User(string name)
        {
            Name = name;
            Points = 0;
            GamesPlayed = 0;
            Words = new List<string>(defaultWords);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
