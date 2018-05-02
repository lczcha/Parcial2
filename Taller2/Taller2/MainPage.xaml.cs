using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Taller2
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}
        private void Btnsiclick(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page1());
        }
        private void Btnifmp_Click(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page2());
        }
        private void Btnsup_Click(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page3());
        }
    }
}
