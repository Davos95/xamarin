using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinEmpleados.Views;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace XamarinEmpleados
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new EmpleadosView();
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
