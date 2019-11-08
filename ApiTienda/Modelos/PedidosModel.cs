using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTienda.Modelos
{
    public class PedidosModel
    {
        public int id_pedido { get; set; }
        public int id_cliente { get; set; }
        public string departamento { get; set; }
        public string municipio { get; set; }
        public float importeTotal { get; set; }
        public string estado { get; set; }
        public DateTime fecha { get; set; }
    }
}
