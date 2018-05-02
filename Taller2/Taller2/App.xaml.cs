﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Taller2
{
	public partial class App : Application
	{
        public static MasterDetailPage MasterD { get; set; }

        public App ()
		{
			InitializeComponent();

            //	MainPage = new Taller2.MainPage();
            MainPage = new Taller2.Page1();
            MainPage = new NavigationPage(new MainPage());
        }

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
