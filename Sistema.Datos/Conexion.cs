using System;
using System.Data.SqlClient;

namespace Sistema.Datos
{
    public class Conexion
    {
        private string Base;
        private string Servidor;
        private string Usuario;
        private string Clave;
        private bool Seguridad;
        private static Conexion Con = null;

        //Contructor
        private Conexion()
        {
            //this.Base = "bdsistemaprod";
            //this.Servidor = "DESKTOP-NKKADC6\\SQL2022";
            //this.Usuario = "sa";
            //this.Clave = "";
            //this.Seguridad = true;
        }

        public SqlConnection CrearConexion() { 
        
            SqlConnection Cadena=new SqlConnection();
            try 
            {            
                 Cadena.ConnectionString = "Data Source=DESKTOP-NKKADC6\\SQL2022;Initial Catalog=bdsistemaprod;Integrated Security=True";
            }
            catch(Exception ex) 
            {
                Cadena = null; 
                throw ex;
            }
            return Cadena;
        }
       
        public static Conexion getIsntancia() {
            if (Con == null)
            {
                Con=new Conexion(); 
            }
            return Con;
        }
    }
}
