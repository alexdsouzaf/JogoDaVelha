using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace JogoDaVelha
{
    public class Page2 : ContentPage
    {
        Button btnX = new Button()
        {
            Text = "X"
        };
        Button btnO = new Button()
        {
            Text="O",            
        };

        
        public Page2()
        {

            btnO.Clicked += BtnO_Clicked;
            btnX.Clicked += BtnX_Clicked;
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Jogar com:" },
                    new FlexLayout
                    {
                        HorizontalOptions = LayoutOptions.Center,
                        Children =
                        {
                            btnX,
                            btnO
                        }
                    }
                }
            };
        }

        private void BtnX_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage( new MainPage2(true,false));
        }

        private void BtnO_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new MainPage2(false, true));
        }
    }
}