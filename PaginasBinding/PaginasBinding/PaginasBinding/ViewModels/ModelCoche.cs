using PaginasBinding.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace PaginasBinding.ViewModels
{
    public class ModelCoche : INotifyPropertyChanged
    {
        public ModelCoche()
        {
            this.Coche = new Coche();
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisePropertyChanged(String propiedad)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propiedad));
        }

       
        private Coche _Coche;

        public Coche Coche
        {
            get { return this._Coche; }
            set
            {
                this._Coche = value;
                RaisePropertyChanged("Coche");
            }
        }
        private String _Descripcion;
        public String Descripcion {
            get { return this._Descripcion; }
            set
            {
                this._Descripcion = value;
                RaisePropertyChanged("Descripcion");
            }
        }

        public String MostrarDescripcion()
        {
            return "Marca: " + this.Coche.Marca + ", Modelo: " + this.Coche.Modelo;
        }

        public Command MostrarCoche
        {
            get
            {
                return new Command(() =>
                {
                    //ACCIONES DEL COMANDO (CLICK)
                    Descripcion = MostrarDescripcion();
                });
            }
            
        }

        public Command NuevoCoche
        {
            get
            {
                return new Command(() =>
                {
                    Coche car = new Coche();
                    car.Marca = "AUDI";
                    car.Modelo = "Q7777";
                    //CREAMOS EL NUEVO COCHE SOBRE LA PROPIEDAD
                    this.Coche = car;
                    Descripcion = MostrarDescripcion();
                });
            }
            
        }


    }
}
