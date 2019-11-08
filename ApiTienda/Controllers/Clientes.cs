using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ApiTienda.Modelos;
using ApiTienda.Negocio;
using Newtonsoft.Json;

namespace ApiTienda.Controllers
{
   
    [Route("api/[controller]")]
    [ApiController]
    public class Clientes : Controller
    {
        
        //metodo para login
        [HttpGet("ClientLogin")]
        public JsonResult LoginClient(string email, string pass)
        {
            ClientesModel InfClientesLgn = new ClientesModel();
            InfClientesLgn = Clientes_Business.LoginClientes(email, pass);
            return Json(InfClientesLgn);
        }
        //metodo para registrar un nuevo cliente
        [HttpPost("Registrar")]
        public JsonResult RegistrarCliente(ClientesModel regisCliente)
        {
            Clientes_Business.Registrar(regisCliente);
            return Json(regisCliente);
        }

    }
}