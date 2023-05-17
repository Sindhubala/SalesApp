using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Sales
{
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        async void TapGestureRecognizer_Tapped(System.Object sender, System.EventArgs e)
        {
            await Navigation.PopAsync();
        }

        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new HomePage());
        }

       
    }
}
