﻿using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using AgFx;

namespace JeffWilcox.FourthAndMayor
{
    public class GeocodeViewModel : NotifyPropertyChangedBase
    {
        private string _lastKnownCity;
        public string LastKnownCity
        {
            get { return _lastKnownCity; }
            set
            {
                _lastKnownCity = value;
                RaisePropertyChanged("LastKnownCity");
            }
        }

        private string _lastKnownState;
        public string LastKnownState
        {
            get { return _lastKnownState; }
            set
            {
                _lastKnownState = value;
                RaisePropertyChanged("LastKnownState");
            }
        }

        private string _displayText;
        public string DisplayText
        {
            get { return _displayText; }
            set
            {
                _displayText = value;
                RaisePropertyChanged("DisplayText");
            }
        }

        private bool _isAccurate;
        public bool IsAccurate
        {
            get { return _isAccurate; }
            set
            {
                _isAccurate = value;
                RaisePropertyChanged("IsAccurate");
            }
        }
    }
}
