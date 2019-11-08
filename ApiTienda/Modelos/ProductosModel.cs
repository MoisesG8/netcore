using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTienda.Modelos
{
    public class ProductosModel
    {
        public int id_Producto { get; set; }
        public int id_categoria { get; set; }
        public string nombre_producto { get; set; }
        public string descripcion { get; set; }
        public float precio { get; set; }
        public int stock { get; set; }
        public string oferta { get; set; }
        public string imagen { get; set; }
    }
}
