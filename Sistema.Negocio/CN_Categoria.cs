using System;
using System.Data;
using Sistema.Datos;
using Sistema.Entidades;

namespace Sistema.Negocio
{
    public class CN_Categoria
    {
        //Son estaticas a nivel de clase porque no voy a generar objetos de la clase
        //Simplemente hago referencia a la clase y al metodo especifico
        public static DataTable Listar()
        {
            CD_Categoria Datos = new CD_Categoria();

            return Datos.Listar();
        }

        public static DataTable Seleccionar()
        {
            CD_Categoria Datos = new CD_Categoria();

            return Datos.Seleccionar();
        }

        public static DataTable Buscar(string Valor)
        {
            CD_Categoria Datos = new CD_Categoria();

            return Datos.Buscar(Valor);
        }

        public static string Insertar(string Nombre, string Descripcion)
        {
            CD_Categoria Datos = new CD_Categoria();

            string Existe = Datos.Existe(Nombre);
            if (Existe.Equals("1"))
            {
                return "La categoria ya existe.";
            }
            else 
            {
                Categoria Obj=new Categoria();
                Obj.Nombre= Nombre;
                Obj.Descripcion= Descripcion;
                return Datos.Insertar(Obj);
            }
        }

        //Estamos recibiendo de la capa presentacion el nombre anterior que es el nombre del registro que voy actualizar
        //y el nombre que el usuario ha escrito en la caja de texto, si es el mismo solo actualizo los datos y sino es igual
        // voy a revisar que ese nombre de categoria no lo tenga en la BD y por eso llama a la funcion existe de la capa datos
        public static string Actualizar(int Id, string NombreAnt,string Nombre, string Descripcion)
        {
            CD_Categoria Datos = new CD_Categoria();
            Categoria Obj = new Categoria();

            //Si es igual significa que el usuario no desea cambiar la categoria solo actualizar todo menos el nombre  
            if (NombreAnt.Equals(Nombre))
            {
                Obj.Idcategoria = Id;
                Obj.Nombre = Nombre;
                Obj.Descripcion = Descripcion;
                return Datos.Actualizar(Obj);
            }
            else 
            {
                string Existe = Datos.Existe(Nombre);
                if (Existe.Equals("1"))
                {
                    return "La categoria ya existe";
                }
                else
                {
                    Obj.Idcategoria = Id;
                    Obj.Nombre = Nombre;
                    Obj.Descripcion = Descripcion;
                    return Datos.Actualizar(Obj);
                }
            }       
        }

        public static string Eliminar(int Id)
        {
            CD_Categoria Datos = new CD_Categoria();

            return Datos.Elimnar(Id);
        }

        public static string Activar(int Id)
        {
            CD_Categoria Datos = new CD_Categoria();

            return Datos.Activar(Id);
        }

        public static string Desactivar(int Id)
        {
            CD_Categoria Datos = new CD_Categoria();

            return Datos.Desactivar(Id);
        }
    }
}
