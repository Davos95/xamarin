using PaginasBinding.ViewModels;
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
	public partial class BindingFecha : ContentPage
	{
        public Fecha Fecha { get; set; }

		public BindingFecha ()
		{
			InitializeComponent ();
            this.Fecha = new Fecha();
            this.Fecha.Dia = DateTime.Now.DayOfWeek.ToString();
            this.Fecha.Mes = DateTime.Now.ToString("MMMM");
            this.Fecha.Anyo = DateTime.Now.Year.ToString();
            
            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                this.Fecha.Hora = DateTime.Now.ToLongTimeString();
                return true;
            });
            
            this.BindingContext = this.Fecha;
        }
	}
}