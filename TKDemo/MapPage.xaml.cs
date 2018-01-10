using System;
using System.Collections.Generic;
using System.Diagnostics;
using Xamarin.Forms;
using TK.CustomMap;
using Plugin.Geolocator;
using TKDemo.ViewModels;

namespace TKDemo
{
    public partial class MapPage : ContentPage
    {
        public MapPage()
        {
            InitializeComponent();
            setUI();
            BindingContext = new SampleViewModel();
        }

        async void setUI()
        {
            var locator = CrossGeolocator.Current;
            var newYork = new Position(40.7142700, -74.0059700);
            //if (locator.IsGeolocationAvailable && locator.IsGeolocationEnabled)
            //{
            //    locator.DesiredAccuracy = 50;
            //    await locator.StartListeningAsync(new TimeSpan(1000), 5000, false);
            //    var position = await locator.GetPositionAsync(timeout: new TimeSpan(30000));
            //    var lat = position.Latitude;
            //    var lng = position.Longitude;
            //    newYork = new Position(position.Latitude, position.Longitude);
            //    mapViewTK.MapRegion = MapSpan.FromCenterAndRadius(new Position(lat, lng), Distance.FromKilometers(0.4));
            //    mapViewTK.Pins = new List<TKCustomMapPin>(new[]
            //    {
            //        new TKCustomMapPin{Title = "Home Location",Position = new Position(lat, lng),ShowCallout = true}
            //    });
            //    var result = await locator.StopListeningAsync();
            //}

            var autoComplete = new PlacesAutoComplete { ApiToUse = PlacesAutoComplete.PlacesApi.Google };
            autoComplete.SetBinding(PlacesAutoComplete.PlaceSelectedCommandProperty, "PlaceSelectedCommand");

            var mapViewTK = new TKCustomMap(MapSpan.FromCenterAndRadius(newYork, Distance.FromKilometers(2)));
            mapViewTK.SetBinding(TKCustomMap.IsClusteringEnabledProperty, "IsClusteringEnabled");
            mapViewTK.SetBinding(TKCustomMap.GetClusteredPinProperty, "GetClusteredPin");
            mapViewTK.SetBinding(TKCustomMap.PinsProperty, "Pins");
            mapViewTK.SetBinding(TKCustomMap.MapClickedCommandProperty, "MapClickedCommand");
            mapViewTK.SetBinding(TKCustomMap.MapLongPressCommandProperty, "MapLongPressCommand");

            mapViewTK.SetBinding(TKCustomMap.PinSelectedCommandProperty, "PinSelectedCommand");
            mapViewTK.SetBinding(TKCustomMap.SelectedPinProperty, "SelectedPin");
            mapViewTK.SetBinding(TKCustomMap.RoutesProperty, "Routes");
            mapViewTK.SetBinding(TKCustomMap.PinDragEndCommandProperty, "DragEndCommand");
            mapViewTK.SetBinding(TKCustomMap.CirclesProperty, "Circles");
            mapViewTK.SetBinding(TKCustomMap.CalloutClickedCommandProperty, "CalloutClickedCommand");
            mapViewTK.SetBinding(TKCustomMap.PolylinesProperty, "Lines");
            mapViewTK.SetBinding(TKCustomMap.PolygonsProperty, "Polygons");
            mapViewTK.SetBinding(TKCustomMap.MapRegionProperty, "MapRegion");
            mapViewTK.SetBinding(TKCustomMap.RouteClickedCommandProperty, "RouteClickedCommand");
            mapViewTK.SetBinding(TKCustomMap.RouteCalculationFinishedCommandProperty, "RouteCalculationFinishedCommand");
            mapViewTK.SetBinding(TKCustomMap.TilesUrlOptionsProperty, "TilesUrlOptions");
            mapViewTK.SetBinding(TKCustomMap.MapFunctionsProperty, "MapFunctions");
            mapViewTK.IsRegionChangeAnimated = true;

            autoComplete.SetBinding(PlacesAutoComplete.BoundsProperty, "MapRegion");
            Content = mapViewTK;
        }
        void Handle_MapClicked(object sender, TK.CustomMap.TKGenericEventArgs<TK.CustomMap.Position> e)
        {
            Debug.WriteLine("Handle_MapClicked");
        }

        void Handle_CalloutClicked(object sender, TK.CustomMap.TKGenericEventArgs<TK.CustomMap.TKCustomMapPin> e)
        {
            Debug.WriteLine("Handle_CalloutClicked");
        }
        #region Tap Events

        void didTapBack(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        #endregion
    }
}