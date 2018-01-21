using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapInteractionSample
{
    public class Filters : INotifyPropertyChanged
    {
        private int _counts = 0;
        private bool _isChecked = false;
        private string _visibility = "Visible";
        public string CheckBoxName { get; set; }
        public string Visibility { get { return _visibility; } set { _visibility = value; OnPropertyChanged(new PropertyChangedEventArgs("Visibility")); } }
        public int Counts { get { return _counts; } set { _counts = value; OnPropertyChanged(new PropertyChangedEventArgs("Counts")); } }
        public bool IsChecked { get { return _isChecked; }
            set
            {
                _isChecked = value;
                Visibility = _isChecked ? "Visible" : "Hidden";
                OnPropertyChanged(new PropertyChangedEventArgs("IsChecked")); 
                
            } }

        public Filters(string name)
        {
            CheckBoxName = name;
            Counts = 0;
            IsChecked = true;
            
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, e);
            }
        }
    }
}
