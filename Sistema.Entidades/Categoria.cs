

namespace Sistema.Entidades
{
    public class Categoria
    {
        //Propiedades
        private int idcategoria;
        private string nombre;
        private string descripcion;
        private bool estado;

        //Get and Set
        public int Idcategoria { get => idcategoria; set => idcategoria = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public bool Estado { get => estado; set => estado = value; }
    }
}
