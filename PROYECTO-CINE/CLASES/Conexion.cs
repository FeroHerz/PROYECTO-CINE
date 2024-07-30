using System;
using System.Data.SqlClient;
using System.Data;

namespace PROYECTO_CINE.CLASES
{
    public class Cconexion
    {
        public SqlConnection leer()
        {
            SqlConnection cn = new SqlConnection("Data Source=FERNIS-PC;Initial Catalog=CINE;Integrated Security=True;TrustServerCertificate=True");

            try
            {
                if (cn.State == ConnectionState.Closed)
                {
                    cn.Open();
                }
            }
            catch (Exception ex)
            {
                // Manejo de cualquier tipo de error
                Console.WriteLine("Error al abrir la conexión: " + ex.Message);
            }

            return cn;
        }
    }
}
