using AnimationLottie.Views;
using Lottie.Forms;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace AnimationLottie.Models
{
    class lottie: AnimationView 
    {
        public lottie()
        {

        }
        public  lottie(string animation)
        {
            
            Animation = animation;
            HorizontalOptions = LayoutOptions.FillAndExpand;
            VerticalOptions = LayoutOptions.FillAndExpand;
            IsPlaying = true;
            Loop = true;
            AutoPlay = true;
        }
       
   
    }
}
