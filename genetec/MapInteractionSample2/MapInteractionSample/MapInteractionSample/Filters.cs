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
        public string CheckBoxName { get; set; }
        public int Counts { get { return _counts; } set { _counts = value; OnPropertyChanged(new PropertyChangedEventArgs("Counts")); } }
        public bool IsChecked { get; set; }

        public Filters(string name)
        {
            CheckBoxName = name;
            Counts = 0;
            IsChecked = false;
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
