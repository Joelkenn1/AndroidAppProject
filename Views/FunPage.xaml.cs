using System;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Notes.Views
{
    //public Uri Ima { get; set; }
    public partial class FunPage : ContentPage
    {
        public FunPage()
        {
            InitializeComponent();
        }

        async void OnPuppyButtonClicked(object sender, EventArgs e)
        {
            await Launcher.OpenAsync("https://www.youtube.com/watch?v=xvFZjo5PgG0");
        }

        async void OnKittenButtonClicked(object sender, EventArgs e)
        {
            await Launcher.OpenAsync("https://c.tenor.com/_4YgA77ExHEAAAAd/rick-roll.gif");
        }

        async void OnAxoButtonClicked(object sender, EventArgs e)
        {
            await Launcher.OpenAsync("https://cf.ltkcdn.net/small-pets/images/orig/284947-1600x1066-ambystoma-mexicanum-f-leucistic-axolotl.jpg");
        }
    }
}