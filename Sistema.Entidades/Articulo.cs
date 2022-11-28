

namespace Sistema.Entidades
{
    public class Articulo
    {
        //Propiedades
        private int idarticulo;
        private int idcategoria;
        private string codigo;
        private string nombre;
        private decimal precio_venta;
        private int stock;
        private string descripcion;
        private string imagen;
        private bool estado;

        //Get and Set
        public int Idarticulo { get => idarticulo; set => idarticulo = value; }
        public int Idcategoria { get => idcategoria; set => idcategoria = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public decimal Precio_venta { get => precio_venta; set => precio_venta = value; }
        public int Stock { get => stock; set => stock = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Imagen { get => imagen; set => imagen = value; }
        public bool Estado { get => estado; set => estado = value; }
    }

}
