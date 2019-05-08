using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PaginasBinding
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class BindingObject : ContentPage
	{
		public BindingObject ()
		{
			InitializeComponent ();
		}
	}
}