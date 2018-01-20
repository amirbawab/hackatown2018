using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapInteractionSample
{
    public class Filters
    {

        public string CheckBoxName { get; set; }
        public int Counts { get; set; }
        public bool IsChecked { get; set; }

        public Filters(string name)
        {
            CheckBoxName = name;
            Counts = 0;
            IsChecked = false;
        }
    }
}
