using ApiTienda.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiTienda.Conexion;

namespace ApiTienda.Negocio
{
    public class Clientes_Business
    {
        //metodo para los registros de usuarios logueados
        public static ClientesModel LoginClientes(string email, string pass)
        {
            string Query = "EXECUTE login_clientes '" + email + "','" + pass + "';";
            var ResultSet = Db_Connection.ReaderDatabase(Query);

            ClientesModel InfClientesLgn = new ClientesModel();
            InfClientesLgn.nombre = ResultSet.Rows[0]["nombre"].ToString();
            InfClientesLgn.email = ResultSet.Rows[0]["email"].ToString();
            InfClientesLgn.pass = ResultSet.Rows[0]["pass"].ToString();
           

            return InfClientesLgn;
        }
        //le mandamos un objeto de tipo clientesmodel como parametro
        public static bool Registrar(ClientesModel c)
        {
            try
            {
                //ejecutamos el storeprocedure y le concatenamos los atributos del objeto clientes model
                string Query = "EXECUTE registro_clientes '" + c.nombre + "','" + c.apellidos + "','" + c.email + "','" + c.pass + "';";
                var ResultSet = Db_Connection.ReaderDatabase(Query);
            }
            catch(Exception e)
            {
                e.Message.ToString();
            }
            return true;
        }

    }
}
