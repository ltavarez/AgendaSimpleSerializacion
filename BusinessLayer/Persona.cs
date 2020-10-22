using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{

    [Serializable]
    public class Persona
    {
        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Telefono { get; set; }
    }
}
