using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTienda.Modelos
{
    public class MasterPedidosModel
    {
        public int id_masterp { get; set; }
        public int id_pedido { get; set; }
        public int id_producto { get; set; }
        public int unidades { get; set; }
    }
}
