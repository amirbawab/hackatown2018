using Genetec.Sdk;
using Genetec.Sdk.Entities;
using Genetec.Sdk.Workspace;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

// ==========================================================================
// Copyright (C) 2017 by Genetec, Inc.
// All rights reserved.
// May be used only in accordance with a valid Source Code License Agreement.
// ==========================================================================
namespace MapInteractionSample
{
    /// <summary>
    /// This is the class that handle the view of the MapFireAnalysisPage.
    /// <maps:MapControl x:Name="m_mapControl" /> is the control you need to add
    /// to be able to display a map.
    /// After that, you need to tell the control the Guid of which map to display.
    /// </summary>
    public partial class MapFireAnalysisView : IDisposable
    {
        #region Properties

        public Workspace Workspace
        {
            get;
            private set;
        }

        #endregion

        #region Constructors

        public MapFireAnalysisView()
        {
            InitializeComponent();

            // Get the fires from the provider to populate the list on the right
            m_fireList.ItemsSource = FireMapObjectProvider.GetFires();
            m_filtersList.ItemsSource = FireMapObjectProvider.GetFilters();
            m_countsList.ItemsSource = FireMapObjectProvider.GetFilters();
        }

        #endregion

        #region Destructors and Dispose Methods

        public void Dispose()
        {
            if (m_mapControl != null)
            {
                m_mapControl.Dispose();
                m_mapControl = null;
            }
        }

        #endregion

        #region Event Handlers

        private void OnComboMapsSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Change the map when an area is selected.
            m_mapControl.Map = ((MapSelection)m_comboMaps.SelectedItem).Id;
        }

        private void OnFireListboxContextMenuClick(object sender, RoutedEventArgs e)
        {
            // Remove an item from the map.
            if (m_fireList.SelectedItem != null)
            {
                FireMapObjectProvider.RemoveFire((FireMapObject)m_fireList.SelectedItem);
            }
        }

        private void OnFireListMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            // Take the item from the list, gets the longitude and latitude and set the center of the map.
            if (m_fireList.SelectedItem != null)
            {
                var fire = m_fireList.SelectedItem as FireMapObject;
                m_mapControl.Center = new GeoCoordinate(fire.Latitude, fire.Longitude);
            }
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Initialize the view.
        /// </summary>
        /// <param name="workspace">The workspace.</param>
        public void Initialize(Workspace workspace)
        {
            if (workspace == null)
                throw new ArgumentNullException("workspace");

            Workspace = workspace;
            m_mapControl.Initialize(workspace);

            // Query the directory for all the Area in the system
            var entities = Workspace.Sdk.GetEntities(EntityType.Area);
            if (entities != null)
            {
                foreach (Area entity in entities)
                {
                    if (entity.MapId != Guid.Empty)
                    {
                        m_comboMaps.Items.Add(new MapSelection { Id = entity.MapId, Name = entity.Name });
                    }
                }
            }
        }

        #endregion
    }

    internal class MapSelection
    {
        #region Properties

        public Guid Id { get; set; }

        public string Name { get; set; }

        #endregion
    }
}

