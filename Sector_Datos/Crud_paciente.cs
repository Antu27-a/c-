using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data;
using System.Data.SqlClient;


namespace Sector_Datos
{
    public class Crud_paciente
    {
        ConexionBD conexion = new ConexionBD();


        SqlCommand cmd = new SqlCommand();
        public void Registrar_Paciente(string DNI, string nombre, string fecha_nac, string edad, string genero, string nacionalidad, string provincia, string partido, string localidad, string direccion, string correo, string telefono, string obra, string codigo)
        {

            cmd.Connection = conexion.Abrirconexion();

            cmd.CommandText = "registro_datos";

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@DNI", DNI);

            cmd.Parameters.AddWithValue("@nombre", nombre);

            cmd.Parameters.AddWithValue("@fecha", fecha_nac);
            cmd.Parameters.AddWithValue("@edad", edad);

            cmd.Parameters.AddWithValue("@genero", genero);
            cmd.Parameters.AddWithValue("@nacionalidad", nacionalidad);
            cmd.Parameters.AddWithValue("@provincia", provincia);
            cmd.Parameters.AddWithValue("@partido", partido);
            cmd.Parameters.AddWithValue("@localidad", localidad);
            cmd.Parameters.AddWithValue("@direccion", direccion);
            cmd.Parameters.AddWithValue("@correo", correo);
            cmd.Parameters.AddWithValue("@telefono", telefono);
            cmd.Parameters.AddWithValue("@obra", obra);
            cmd.Parameters.AddWithValue("@codigo", codigo);


            cmd.ExecuteNonQuery();

            cmd.Parameters.Clear();

            conexion.Cerrarconexion();
        }

        public void Modificar_Paciente(string DNI, string nombre, string fecha_nac, string edad, string genero, string nacionalidad, string provincia, string partido, string localidad, string direccion, string correo, string telefono, string obra, string codigo)
        {

            cmd.Connection = conexion.Abrirconexion();

            cmd.CommandText = "modificar_datos";

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@DNI", DNI);

            cmd.Parameters.AddWithValue("@nombre", nombre);

            cmd.Parameters.AddWithValue("@fecha", fecha_nac);
            cmd.Parameters.AddWithValue("@edad", edad);

            cmd.Parameters.AddWithValue("@genero", genero);
            cmd.Parameters.AddWithValue("@nacionalidad", nacionalidad);
            cmd.Parameters.AddWithValue("@provincia", provincia);
            cmd.Parameters.AddWithValue("@partido", partido);
            cmd.Parameters.AddWithValue("@localidad", localidad);
            cmd.Parameters.AddWithValue("@direccion", direccion);
            cmd.Parameters.AddWithValue("@correo", correo);
            cmd.Parameters.AddWithValue("@telefono", telefono);
            cmd.Parameters.AddWithValue("@obra", obra);
            cmd.Parameters.AddWithValue("@codigo", codigo);

            cmd.ExecuteNonQuery();

            cmd.Parameters.Clear();
            conexion.Cerrarconexion();
        }
    }
}
