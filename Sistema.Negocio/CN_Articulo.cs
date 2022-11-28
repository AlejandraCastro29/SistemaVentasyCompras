using System.Data;
using Sistema.Datos;
using Sistema.Entidades;

namespace Sistema.Negocio
{
    public class CN_Articulo
    {
        //Son estaticas a nivel de clase porque no voy a generar objetos de la clase
        //Simplemente hago referencia a la clase y al metodo especifico
        public static DataTable Listar()
        {
            CD_Articulo Datos = new CD_Articulo();

            return Datos.Listar();
        }

        public static DataTable Buscar(string Valor)
        {
            CD_Articulo Datos = new CD_Articulo();

            return Datos.Buscar(Valor);
        }

        public static DataTable BuscarVenta(string Valor)
        {
            CD_Articulo Datos = new CD_Articulo();

            return Datos.BuscarVenta(Valor);
        }

        public static DataTable BuscarCodigo(string Valor)
        {
            CD_Articulo Datos = new CD_Articulo();

            return Datos.BuscarCodigo(Valor);
        }

        public static DataTable BuscarCodigoVenta(string Valor)
        {
            CD_Articulo Datos = new CD_Articulo();

            return Datos.BuscarCodigoVenta(Valor);
        }

        public static string Insertar(int IdCategoria, string Codigo,string Nombre, decimal Precio_Venta, int Stock,string Descripcion, string Imagen)
        {
            CD_Articulo Datos = new CD_Articulo();

            string Existe = Datos.Existe(Nombre);
            if (Existe.Equals("1"))
            {
                return "El articulo ya existe.";
            }
            else
            {
                Articulo Obj = new Articulo();
                Obj.Idcategoria= IdCategoria;
                Obj.Codigo= Codigo;
                Obj.Nombre = Nombre;
                Obj.Precio_venta = Precio_Venta;
                Obj.Stock= Stock;
                Obj.Descripcion = Descripcion;
                Obj.Imagen= Imagen;
                return Datos.Insertar(Obj);
            }
        }

        public static string Actualizar(int Id, int IdCategoria, string Codigo, string NombreAnt, string Nombre, decimal Precio_Venta, int Stock, string Descripcion, string Imagen)
        {
            CD_Articulo Datos = new CD_Articulo();
            Articulo Obj = new Articulo();

            //Si es igual significa que el usuario no desea cambiar el articulo solo actualizar todo menos el nombre  
            if (NombreAnt.Equals(Nombre))
            {
                Obj.Idarticulo = Id;   
                Obj.Idcategoria = IdCategoria;
                Obj.Codigo = Codigo;
                Obj.Nombre = Nombre;
                Obj.Precio_venta = Precio_Venta;
                Obj.Stock = Stock;
                Obj.Descripcion = Descripcion;
                Obj.Imagen = Imagen;
                return Datos.Actualizar(Obj);
            }
            else
            {
                string Existe = Datos.Existe(Nombre);
                if (Existe.Equals("1"))
                {
                    return "El articulo ya existe";
                }
                else
                {
                    Obj.Idarticulo = Id;
                    Obj.Idcategoria = IdCategoria;
                    Obj.Codigo = Codigo;
                    Obj.Nombre = Nombre;
                    Obj.Precio_venta = Precio_Venta;
                    Obj.Stock = Stock;
                    Obj.Descripcion = Descripcion;
                    Obj.Imagen = Imagen;
                    return Datos.Actualizar(Obj);
                }
            }
        }

        public static string Eliminar(int Id)
        {
            CD_Articulo Datos = new CD_Articulo();

            return Datos.Elimnar(Id);
        }

        public static string Activar(int Id)
        {
            CD_Articulo Datos = new CD_Articulo();

            return Datos.Activar(Id);
        }

        public static string Desactivar(int Id)
        {
            CD_Articulo Datos = new CD_Articulo();

            return Datos.Desactivar(Id);
        }
    }
}
