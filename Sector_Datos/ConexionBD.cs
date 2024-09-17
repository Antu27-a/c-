using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Sector_Datos
{
    public class ConexionBD
    {
        
        public SqlConnection Ruta = new SqlConnection("Data Source=ANTU\\SQLEXPRESS;Initial Catalog=hospital;Integrated Security=True;Encrypt=False");

        
        public SqlConnection Abrirconexion()
        {
            if (Ruta.State == ConnectionState.Closed)
                Ruta.Open();
            return Ruta;
        }
        
        public SqlConnection Cerrarconexion()
        {
            if (Ruta.State == ConnectionState.Open)
                Ruta.Close();
            return Ruta;
        }
    }
}
