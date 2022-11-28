using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Entidades
{
    public class Usuario
    {
        //Propiedades
        private int idusuario;
        private int idrol;
        private string nombre;
        private string tipo_documento;
        private string num_documento;
        private string direccion;
        private string telefono;
        private string email;
        private string clave;
        private bool estado;

        //Get and Set
        public int Idusuario { get => idusuario; set => idusuario = value; }
        public int Idrol { get => idrol; set => idrol = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Tipo_documento { get => tipo_documento; set => tipo_documento = value; }
        public string Num_documento { get => num_documento; set => num_documento = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Email { get => email; set => email = value; }
        public string Clave { get => clave; set => clave = value; }
        public bool Estado { get => estado; set => estado = value; }

    }
}
