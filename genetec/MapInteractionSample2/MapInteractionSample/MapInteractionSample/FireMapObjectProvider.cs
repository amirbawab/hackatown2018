using Genetec.Sdk.Entities;
using Genetec.Sdk.Entities.Maps;
using Genetec.Sdk.Workspace.Components.MapObjectProvider;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using Stream = System.IO.Stream;
using System.Net;
using System.Windows;

// ==========================================================================
// Copyright (C) 2017 by Genetec, Inc.
// All rights reserved.
// May be used only in accordance with a valid Source Code License Agreement.
// ==========================================================================
namespace MapInteractionSample
{
    /// <summary>
    /// This is where you can build the object to display on the map.
    /// </summary>
    public class FireMapObjectProvider : MapObjectProvider, IDisposable
    {
        #region Constants

        private static readonly ObservableCollection<FireMapObject> m_fires = new ObservableCollection<FireMapObject>();
        private static ObservableCollection<Filters> m_filters = new ObservableCollection<Filters>();
        #endregion

        #region Fields

        private bool m_isMapGeoreferenced;
        private Guid m_mapId = Guid.Empty;

        #endregion

        #region Properties

        public override string Name => "Fire analysis map object provider";

        public override Guid UniqueId => new Guid("{BDC5D2F2-DCA0-4FA4-8BF9-4DB6CA3FD7CE}");

        #endregion

        #region Constructors

        public FireMapObjectProvider()
        {
            var thread = new Thread(OnThreadStart)
            {
                Name = "Fire provider",
                IsBackground = true
            };
            thread.Start();
            m_filters = new ObservableCollection<Filters>()
            {
                new Filters("coffee"),
                new Filters("dog"),
                new Filters("food"),
                new Filters("backpack"),
                new Filters("person")
            };
            m_fires.CollectionChanged += OnFiresCollectionChanged;
        }

        #endregion

        #region Destructors and Dispose Methods

        public void Dispose()
        {
            m_fires.CollectionChanged -= OnFiresCollectionChanged;
        }

        #endregion

        #region Event Handlers

        /// <summary>
        /// This is to update the map when an object is added/removed from the fire list.
        /// The Invalidate(...) is important to notify the map of the changes.
        /// </summary>
        private void OnFiresCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            var addedItems = new List<MapObject>();
            var removedItems = new List<MapObject>();

            if (e.NewItems != null)
            {
                foreach (MapObject added in e.NewItems)
                {
                    addedItems.Add(added);
                }
            }

            if (e.OldItems != null)
            {
                foreach (MapObject removed in e.OldItems)
                {
                    removedItems.Add(removed);
                }
            }

            Invalidate(Guid.Empty, addedItems, removedItems, null);
        }

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

                    var fire = new FireMapObject(lat, lon)
                    {
                        Description = "Alarm Triggered!",
                        Date = DateTime.Now
                    };

                    Dispatcher.BeginInvoke(new Action(() =>
                    {
                        m_fires.Add(fire);
                        ++StaticClass.CountStatic;


                        


                        string somestring;
                        try
                        {
                            WebClient wc = new WebClient();
                            somestring = wc.DownloadString("http://6oo.org/video/text.txt");
                            if (somestring != null && somestring.Length > 0)
                            {
                                String[] test = somestring.Split(new string[] { ",", "\n" }, StringSplitOptions.None);
                                StaticClass.CurrentString = somestring;
                                for (int i = 0; i < test.Length; ++i)
                                {
                                    Filters toto = null;
                                    if (i % 2 == 0)
                                    {
                                        toto = m_filters.FirstOrDefault(f => f.CheckBoxName == test[i]);
                                        ++i;
                                        if (toto != null)
                                        {
                                            int tempInt = 0;
                                            bool testParse = Int32.TryParse(test[i].ToString(), out tempInt);
                                            if (testParse)
                                            {
                                                toto.Counts += tempInt;
                                                //MessageBox.Show(test[i] + " " + tempInt + " " + test + toto.Counts);
                                            }
                                            
                                        }
                                        continue;
                                    }
                                    
                                    
                                }
                                
                            }
                        }
                        catch (WebException we)
                        {
                            // add some kind of error processing
                            MessageBox.Show(we.ToString());
                        }

                    }));
                }

                Thread.Sleep(5000);
            }
        }

        #endregion

        #region Public Methods

        public static ReadOnlyObservableCollection<FireMapObject> GetFires()
        {
            return new ReadOnlyObservableCollection<FireMapObject>(m_fires);
        }
        public static ObservableCollection<Filters> GetFilters()
        {
            return new ObservableCollection<Filters>(m_filters);
        }
        public static void RemoveFire(FireMapObject fire)
        {
            m_fires.Remove(fire);
        }

        /// <summary>
        /// This is called everytime there is a change to the map
        /// (Zoom, Pan, load, etc.)
        /// </summary>
        public override IList<MapObject> Query(MapObjectProviderContext context)
        {
            var map = Workspace.Sdk.GetEntity(context.MapId) as Map;

            if (m_mapId != context.MapId)
            {
                Dispatcher.BeginInvoke(new Action(() =>
                {
                    m_fires.Clear();
                }));
            }

            m_mapId = context.MapId;

            // We only provide accidents for geo referenced maps
            if ((map != null) && map.IsGeoReferenced)
            {
                m_isMapGeoreferenced = true;
                var result = new List<MapObject>(m_fires);
                return result;
            }

            m_isMapGeoreferenced = false;

            return null;
        }

        #endregion


    }
}