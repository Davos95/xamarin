using Realms;
using System;
using System.Collections.Generic;
using System.Text;
using XamarinRealm.Models;
using System.Linq;

namespace XamarinRealm.Repository
{
    public class RepositoryRealm
    {
        private Realm conexion;
        public RepositoryRealm()
        {
            this.conexion = Realm.GetInstance();
        }

        public List<Personaje> GetPersonajes()
        {
            List<Personaje> personajes = this.conexion.All<Personaje>().ToList();
            return personajes;
        }

        public Personaje BuscarPersonaje(int id)
        {
            Personaje personaje = this.GetPersonajes().FirstOrDefault(x => x.IdPersonaje == id);
            return personaje;
        }

        public void InsertarPersonaje(int id, String nombre, String serie)
        {
            Personaje personaje = new Personaje();
            personaje.IdPersonaje = id;
            personaje.Nombre = nombre;
            personaje.Serie = serie;
            //PARA LAS CONSULTAS DE ACCION NECESITAMOS TRANSACCIONES
            Transaction tran = this.conexion.BeginWrite();
            this.conexion.Add(personaje);
            //GUARDAMOS CAMBIOS EN LA TRANSACCION
            tran.Commit();
        }

        public void ModificarPersonaje(int id, String nombre, String serie)
        {
            Personaje personaje = this.BuscarPersonaje(id);
            //INDICAMOS UNA NUEVA TRANSACCION
            using (Transaction tran = this.conexion.BeginWrite())
            {
                personaje.Nombre = nombre;
                personaje.Serie = serie;
                tran.Commit();
            }
        }

        public void EliminarPersonaje(int id)
        {
            Personaje personaje = this.BuscarPersonaje(id);
            using (Transaction tran = this.conexion.BeginWrite()) {
                this.conexion.Remove(personaje);
                tran.Commit();
            }

        }
    }
}
