using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WeatherApp.Train
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Train : ContentPage
    {
        public Train()
        {
            InitializeComponent();
            Signlayout.WidthRequest = SignImage.Width;
        }
    }
}