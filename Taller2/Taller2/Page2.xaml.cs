﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Taller2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page2 : ContentPage
	{
		public Page2 ()
		{
			InitializeComponent ();

		}

  
        private async void Btnrpa_Click(object sender, EventArgs e)
        {

            String emai = botxemail.Text;
           await Navigation.PushAsync(new Page6(emai));

        }
    }
}