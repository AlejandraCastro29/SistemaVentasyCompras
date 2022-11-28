using Sistema.Datos;
using Sistema.Entidades;
using System;
using System.Data;
using System.Xml.Schema;

namespace Sistema.Negocio
{
    public class CN_Venta
    {
        public static DataTable Listar()
        {
            CD_Venta Datos = new CD_Venta();

            return Datos.Listar();
        }

        public static DataTable ListarDetalle(int Id)
        {
            CD_Venta Datos = new CD_Venta();

            return Datos.ListarDetalle(Id);
        }

        public static DataTable Buscar(string Valor)
        {
            CD_Venta Datos = new CD_Venta();

            return Datos.Buscar(Valor);
        }

        public static DataTable ConsultasFechas(DateTime FechaInicio,DateTime FechaFin)
        {
            CD_Venta Datos = new CD_Venta();

            return Datos.ConsultaFechas(FechaInicio,FechaFin);
        }

        public static string Anular(int Id)
        {
            CD_Venta Datos = new CD_Venta();

            return Datos.Anular(Id);
        }

        public static string Insertar(int Idcliente, int Idusuario, string Tipocomprobante, string Seriecomprobante, string Numcomprobante, decimal Impuesto, decimal Total, DataTable Detalles)
        {
            //Creo instancia a la capa Datos, para obtener un objeto.
            CD_Venta Datos = new CD_Venta();

            //Creo instancia a la clase Venta
            Venta Obj = new Venta();

            //Envio los valores que recibo como parametros
            Obj.Idcliente = Idcliente;
            Obj.Idusuario = Idusuario;
            Obj.Tipo_comprobante = Tipocomprobante;
            Obj.Serie_comprobante = Seriecomprobante;
            Obj.Num_comprobante = Numcomprobante;
            Obj.Impuesto = Impuesto;
            Obj.Total = Total;
            Obj.Detalles = Detalles;
            
            return Datos.Insertar(Obj);            
        }
    }
}
