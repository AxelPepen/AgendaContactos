using System.Collections.Generic;


namespace AgendaContactosWinForms
{
    public class ListaEnlazadaAgenda
    {
        private Nodo cabeza;

        public void Add(Contact contacto)
        {
            Nodo nuevo = new Nodo(contacto);
            if (cabeza == null)
            {
                cabeza = nuevo;
            }
            else
            {
                Nodo actual = cabeza;
                while (actual.Siguiente != null)
                {
                    actual = actual.Siguiente;
                }
                actual.Siguiente = nuevo;
            }
        }

        public bool Delete(string nombre)
        {
            if (cabeza == null) return false;

            if (cabeza.Contacto.Name == nombre)
            {
                cabeza = cabeza.Siguiente;
                return true;
            }

            Nodo actual = cabeza;
            while (actual.Siguiente != null)
            {
                if (actual.Siguiente.Contacto.Name == nombre)
                {
                    actual.Siguiente = actual.Siguiente.Siguiente;
                    return true;
                }
                actual = actual.Siguiente;
            }
            return false;
        }

        public List<Contact> GetAll()
        {
            List<Contact> lista = new List<Contact>();
            Nodo actual = cabeza;
            while (actual != null)
            {
                lista.Add(actual.Contacto);
                actual = actual.Siguiente;
            }
            return lista;
        }
    }
}

