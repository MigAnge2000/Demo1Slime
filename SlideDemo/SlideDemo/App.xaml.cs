using SlideDemo.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SlideDemo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new FatherPage();
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
