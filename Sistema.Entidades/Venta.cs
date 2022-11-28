using System;
using System.Data;


namespace Sistema.Entidades
{
    public class Venta
    {
        //Propiedades
        private int idventa;
        private int idcliente;
        private int idusuario;
        private string tipo_comprobante;
        private string serie_comprobante;
        private string num_comprobante;
        private DateTime fecha;
        private decimal impuesto;
        private decimal total;
        private string estado;
        private DataTable detalles;

        //Get and Set
        public int Idventa { get => idventa; set => idventa = value; }
        public int Idcliente { get => idcliente; set => idcliente = value; }
        public int Idusuario { get => idusuario; set => idusuario = value; }
        public string Tipo_comprobante { get => tipo_comprobante; set => tipo_comprobante = value; }
        public string Serie_comprobante { get => serie_comprobante; set => serie_comprobante = value; }
        public string Num_comprobante { get => num_comprobante; set => num_comprobante = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public decimal Impuesto { get => impuesto; set => impuesto = value; }
        public decimal Total { get => total; set => total = value; }
        public string Estado { get => estado; set => estado = value; }
        public DataTable Detalles { get => detalles; set => detalles = value; }
 
    }
}
