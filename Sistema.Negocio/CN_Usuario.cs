using Sistema.Datos;
using Sistema.Entidades;
using System.Data;

namespace Sistema.Negocio
{
    public class CN_Usuario
    {
        public static DataTable Listar()
        {
            CD_Usuario Datos = new CD_Usuario();

            return Datos.Listar();
        }

        public static DataTable Login(string Email, string Clave)
        {
            CD_Usuario Datos = new CD_Usuario();

            return Datos.Login(Email,Clave);
        }

        public static DataTable Buscar(string Valor)
        {
            CD_Usuario Datos = new CD_Usuario();

            return Datos.Buscar(Valor);
        }

        public static string Insertar(int Idrol, string Nombre, string Tipo_documento, string Num_documento, string Direccion, string Telefono, string Email, string Clave)
        {
            CD_Usuario Datos = new CD_Usuario();

            string Existe = Datos.Existe(Email);//Verificamos si existe o no el usuario por el email
            if (Existe.Equals("1"))
            {
                return "El usuario con ese email ya existe.";
            }
            else
            {
                //Devuelve un cero, es decir que no existe el usuario y puedo crearlo                
                Usuario Obj = new Usuario();               
                Obj.Idrol = Idrol;
                Obj.Nombre = Nombre;
                Obj.Tipo_documento = Tipo_documento;
                Obj.Num_documento = Num_documento;
                Obj.Direccion = Direccion;
                Obj.Telefono = Telefono;
                Obj.Email = Email;
                Obj.Clave = Clave;
                return Datos.Insertar(Obj);
            }
        }
        public static string Actualizar(int Idusuario,int Idrol, string Nombre, string Tipo_documento, string Num_documento, string Direccion, string Telefono, string EmailAnt, string Email, string Clave)
        {
            CD_Usuario Datos = new CD_Usuario();
            Usuario Obj = new Usuario();

            //Si es igual significa que el usuario no desea cambiar modificar su email, solo actualizar los demas datos
            if (EmailAnt.Equals(Email))
            {
                Obj.Idusuario = Idusuario;
                Obj.Idrol = Idrol;
                Obj.Nombre = Nombre;
                Obj.Tipo_documento = Tipo_documento;
                Obj.Num_documento = Num_documento;
                Obj.Direccion = Direccion;
                Obj.Telefono = Telefono;
                Obj.Email = Email;
                Obj.Clave = Clave;
                return Datos.Actualizar(Obj);
            }
            else
            {
                string Existe = Datos.Existe(Email);
                if (Existe.Equals("1"))
                {
                    return "El usuario con ese email ya existe";
                }
                else
                {
                    //Sino existe ese usuario, lo creamos entonces.
                    Obj.Idusuario= Idusuario;
                    Obj.Idrol = Idrol;
                    Obj.Nombre = Nombre;
                    Obj.Tipo_documento = Tipo_documento;
                    Obj.Num_documento = Num_documento;
                    Obj.Direccion = Direccion;
                    Obj.Telefono = Telefono;
                    Obj.Email = Email;
                    Obj.Clave = Clave;
                    return Datos.Actualizar(Obj);
                }
            }
        }
        public static string Eliminar(int Id)
        {
            CD_Usuario Datos = new CD_Usuario();

            return Datos.Elimnar(Id);
        }

        public static string Activar(int Id)
        {
            CD_Usuario Datos = new CD_Usuario();

            return Datos.Activar(Id);
        }
        public static string Desactivar(int Id)
        {
            CD_Usuario Datos = new CD_Usuario();

            return Datos.Desactivar(Id);
        }
   
    }
}
