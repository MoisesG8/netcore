using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiTienda.Modelos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ApiTienda.Negocio;

namespace ApiTienda.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Productos : Controller
    {
        [HttpGet("ProductsCateg")]
        public JsonResult getProdCat(string categoria)
        {
            ProductosModel InfProdcat = new ProductosModel();
            InfProdcat = Products_Business.GetProdCategories(categoria);
            return Json(InfProdcat);
        }
        [HttpGet("allproducts")]
        public JsonResult AllProductos()
        {
            List<ProductosModel> p = new List<ProductosModel>();
            p = Products_Business.Lproducts();
            return Json(p);
        }

    }
}