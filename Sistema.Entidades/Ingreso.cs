using System;
using System.Data;


namespace Sistema.Entidades
{
    public class Ingreso
    {
        //Propiedades
        private int idingreso;
        private int idproveedor;
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
        public int Idingreso { get => idingreso; set => idingreso = value; }
        public int Idproveedor { get => idproveedor; set => idproveedor = value; }
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
