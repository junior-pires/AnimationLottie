using Lottie.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AnimationLottie.Models;

namespace AnimationLottie.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Animation : ContentPage
    {
        public Animation()
        {
            InitializeComponent();
        }
      
        protected override async void OnAppearing()
        {
            Content = null;
            Content = dialogo.Esperar("ideal.json");
            await Task.Delay(4000);
            Content = pagina;
           
        }
    }
}