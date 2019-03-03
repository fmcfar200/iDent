using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace iDent.Models
{
    public class Employee: INotifyPropertyChanged
    {
        public string Name { get; set; }
        public string Role { get; set; }
        public string Desc { get; set; }
        public string DisplayImage { get; set; }
        public bool NameVisible { get; set; } = true;
        public bool DescVisible { get; set; } = false;

        public Employee(string name, string role, string desc, string image)
        {
            this.Name = name;
            this.Role = role;
            this.Desc = desc;
            this.DisplayImage = image;

               
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged()
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(""));
        }
    }
}
