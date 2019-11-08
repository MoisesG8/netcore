using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using ApiTienda.Conexion;
using ApiTienda.Modelos;

namespace ApiTienda.Negocio
{
    public class Products_Business
    {
        public static ProductosModel GetProdCategories(string categoria)
        {
            string Query = "EXECUTE obtener_producto_categoria '" + categoria + "';";
            var ResulSet = Db_Connection.ReaderDatabase(Query);
            ProductosModel infProCateg = new ProductosModel();
            infProCateg.nombre_producto = ResulSet.Rows[0]["nombre_producto"].ToString();
            infProCateg.descripcion = ResulSet.Rows[0]["descripcion"].ToString();
            infProCateg.precio = float.Parse(ResulSet.Rows[0]["precio"].ToString());
            infProCateg.stock = int.Parse(ResulSet.Rows[0]["stock"].ToString());
            infProCateg.imagen = ResulSet.Rows[0]["imagen"].ToString();
            return infProCateg;
        }

        public static List<ProductosModel> Lproducts()
        {
           
            var C = Db_Connection.ConexionSQL();
            C.Open();
            var querito = new SqlCommand("execute allproducts;", C);
            SqlDataReader ResultSet = querito.ExecuteReader();
            List<ProductosModel> rproducts = new List<ProductosModel>();
            while(ResultSet.Read())
            {
                ProductosModel p = new ProductosModel();
                p.id_Producto = int.Parse(ResultSet["id_Producto"].ToString());
                p.id_categoria = int.Parse(ResultSet["id_categoria"].ToString());
                p.nombre_producto = ResultSet["nombre_producto"].ToString();
                p.descripcion = ResultSet["descripcion"].ToString();
                p.precio = float.Parse(ResultSet["precio"].ToString());
                p.stock = int.Parse(ResultSet["stock"].ToString());
                p.oferta = ResultSet["oferta"].ToString();
                p.imagen = ResultSet["imagen"].ToString();
                rproducts.Add(p);
            }
            C.Close();
            return rproducts;
          
        }
       
    }
}
