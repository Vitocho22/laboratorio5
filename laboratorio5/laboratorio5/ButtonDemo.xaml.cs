using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace laboratorio5
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ButtonDemo : ContentPage
	{
		public ButtonDemo ()
		{
			InitializeComponent ();
		}

        async void OnButtonClicked(object sender, EventArgs args)
        {
			await Label.RelRotateTo(360, 1000);
        }
    }
}