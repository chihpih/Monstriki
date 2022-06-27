using System;
using System.Collections.Generic;
using System.Text;

namespace Monstri.Info
{
    [Serializable]
    internal class InfoMonstr
    {
        public override string ToString()
        {
            return $"\tНазвание Монстрика: {Name}\n\tГод появления: {YOA}\n\tОткуда родом: {From}\n\tОсобенности: {Peculiarities}";
        }

        public string Name { get; set; }
        public string YOA { get; set; }
        public string From { get; set; }
        public string Peculiarities { get; set; }
        
        public InfoMonstr(string name, string yoa, string from, string peculiarities)
        {
            Name = name;
            YOA = yoa;
            From = from;
            Peculiarities = peculiarities; 
        }
    }
}
