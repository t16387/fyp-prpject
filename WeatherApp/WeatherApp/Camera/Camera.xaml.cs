
using Plugin.Media;
using Plugin.Media.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WeatherApp.Camera
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Camera : ContentPage
    {
        
        public string ImagePath;
        public Camera()
        {
            InitializeComponent();
        }

        private async void takephoto_button(object sender, EventArgs e)
        {
            await CrossMedia.Current.Initialize();

            if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
            {
                await DisplayAlert("No Camera", ":( No camera available.", "OK");
                return;
            }


            var file = await CrossMedia.Current.TakePhotoAsync(
                new StoreCameraMediaOptions
                {
                    SaveToAlbum = true,
                    Directory = "Sample",
                    Name = "test.jpg"

                }
            );  
            
            if (file == null) 
            {
                
                
                return;
            }

            

            ImagePath = file.Path;

            DisplayImage.Source = ImageSource.FromStream(() =>
            {
                var steam = file.GetStream();
                
                return steam;

            });

            if (file!=null) { 
                label_text.Text = "Your Photo";
                question_label.IsVisible = true;
                comfirm_yes_button.IsVisible = true;
                comfirm_no_button.IsVisible = true;
            } else {
                label_text.Text = "Welcome to camera recognition!";
                question_label.IsVisible = false;
                comfirm_yes_button.IsVisible = false;
                comfirm_no_button.IsVisible = false;
            }
        }

    }
}