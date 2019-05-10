using System;
using System.Collections.Generic;
using System.Text;
using XamarinDoctores.Base;
using XamarinDoctores.Models;

namespace XamarinDoctores.ViewModel
{
    public class DoctorViewModel: ViewModelBase
    {
        private Doctor _Doctor;
        public Doctor Doctor
        {
            get
            {
                return this._Doctor;
            }
            set
            {
                this._Doctor = value;
                OnPropertyChanged("Doctor");
            }
        }
    }
}
