using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;


namespace ApiTienda.Conexion
{
    public class Db_Connection
    {
        public static SqlConnection ConexionSQL()
        {
            SqlConnection ConnectionStrings = new SqlConnection(
                "Server=tcp:moisesazure.database.windows.net,1433;" +
                "Initial Catalog=BD_Tienda;" +
                "Persist Security Info=False;" +
                "User ID=moig8;" +
                "Password=test12345.;" +
                "MultipleActiveResultSets=False;" +
                "Encrypt=True;" +
                "TrustServerCertificate=False;" +
                "Connection Timeout=30;"
                );
            return ConnectionStrings;
        }
        public static DataTable ReaderDatabase(string Query)
        {
            var ResultSet = new DataTable();

            var Connect = ConexionSQL();
            Connect.Open();

            var QueryCommand = new SqlCommand(Query, Connect);

            var Adapter = new SqlDataAdapter(QueryCommand);
            //CREAMOS UN ADAPTADOR PARA LA CONSULTA

            Adapter.Fill(ResultSet);

            Connect.Close();

            return ResultSet;

        }
    }
}
