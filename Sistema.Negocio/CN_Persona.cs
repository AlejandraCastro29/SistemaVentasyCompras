using Sistema.Datos;
using Sistema.Entidades;
using System.Data;

namespace Sistema.Negocio
{
    public class CN_Persona
    {
        public static DataTable Listar()
        {
            CD_Persona Datos = new CD_Persona();

            return Datos.Listar();
        }

        public static DataTable ListarProveedores()
        {
            CD_Persona Datos = new CD_Persona();

            return Datos.ListarProveedores();
        }

        public static DataTable ListarClientes()
        {
            CD_Persona Datos = new CD_Persona();

            return Datos.ListarClientes();
        }

        public static DataTable Buscar(string Valor)
        {
            CD_Persona Datos = new CD_Persona();

            return Datos.Buscar(Valor);
        }

        public static DataTable BuscarProveedores(string Valor)
        {
            CD_Persona Datos = new CD_Persona();

            return Datos.BuscarProveedores(Valor);
        }

        public static DataTable BuscarClientes(string Valor)
        {
            CD_Persona Datos = new CD_Persona();

            return Datos.BuscarClientes(Valor);
        }

        public static string Insertar(string Tipo_persona, string Nombre, string Tipo_documento, string Num_documento, string Direccion, string Telefono, string Email)
        {
            CD_Persona Datos = new CD_Persona();

            string Existe = Datos.Existe(Nombre);//Verificamos si existe o no la persona por el nombre
            if (Existe.Equals("1"))
            {
                return "La persona ya existe.";
            }
            else
            {
                //Devuelve un cero, es decir que no existe la persona y puedo crearla.         
                Persona Obj = new Persona();//Instanciar a la clase persona
                Obj.Tipo_persona = Tipo_persona;
                Obj.Nombre = Nombre;
                Obj.Tipo_documento = Tipo_documento;
                Obj.Num_documento = Num_documento;
                Obj.Direccion = Direccion;
                Obj.Telefono = Telefono;
                Obj.Email = Email;
                return Datos.Insertar(Obj);
            }
        }
        
        public static string Actualizar(int Idpersona, string Tipo_persona, string NombreAnt, string Nombre, string Tipo_documento, string Num_documento, string Direccion, string Telefono, string Email)
        {
            CD_Persona Datos = new CD_Persona();
            Persona Obj = new Persona();

            //Si es igual significa que la persona ya existe y solo deseo actualizar. 
            if (NombreAnt.Equals(Nombre))
            {
                Obj.Idpersona = Idpersona;
                Obj.Tipo_persona = Tipo_persona;
                Obj.Nombre = Nombre;
                Obj.Tipo_documento = Tipo_documento;
                Obj.Num_documento = Num_documento;
                Obj.Direccion = Direccion;
                Obj.Telefono = Telefono;
                Obj.Email = Email;
                return Datos.Actualizar(Obj);
            }
            else
            {
                string Existe = Datos.Existe(Nombre);
                if (Existe.Equals("1"))
                {
                    return "La persona con ese nombre ya existe.";
                }
                else
                {
                    //Sino existe esa persona, la creamos entonces.
                    Obj.Idpersona = Idpersona;
                    Obj.Tipo_persona = Tipo_persona;
                    Obj.Nombre = Nombre;
                    Obj.Tipo_documento = Tipo_documento;
                    Obj.Num_documento = Num_documento;
                    Obj.Direccion = Direccion;
                    Obj.Telefono = Telefono;
                    Obj.Email = Email;
                    return Datos.Actualizar(Obj);
                }
            }
        }
        
        public static string Eliminar(int Id)
        {
            CD_Persona Datos = new CD_Persona();

            return Datos.Elimnar(Id);
        }

    }
}
