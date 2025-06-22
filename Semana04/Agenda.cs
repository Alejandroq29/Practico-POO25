

using System;
using System.Collections.Generic;

namespace AgendaTelefonica
{
    
    public class Agenda
    {
        private List<Contacto> contactos;

        public Agenda()
        {
            contactos = new List<Contacto>();
        }

        public void AgregarContacto(Contacto contacto)
        {
            contactos.Add(contacto);
        }

        public Contacto BuscarContacto(string nombre)
        {
            return contactos.Find(c => c.Nombre == nombre);
        }

        public bool EliminarContacto(string nombre)
        {
            Contacto contacto = BuscarContacto(nombre);
            if (contacto != null)
            {
                contactos.Remove(contacto);
                return true;
            }
            return false;
        }

        public void MostrarContactos()
        {
            foreach (var contacto in contactos)
            {
                Console.WriteLine(contacto);
            }
        }
    }
}
