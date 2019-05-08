using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace PaginasBinding.ViewModels
{
    //DEBEMOS HEREDAR DE LA INTERFACE
    //INotifyPropertyChanged PARA INDICAR
    //CAMBIOS EN PROPIEDADES SOBRE EL CODIGO XAML
    public class Fecha: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisePropertyChanged(String propiedad)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propiedad));
            }
            
        }
        public Fecha()
        {
            this.Dia = DateTime.Now.DayOfWeek.ToString();
            this.Mes = DateTime.Now.ToString("MMMM");
            this.Anyo = DateTime.Now.Year.ToString();
            this.Hora = DateTime.Now.ToLongTimeString();
            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                this.Hora = DateTime.Now.ToLongTimeString();
                return true;
            });
        }

        //PARA PODER EJECUTAR RAISEPROPERTYCHANGE
        //NECESITAMOS PROPIEDADES EXTENDIDAS EN CADA
        //UNO DE LOS ELEMENTOS QUE NECESITEMOS MODIFICAR

        private String _Hora;

        public String Hora {
            get {
                return this._Hora;
            }
            set {
                this._Hora = value;
                //Propiedad Cambiando...
                RaisePropertyChanged("Hora");
            }
        }

        public String Dia { get; set; }
        public String Mes { get; set; }
        public String Anyo { get; set; }
        

    }
}
