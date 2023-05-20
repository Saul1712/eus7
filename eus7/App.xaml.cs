using eus7.Vistas;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eus7
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage =new NavigationPage( new Vistas.Login());
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
