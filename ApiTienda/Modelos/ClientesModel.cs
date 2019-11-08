using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTienda.Modelos
{
    public class ClientesModel
    {
        public int id_cliente { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string email { get; set; }
        public string pass { get; set; }
        public string rol { get; set; }
    }
}
