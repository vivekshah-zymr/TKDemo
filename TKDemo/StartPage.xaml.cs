using Xamarin.Forms;
using System.Diagnostics;
using TK.CustomMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TKDemo
{
    public partial class StartPage : ContentPage
    {
        public StartPage()
        {
            InitializeComponent();
        }

        void didTapMapCode(object sender, System.EventArgs e)
        {
            ContentPage newPage = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new MyMap
                        {
                            MapRegion = MapSpan.FromCenterAndRadius(new Position(40.7142700, -74.0059700), Distance.FromKilometers(1)),
                            Pins = new List<TKCustomMapPin>(new[]
                            {
                                new TKCustomMapPin
                                {
                                    Title = "Custom Callout Sample",
                                    Position = new Position(40.7142700, -74.0059700),
                                    ShowCallout = true
                                }
                            })
                        }
                    }
                }
            };
            Navigation.PushAsync(newPage);
        }

        void didTapMapXAML(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new MapPage());
        }
    }
}
