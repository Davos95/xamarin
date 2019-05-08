using PaginasBinding.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace PaginasBinding.ViewModels
{
    public class ModelProducto : INotifyPropertyChanged
    {
        public ModelProducto()
        {
            this.producto = new Producto();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisePropertyChanged(String propiedad)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propiedad));
        }

        private Producto _producto;
        public Producto producto {
            get { return this._producto; }
            set
            {
                this._producto = value;
                RaisePropertyChanged("Producto");
            }
        }

        private String _Descripcion;
        public String Descripcion
        {
            get { return this._Descripcion; }
            set
            {
                this._Descripcion = value;
                RaisePropertyChanged("Descripcion");
            }
        }

        public String MostrarDescripcion()
        {
            return "Nombre del producto: " + this.producto.Nombre + ", categoria: " + this.producto.Categoria + ", precio: " + this.producto.euros + " €";
        }
        public Command MostrarProducto
        {
            get
            {
                return new Command(() =>
                {
                    Descripcion = MostrarDescripcion();
                });
            }
        }
    }
}
