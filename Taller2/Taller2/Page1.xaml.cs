using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Taller2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page1 : MasterDetailPage
    {
		public Page1 ()
		{
			InitializeComponent ();
            this.Master = new Master();
            this.Detail = new NavigationPage(new Detail());

            App.MasterD = this;
        }
	}
}