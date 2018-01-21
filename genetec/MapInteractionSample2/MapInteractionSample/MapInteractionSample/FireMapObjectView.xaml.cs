﻿using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

// ==========================================================================
// Copyright (C) 2017 by Genetec, Inc.
// All rights reserved.
// May be used only in accordance with a valid Source Code License Agreement.
// ==========================================================================
namespace MapInteractionSample
{
    /// <summary>
    /// This class handle the display of the FireMapObject on the map.
    /// The view must inherit from MapObjectView.
    /// You can display what you want in the xaml at this point.
    /// </summary>
    public partial class FireMapObjectView
    {
        #region Constants

        public static readonly DependencyProperty IsFireSelectedProperty = DependencyProperty.Register(
                    "IsFireSelected", typeof(bool), typeof(FireMapObjectView), new PropertyMetadata(default(bool)));
        

        #endregion

        #region Properties

        public bool IsFireSelected
        {
            get { return (bool)GetValue(IsFireSelectedProperty); }
            set { SetValue(IsFireSelectedProperty, value); }
        }
        #endregion

        #region Constructors

        public FireMapObjectView()
        {
            InitializeComponent();
            StackPanelKey.MouseEnter += MePlayer_OnMouseEnter;
            StackPanelKey.MouseLeave += MePlayer_OnMouseLeave;
            mePlayer.Source =  new Uri("http://6oo.org/video/flag.png?tmp=" + StaticClass.CountStatic.ToString());
            //mePlayer.Source = new Uri("http://6oo.org/video/flag.png." + StaticClass.CountStatic.ToString());
            mePlayer.Play();
            Texts.Text = StaticClass.CurrentString;
        }

        #endregion

        #region Event Handlers

        private void OnFireImageMouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            IsFireSelected = !IsFireSelected;
        }

        #endregion

        private void MePlayer_OnMouseLeave(object sender, MouseEventArgs e)
        {
            ctl.Width = StackPanelKey.Width / 2;
            ctl.Height = StackPanelKey.Height / 2;
            StackPanelKey.Width = StackPanelKey.Width / 2;
            StackPanelKey.Height = StackPanelKey.Height / 2;
            mePlayer.Width = mePlayer.Width / 2;
            mePlayer.Height = mePlayer.Height / 2;
            Texts.Foreground = Brushes.Navy;
        }

        private void MePlayer_OnMouseEnter(object sender, MouseEventArgs e)
        {
            ctl.Width = StackPanelKey.Width *2;
            ctl.Height = StackPanelKey.Height * 2;
            StackPanelKey.Width = StackPanelKey.Width * 2;
            StackPanelKey.Height = StackPanelKey.Height * 2;
            mePlayer.Width = mePlayer.Width * 2;
            mePlayer.Height = mePlayer.Height * 2;
            Texts.Foreground = Brushes.Red;
        }
        public class A : INotifyPropertyChanged
        {
            public event PropertyChangedEventHandler PropertyChanged;
        }
    }
}

