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

        public int? PercentageWin { get; set; }
        public List<string> Words { get; set; }


        private static List<string> defaultWords = new List<string> { "SAGAZ", "TERMO", "TESTE", "NOBRE", "AFETO", "VIGOR", "IDEIA", "CARNE", "SONHO", "ICONE", "HONRA", "MUITO", "PODER", "VINHO", "METAL", "LOUCO", "IMPOR", "DENSO", "CULTO"};

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

        protected bool SetProperty<T>(ref T field, T newValue, [CallerMemberName] string propertyName = null)
        {
            if (!Equals(field, newValue))
            {
                field = newValue;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
                return true;
            }

            return false;
        }

        private List<User> users;

        public List<User> Users { get => users; set => SetProperty(ref users, value); }
    }
}
