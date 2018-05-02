using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Taller2.Clases;

namespace Taller2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page5 : ContentPage
	{
		public Page5 ()
		{
			InitializeComponent ();
		}
        public async void btn1_click(object sender, EventArgs e)
        {
            {
            try
            {
                UserManager manager = new UserManager();
                var res = await manager.getUsuarios();
                System.Diagnostics.Debug.WriteLine(res);
                if (res != null)
                {
                    lstUsuarios.ItemsSource = res;
                }
            }
            catch (Exception e1) { }
        }
    }
}
}