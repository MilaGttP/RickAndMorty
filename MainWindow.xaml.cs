﻿
using System;
using System.Windows;
using System.Windows.Controls;

namespace RickAndMorty
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Switcher.pageSwitcher = this;
            Switcher.Switch(new Main());
        }
        public void Navigate(UserControl nextPage) => this.Content = nextPage;
        public void Navigate(UserControl nextPage, object state)
        {
            this.Content = nextPage;
            ISwitchable s = nextPage as ISwitchable;
            if (s != null) s.UtilizeState(state);
            else throw new ArgumentException("NextPage is not ISwitchable! " + nextPage.Name.ToString());
        }
    }
}
