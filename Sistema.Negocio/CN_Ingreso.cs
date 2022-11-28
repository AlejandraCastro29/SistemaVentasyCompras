using Sistema.Datos;
using Sistema.Entidades;
using System.Data;
using System.Xml.Schema;

namespace Sistema.Negocio
{
    public class CN_Ingreso
    {
        public static DataTable Listar()
        {
            CD_Ingreso Datos = new CD_Ingreso();

            return Datos.Listar();
        }

        public static DataTable Buscar(string Valor)
        {
            CD_Ingreso Datos = new CD_Ingreso();

            return Datos.Buscar(Valor);
        }

        public static DataTable ListarDetalle(int Id)
        {
            CD_Ingreso Datos = new CD_Ingreso();

            return Datos.ListarDetalle(Id);
        }

        public static string Anular(int Id)
        {
            CD_Ingreso Datos = new CD_Ingreso();

            return Datos.Anular(Id);
        }

        public static string Insertar(int Idproveedor, int Idusuario, string Tipocomprobante, string Seriecomprobante, string Numcomprobante, decimal Impuesto, decimal Total, DataTable Detalles)
        {
            //Creo instancia a la capa Datos, para obtener un objeto.
            CD_Ingreso Datos = new CD_Ingreso();

            //Creo instancia a la clase Ingreso
            Ingreso Obj = new Ingreso();

            //Envio los valores que recibo como parametros
            Obj.Idproveedor = Idproveedor;
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
