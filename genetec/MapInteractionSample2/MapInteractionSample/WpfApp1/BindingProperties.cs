using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WpfApp1
{
    class BindingProperties
    {
        #region Constants

        private static readonly ObservableCollection<Filters> m_fires = new ObservableCollection<Filters>();
        private static ObservableCollection<Filters> m_filters = new ObservableCollection<Filters>();
        #endregion

        #region Fields

        private bool m_isMapGeoreferenced;
        private Guid m_mapId = Guid.Empty;

        #endregion

        #region Properties


        #endregion

        #region Constructors

        public BindingProperties()
        {
            var thread = new Thread(OnThreadStart)
            {
                Name = "Fire provider",
                IsBackground = true
            };
            thread.Start();
            m_filters = new System.Collections.ObjectModel.ObservableCollection<Filters>()
            {
                new Filters("Cat"),
                new Filters("Dog"),
                new Filters("T-Shirt")
            };
        }

        #endregion

        #region Destructors and Dispose Methods

        public void Dispose()
        {
        }

        #endregion

        #region Event Handlers

        

        /// <summary>
        /// Simple thread to generate a fire every 5 second on a random location in montreal.
        /// </summary>
        private void OnThreadStart()
        {
            Random random = new Random();

            while (true)
            {
                if (m_isMapGeoreferenced && m_mapId != Guid.Empty)
                {
                    var lat = Convert.ToDouble("45." + random.Next(405052, 682052));
                    var lon = Convert.ToDouble("-73." + random.Next(486714, 981099));

                }

                Thread.Sleep(5000);
            }
        }

        #endregion


    }
}
