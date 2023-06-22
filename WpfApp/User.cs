using System;
using System.Collections.Generic;
using System.Text;

namespace WpfApp
{
    internal class User
    {
        public string Name { get; set; }
        
        public int Points { get; set; }

        public List<string> Words { get; set; }

        private static List<string> defaultWords = new List<string> { "jorge", "arana", "teste" };

        public User(string name)
        {
            Name = name;
            Points = 0;
            Words = new List<string>(defaultWords);
        }
    }
}
