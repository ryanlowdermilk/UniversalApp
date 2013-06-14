using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace PortableClassLibrary
{
    public class Alert : INotifyPropertyChanged
    {
        private string _RawData;
        public string RawData
        {
            get { return _RawData; }
            set { _RawData = value; OnPropertyChanged("RawData"); }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
