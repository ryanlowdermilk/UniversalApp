using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using PortableClassLibrary;

namespace PhoneApp75
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            Start();
        }

        private async void Start()
        {
            var alert = new Alert() { RawData = "Started..." };
            var engine = new Engine();
            this.DataContext = alert;
            alert.RawData = await engine.DownloadFeed();
        }
    }
}