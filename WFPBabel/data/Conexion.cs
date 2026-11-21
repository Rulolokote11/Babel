using System;
using Microsoft.Data.SqlClient;

namespace BABEL.Data
{
    public class Conexion
    {
        private static readonly string cadenaConexion =
            @"Data Source=DESKTOP-5372L1L\SQLEXPRESS;
              Initial Catalog=BABEL;
              Integrated Security=True;
              Persist Security Info=False;
              Pooling=False;
              MultipleActiveResultSets=False;
              Encrypt=False;
              TrustServerCertificate=True;
              Application Name=BABEL;
              Connect Timeout=30;";

        public static SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadenaConexion);
        }
    }
}