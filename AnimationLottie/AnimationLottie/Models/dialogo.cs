using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using AnimationLottie.Models;

namespace AnimationLottie.Models
{
   public  class dialogo
    {
        public static StackLayout layout = null;
       
        public static StackLayout Esperar(string animacao)
        {
            Label la = null;
            la = new Label() { Text = "Por favor Aguarde!", TranslationY=-220, FontAttributes=FontAttributes.Bold,FontSize=18, HorizontalOptions=LayoutOptions.Center,VerticalOptions=LayoutOptions.Center, };
            lottie lo = null;
            lo = new lottie(animacao);
            lo.Play();
            layout= new StackLayout() { HorizontalOptions = LayoutOptions.FillAndExpand, VerticalOptions = LayoutOptions.FillAndExpand, };
            layout.Children.Clear();
            layout.Children.Add(lo);
            layout.Children.Add(la);

            return layout;
        }
    }
}
