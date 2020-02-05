using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WeatherApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = this;

            this.BackgroundColor = Color.FromRgb(254, 20, 117);
        }

        private async void Train_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Train.Train());
        }

        private async void Camera_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Camera.Camera());
        }

        private void Game_Tapped(object sender, EventArgs e)
        {

        }
    }

   
}
