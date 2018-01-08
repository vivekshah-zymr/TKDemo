using Xamarin.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TK.CustomMap;
using TK.CustomMap.Api;
using TK.CustomMap.Api.Google;

namespace TKDemo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            GmsPlace.Init("AIzaSyADpUdHb2a44fRcsxtIrKl5JvWzosq3Ihs");
            GmsDirection.Init("AIzaSyBmEqmCV4WQG5NwY0_JRqTxB_1eFTLd-ok");

            MainPage = new NavigationPage();
            MainPage.Navigation.PushAsync(new StartPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
