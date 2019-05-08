using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinRealm.Configuration;
using XamarinRealm.Views;
using XamarinRealm.Views.Views;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace XamarinRealm
{
    public partial class App : Application
    {
        //VAMOS A TENER UNA PROPIEDAD LLAMADA LOCATOR QUE NOS PERMITIRA ACCEDER A TODAS LAS CLASES QUE TENGAMOS DENTRO DE IoCConfiguration

        private static IoCConfiguration _Locator;
        //CREAMOS LA PROPIEDAD STATIC PARA DECOLCER IoC
        public static IoCConfiguration Locator
        {
            get { return _Locator = _Locator ?? new IoCConfiguration(); }
        }

        public App()
        {
            InitializeComponent();

            MainPage = new PrincipalProductos();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
