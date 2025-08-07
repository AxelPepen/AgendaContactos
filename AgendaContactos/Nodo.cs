using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaContactosWinForms
{
    public class Nodo
    {
        public Contact Contacto { get; set; }
        public Nodo Siguiente { get; set; }

        public Nodo(Contact contacto)
        {
            Contacto = contacto;
            Siguiente = null;
        }
    }
}
