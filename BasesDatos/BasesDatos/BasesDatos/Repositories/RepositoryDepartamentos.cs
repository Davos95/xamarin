using BasesDatos.Dependencies;
using BasesDatos.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.Linq;

namespace BasesDatos.Repositories
{
    public class RepositoryDepartamentos
    {
        private SQLiteConnection cn;

        public RepositoryDepartamentos()
        {
            this.cn =
                DependencyService.Get<IDataBase>().GetConnection();
        }

        public void CrearBBDD()
        {
            this.cn.DropTable<Departamento>();
            this.cn.CreateTable<Departamento>();
        }

        public List<Departamento> GetDepartamentos()
        {
            //TableQuery<Departamento> 
            var consulta =
                from datos in cn.Table<Departamento>()
                select datos;
            return consulta.ToList();    
        }

        public Departamento BuscarDepartamento(int num)
        {
            var consulta = from datos in cn.Table<Departamento>()
                           where datos.Numero == num
                           select datos;
            return consulta.FirstOrDefault();
        }

        public void InsertarDepartamento(int num, String nom, String loc)
        {
            Departamento dept = new Departamento();
            dept.Numero = num;
            dept.Nombre = nom;
            dept.Localidad = loc;
            this.cn.Insert(dept);
        }

        public void ModificarDepartamento(int num, String nom, String loc)
        {
            Departamento dept = this.BuscarDepartamento(num);
            dept.Nombre = nom;
            dept.Localidad = loc;
            this.cn.Update(dept);
        }

        public void EliminarDepartamento(int num)
        {
            Departamento dept = this.BuscarDepartamento(num);
            this.cn.Delete<Departamento>(dept);
        }
    }
}
