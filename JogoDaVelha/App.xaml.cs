using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JogoDaVelha
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new SelectionPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
