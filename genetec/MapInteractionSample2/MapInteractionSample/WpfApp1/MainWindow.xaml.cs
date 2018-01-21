using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //private static readonly ObservableCollection<Filters> m_fires = new ObservableCollection<Filters>();
        //private static ObservableCollection<Filters> m_filters = new ObservableCollection<Filters>();
        public MainWindow()
        {
            InitializeComponent();
            //webBrowser.Navigate("https://www.youtube.com/watch?v=4pFQWnQsGwk");

            //m_filters = new System.Collections.ObjectModel.ObservableCollection<Filters>()
            //{
            //    new Filters("Cat"),
            //    new Filters("Dog"),
            //    new Filters("T-Shirt")
            //};
            // Get the fires from the provider to populate the list on the right
            //m_filtersList.ItemsSource = m_filters;
            //m_countsList.ItemsSource = m_filters;
            //try
            //{
            //    WebClient wc = new WebClient();
            //    string somestring = wc.DownloadString("http://6oo.org/video/text.txt");
            //    if (somestring != null && somestring.Length > 0)
            //    {
            //        String[] test = somestring.Split(new string[] { ",","\n" }, StringSplitOptions.None);
            //        //StaticClass.CurrentString = somestring;
            //        Filters toto = m_filters.FirstOrDefault(f => f.CheckBoxName == test[0]);
            //        if (toto != null)
            //        {
            //            int tempInt = 0;
            //            bool testParse = Int32.TryParse(test[1].ToString(), out tempInt);
            //            if (testParse)
            //            {
            //                toto.Counts += tempInt;
            //            }
            //            MessageBox.Show(test[0] + " " + tempInt + " " + test[1]);
            //        }
            //    }
            //}
            //catch (WebException we)
            //{
            //    // add some kind of error processing
            //    MessageBox.Show(we.ToString());
            //}

        

        }
    }
}
//        <MediaElement LoadedBehavior="Play" Source="http://6oo.org/video/Wildlife%20Windows%207%20Sample%20Video-a3ICNMQW7Ok.mp4"  Name="mePlayer2" />
