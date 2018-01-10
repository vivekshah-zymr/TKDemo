using System;
using System.Collections.Generic;
using TK.CustomMap.Overlays;
using Xamarin.Forms;
using TKDemo.ViewModels;

namespace TKDemo
{
    public partial class HtmlInstructionsPage : ContentPage
    {
        public HtmlInstructionsPage(TKRoute route)
        {
            InitializeComponent();
            BindingContext = new HtmlInstructionsViewModel(route);
        }
    }
}
