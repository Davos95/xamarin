using System;
using System.Collections.Generic;
using System.Text;
using XamarinEmpleados.Base;
using XamarinEmpleados.Models;

namespace XamarinEmpleados.ViewModels
{
    public class EmpleadoViewModel: ViewModelBase
    {
        private Empleado _Empleado;
        public Empleado Empleado
        {
            get { return this._Empleado; }
            set
            {
                this._Empleado = value;
                OnPropertyChanged("Empleado");
            }
        }

    }
}
