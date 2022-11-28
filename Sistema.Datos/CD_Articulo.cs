using System;
using System.Data;
using System.Data.SqlClient;
using Sistema.Entidades;

namespace Sistema.Datos
{
    public class CD_Articulo
    {
        public DataTable Listar()
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            
            try
            {
                SqlCon = Conexion.getIsntancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("articuloListar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (System.Exception ex)
            {
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
                SqlCommand Comando = new SqlCommand("articuloBuscar", SqlCon);
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

        public DataTable BuscarVenta(string Valor)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getIsntancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("articuloBuscarVenta", SqlCon);
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

        public DataTable BuscarCodigo(string Valor)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getIsntancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("articuloBuscarCodigo", SqlCon);
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

        public DataTable BuscarCodigoVenta(string Valor)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getIsntancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("articuloBuscarCodigoVenta", SqlCon);
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

        public string Existe(string Valor)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getIsntancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("articuloExiste", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = Valor;
                SqlParameter ParExiste = new SqlParameter();
                ParExiste.ParameterName = "@existe";
                ParExiste.SqlDbType = SqlDbType.Int;
                ParExiste.Direction = ParameterDirection.Output;
                Comando.Parameters.Add(ParExiste);
                SqlCon.Open();
                Comando.ExecuteNonQuery();
                Rpta = Convert.ToString(ParExiste.Value);
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

        public string Insertar(Articulo OBj)
        {
            string Rpta = "";//Variable hay que iniciarla como cadena de string
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getIsntancia().CrearConexion();
                //Creamos la instancia y debemos enviarle los valores
                SqlCommand Comando = new SqlCommand("articuloInsertar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                //Enviamos los parametros que son objeto de la clase tipo articulo
                Comando.Parameters.Add("@idcategoria", SqlDbType.Int).Value = OBj.Idcategoria;
                Comando.Parameters.Add("@codigo", SqlDbType.VarChar).Value = OBj.Codigo;
                Comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = OBj.Nombre;
                Comando.Parameters.Add("@precio_venta", SqlDbType.Decimal).Value = OBj.Precio_venta;
                Comando.Parameters.Add("@stock", SqlDbType.Int).Value = OBj.Stock;
                Comando.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = OBj.Descripcion;
                Comando.Parameters.Add("@imagen", SqlDbType.VarChar).Value = OBj.Imagen;
                SqlCon.Open();
                //Si el resultado es satisfactoria devuelve un ok a la capa de negocio y si no se cumple manda un mensaje
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo ingresar el registro";
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

        public string Actualizar(Articulo OBj)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getIsntancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("articuloActualizar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@idarticulo ", SqlDbType.Int).Value = OBj.Idarticulo;
                Comando.Parameters.Add("@idcategoria", SqlDbType.Int).Value = OBj.Idcategoria;
                Comando.Parameters.Add("@codigo", SqlDbType.VarChar).Value = OBj.Codigo;
                Comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = OBj.Nombre;
                Comando.Parameters.Add("@precio_venta", SqlDbType.Decimal).Value = OBj.Precio_venta;
                Comando.Parameters.Add("@stock", SqlDbType.Int).Value = OBj.Stock;
                Comando.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = OBj.Descripcion;
                Comando.Parameters.Add("@imagen", SqlDbType.VarChar).Value = OBj.Imagen;           
                SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo actualizar el registro";
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

        public string Elimnar(int Id)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getIsntancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("articuloEliminar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@idarticulo", SqlDbType.Int).Value = Id;//Se envia parametro que se recibe en eliminar
                SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo eliminar el registro";
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

        public string Activar(int Id)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getIsntancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("articuloActivar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@idarticulo", SqlDbType.Int).Value = Id;
                SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo activar el registro";
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

        public string Desactivar(int Id)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getIsntancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("articuloDesactivar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@idarticulo", SqlDbType.Int).Value = Id;
                SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo desactivar el registro";
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
    }
}
