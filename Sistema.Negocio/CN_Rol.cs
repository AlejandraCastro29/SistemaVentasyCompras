using Sistema.Datos;
using System.Data;

namespace Sistema.Negocio
{
    public class CN_Rol
    {
        public static DataTable Listar()
        {
            CD_Rol Datos = new CD_Rol();

            return Datos.Listar();
        }
    }
}
