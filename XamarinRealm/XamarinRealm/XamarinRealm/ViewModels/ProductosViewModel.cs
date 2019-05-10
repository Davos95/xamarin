using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;
using XamarinRealm.Base;
using XamarinRealm.Models;
using XamarinRealm.Services;
using XamarinRealm.Views.Views;

namespace XamarinRealm.ViewModels
{
    public class ProductosViewModel: ViewModelBase
    {
        public ProductosViewModel()
        {
            this.CargarProductos();
        }
        private void CargarProductos()
        {
            SessionService session = App.Locator.SessionService;
            List<Producto> lista = session.Productos;
            this.Productos = new ObservableCollection<Producto>(lista);
        }

        public Command NuevoProducto
        {
            get
            {
                return new Command(async () =>
                {
                    Productos1 view = new Productos1();
                    await Application.Current.MainPage.Navigation.PushModalAsync(view);
                    MessagingCenter.Subscribe<ProductosViewModel>(this, "UPDATE", (sender) =>
                    {
                        //CUANDO ALGUIEN NOS DE UNA RESPUESTA A UPDATE ENTRARA EN ESTE CODIGO.
                        //sender ES EL OBJETO QUE NOS ENVIAN DESDE LA RESPUESTA
                        this.CargarProductos();
                    });
                });
            }
        }

        private ObservableCollection<Producto> _Productos;
        public ObservableCollection<Producto> Productos
        {
            get { return this._Productos; }
            set
            {
                this._Productos = value;
                OnPropertyChanged("Productos");
            }
        }
    }
}
