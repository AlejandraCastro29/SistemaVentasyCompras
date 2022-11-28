
namespace Sistema.Entidades
{
    public class Persona
    {
        //Propiedades
        private int idpersona;
        private string tipo_persona;
        private string nombre;
        private string tipo_documento;
        private string num_documento;
        private string direccion;
        private string telefono;
        private string email;

        //Get and Set
        public int Idpersona { get => idpersona; set => idpersona = value; }
        public string Tipo_persona { get => tipo_persona; set => tipo_persona = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Tipo_documento { get => tipo_documento; set => tipo_documento = value; }
        public string Num_documento { get => num_documento; set => num_documento = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Email { get => email; set => email = value; }
    }
}
