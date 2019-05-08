using BasesDatos.Models;
using BasesDatos.Repositories;
using BasesDatos.ViewModels;
using BasesDatos.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BasesDatos
{
    public partial class MainPage : ContentPage
    {
        RepositoryDepartamentos repo;

        public MainPage()
        {
            InitializeComponent();
            this.repo = new RepositoryDepartamentos();
            this.repo.CrearBBDD();
            this.botonmostrar.Clicked += Botonmostrar_Clicked;
            this.botonnuevo.Clicked += Botonnuevo_Clicked;
            this.botonborrar.Clicked += Botonborrar_Clicked;
            this.botonmodificar.Clicked += Botonmodificar_Clicked;
        }

        private async void Botonmostrar_Clicked(object sender, EventArgs e)
        {
            DepartamentosView view = new DepartamentosView();
            await Navigation.PushModalAsync(view);
        }

        private async void Botonnuevo_Clicked(object sender, EventArgs e)
        {
            InsertarDepartamento view = new InsertarDepartamento();
            await Navigation.PushModalAsync(view);
        }

        private async void Botonmodificar_Clicked(object sender, EventArgs e)
        {
            ModificarDepartamento view = new ModificarDepartamento();
            DepartamentoModel viewmodel = new DepartamentoModel();
            //BUSCAR EL NUMERO DEPARTAMENTO
            int num = int.Parse(this.cajanumero.Text);
            //ASOCIAR EL DEPARTAMENTO DEL VIEWMODEL CON DICHO NUMERO
            Departamento dept = this.repo.BuscarDepartamento(num);
            viewmodel.Departamento = dept;
            view.BindingContext = viewmodel;
            await Navigation.PushModalAsync(view);
        }

        private async void Botonborrar_Clicked(object sender, EventArgs e)
        {
            EliminarDepartamento view = new EliminarDepartamento();
            DepartamentoModel viewmodel = new DepartamentoModel();
            int num = int.Parse(this.cajanumero.Text);
            Departamento departamento = this.repo.BuscarDepartamento(num);
            viewmodel.Departamento = departamento;
            view.BindingContext = viewmodel;
            await Navigation.PushModalAsync(view);
        }

       


    }
}
