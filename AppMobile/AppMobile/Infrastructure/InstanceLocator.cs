﻿using AppMobile.ViewModel;

namespace AppMobile.Infrastructure
{
    public class InstanceLocator
    {
        #region Properties

        public MainViewModel Main
        {
            get;
            set;
        }

        #endregion Properties

        #region Constructors

        public InstanceLocator()
        {
            this.Main = new MainViewModel();
        }

        #endregion Constructors
    }
}