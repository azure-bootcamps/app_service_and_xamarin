﻿using Xamarin.Forms;

namespace MobileBootcamp
{
    public class App : Application
    {
        public App()
        {
            this.MainPage = new NavigationPage(new HomeView());
        }
    }
}
