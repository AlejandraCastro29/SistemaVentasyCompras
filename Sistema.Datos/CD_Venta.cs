using Sistema.Entidades;
using System;
using System.Data.SqlClient;
using System.Data;


namespace Sistema.Datos
{
    public class CD_Venta
    {
        public DataTable Listar()
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getIsntancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("ventaListar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }
          
        public DataTable ListarDetalle(int Id)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getIsntancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("ventaListarDetalle", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@idventa", SqlDbType.Int).Value = Id;
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                return null; //Para no enviar nada
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }

        public DataTable Buscar(string Valor)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getIsntancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("ventaBuscar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = Valor;
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }

        public DataTable ConsultaFechas(DateTime FechaInicio, DateTime FechaFin)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getIsntancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("ventaConsultaFechas", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@fecha_inicio", SqlDbType.Date).Value = FechaInicio;
                Comando.Parameters.Add("@fecha_fin", SqlDbType.Date).Value = FechaFin;
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }

        public string Anular(int Id)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getIsntancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("ventaAnular", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@idventa", SqlDbType.Int).Value = Id;
                SqlCon.Open();
                Comando.ExecuteNonQuery();
                Rpta = "OK";

            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }

        public string Insertar(Venta OBj)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getIsntancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("ventaInsertar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;

                //Enviamos parametros
                Comando.Parameters.Add("@idcliente", SqlDbType.Int).Value = OBj.Idcliente;
                Comando.Parameters.Add("@idusuario", SqlDbType.Int).Value = OBj.Idusuario;
                Comando.Parameters.Add("@tipocomprobante", SqlDbType.VarChar).Value = OBj.Tipo_comprobante;
                Comando.Parameters.Add("@seriecomprobante", SqlDbType.VarChar).Value = OBj.Serie_comprobante;
                Comando.Parameters.Add("@numcomprobante", SqlDbType.VarChar).Value = OBj.Num_comprobante;
                //No le mandamos la fecha porque la esta obteniendo de manera automatica gracias a la funcion getdate();
                Comando.Parameters.Add("@impuesto", SqlDbType.Decimal).Value = OBj.Impuesto;
                Comando.Parameters.Add("@total", SqlDbType.Decimal).Value = OBj.Total;
                //No le mandamos el estado porque por defecto lo ingresamos como string aceptado;
                Comando.Parameters.Add("@detalle", SqlDbType.Structured).Value = OBj.Detalles;//Enviamos los articulos que deseamos enviar a la compra
                SqlCon.Open();

                Comando.ExecuteNonQuery();
                //Esta insertando en la tabla ingreso como en detalle asi que borramos el
                //Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo ingresar el registro";
                //porque nunca obtendremos un 1, mandamos un simple OK
                Rpta = "OK";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;//Dejar mensaje de error
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }
    }
}
