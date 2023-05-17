using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Sales
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        async void TapGestureRecognizer_Tapped(System.Object sender, System.EventArgs e)
        {
           await  Navigation.PopAsync();
        }
    }
}
