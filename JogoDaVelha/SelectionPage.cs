using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace JogoDaVelha
{
    public class SelectionPage : ContentPage
    {
        Button btnX = new Button()
        {
            Text = "X"
        };
        Button btnO = new Button()
        {
            Text = "O",            
        };

        
        public SelectionPage()
        {
            btnO.Clicked += BtnO_Clicked;
            btnX.Clicked += BtnX_Clicked;

            this.Content = new StackLayout
            {
                Margin = new Thickness(100, 0, 0, 0),
                VerticalOptions = LayoutOptions.CenterAndExpand,
                Children = {
                    new Label { Text = "        Jogar com:", FontSize = 20 },
                    new FlexLayout
                    {
                        
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