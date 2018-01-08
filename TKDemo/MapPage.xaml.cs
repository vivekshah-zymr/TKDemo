using System;
using System.Collections.Generic;
using System.Diagnostics;
using Xamarin.Forms;
using TK.CustomMap;

namespace TKDemo
{
    public partial class MapPage : ContentPage
    {
        public MapPage()
        {
            InitializeComponent();
            mapViewTK.MapRegion = MapSpan.FromCenterAndRadius(new Position(23.066138, 72.535848), Distance.FromKilometers(0.4));
            mapViewTK.Pins = new List<TKCustomMapPin>(new[]
            {
               new TKCustomMapPin{Title = "Home Location",Position = new Position(23.066138, 72.535848),ShowCallout = true}
            });
        }

        void Handle_MapClicked(object sender, TK.CustomMap.TKGenericEventArgs<TK.CustomMap.Position> e)
        {
            Debug.WriteLine("Handle_MapClicked");
        }

        void Handle_CalloutClicked(object sender, TK.CustomMap.TKGenericEventArgs<TK.CustomMap.TKCustomMapPin> e)
        {
            Debug.WriteLine("Handle_CalloutClicked");
        }

    }
}
