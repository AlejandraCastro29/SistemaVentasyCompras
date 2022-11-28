using Sistema.Entidades;
using System;
using System.Data.SqlClient;
using System.Data;


namespace Sistema.Datos
{
    public class CD_Usuario
    {
        public DataTable Listar()
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();           
            try
            {
                SqlCon = Conexion.getIsntancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("usuarioListar", SqlCon);
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

        public DataTable Login(string Email, string Clave)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getIsntancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("usuarioLogin", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@email", SqlDbType.VarChar).Value = Email;
                Comando.Parameters.Add("@clave", SqlDbType.VarChar).Value = Clave;
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

        public DataTable Buscar(string Valor)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getIsntancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("usuarioBuscar", SqlCon);
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
                SqlCommand Comando = new SqlCommand("usuarioExiste", SqlCon);
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

        public string Insertar(Usuario OBj)
        {

            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getIsntancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("usuarioInsertar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@idrol", SqlDbType.Int).Value = OBj.Idrol;
                Comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = OBj.Nombre;
                Comando.Parameters.Add("@tipo_documento", SqlDbType.VarChar).Value = OBj.Tipo_documento;
                Comando.Parameters.Add("@num_documento", SqlDbType.VarChar).Value = OBj.Num_documento;
                Comando.Parameters.Add("@direccion", SqlDbType.VarChar).Value = OBj.Direccion;
                Comando.Parameters.Add("@telefono", SqlDbType.VarChar).Value = OBj.Telefono;
                Comando.Parameters.Add("@email", SqlDbType.VarChar).Value = OBj.Email;
                Comando.Parameters.Add("@clave", SqlDbType.VarChar).Value = OBj.Clave;
                SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo ingresar el registro";
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

        public string Actualizar(Usuario OBj)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getIsntancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("usuarioActualizar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@idusuario", SqlDbType.Int).Value = OBj.Idusuario;
                Comando.Parameters.Add("@idrol", SqlDbType.Int).Value = OBj.Idrol;
                Comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = OBj.Nombre;
                Comando.Parameters.Add("@tipo_documento", SqlDbType.VarChar).Value = OBj.Tipo_documento;
                Comando.Parameters.Add("@num_documento", SqlDbType.VarChar).Value = OBj.Num_documento;
                Comando.Parameters.Add("@direccion", SqlDbType.VarChar).Value = OBj.Direccion;
                Comando.Parameters.Add("@telefono", SqlDbType.VarChar).Value = OBj.Telefono;
                Comando.Parameters.Add("@email", SqlDbType.VarChar).Value = OBj.Email;
                Comando.Parameters.Add("@clave", SqlDbType.VarChar).Value = OBj.Clave;
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
                SqlCommand Comando = new SqlCommand("usuarioEliminar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@idusuario", SqlDbType.Int).Value = Id;//Se envia parametro que se recibe en eliminar
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
                SqlCommand Comando = new SqlCommand("usuarioActivar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@idusuario", SqlDbType.Int).Value = Id;
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
                SqlCommand Comando = new SqlCommand("usuarioDesactivar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@idusuario", SqlDbType.Int).Value = Id;
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
