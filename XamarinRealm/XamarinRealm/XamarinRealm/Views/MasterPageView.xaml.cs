using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinRealm.Models;

namespace XamarinRealm.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterPageView : MasterDetailPage
    {
        public List<MenuPagina> MiMenu { get; set; }
        public MasterPageView()
        {
            InitializeComponent();
            MiMenu = new List<MenuPagina>();
            MenuPagina pag1 = new MenuPagina()
            {
                Titulo = "Insertar Personaje", Pagina = typeof(InsertPersonaje)
            };
            MiMenu.Add(pag1);
            
            MenuPagina pag2 = new MenuPagina()
            {
                Titulo = "Home",
                Pagina = typeof(Personajes)
            };
            MiMenu.Add(pag2);
            this.lsvmenu.ItemsSource = MiMenu;
            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(Personajes)));

            this.lsvmenu.ItemSelected += Lsvmenu_ItemSelected;
        }

        private void Lsvmenu_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            MenuPagina pagina = e.SelectedItem as MenuPagina;
            Detail = new NavigationPage((Page)Activator.CreateInstance(pagina.Pagina));
            IsPresented = false;
        }

        
    }
}