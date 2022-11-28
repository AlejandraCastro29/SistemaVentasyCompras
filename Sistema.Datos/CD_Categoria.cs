using System;
using System.Data;
using System.Data.SqlClient;
using Sistema.Entidades;

namespace Sistema.Datos
{
    public class CD_Categoria
    {
        public DataTable Listar() 
        {
            SqlDataReader Resultado;//Leer una secuencia de filas de una BD sql
            DataTable Tabla=new DataTable();//Representa una tabla en memoria
            SqlConnection SqlCon = new SqlConnection();
            //Si se ejecuta de manera correcta el try luego el finally y sino se ejecuta el try y despues el catch y de ultimo finallly
            try 
            {
                SqlCon=Conexion.getIsntancia().CrearConexion();
                //Metodo getinstancia si existe una instancia me devulve una y sino me crea una nueva instancia a  la clase conexion
                SqlCommand Comando=new SqlCommand("categoriaListar",SqlCon);
                //Comando hace referencia a un objeto de la base de datos (Proc almacenado o intruccion transect sql)
                Comando.CommandType = CommandType.StoredProcedure;
                SqlCon.Open();//Abrir conexion
                Resultado=Comando.ExecuteReader();//El resultado del comando lo almaceno en la variable resultado
                Tabla.Load(Resultado);//Rellenamos el datatable obtenidos del resultado y retornar la tabla 
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

        public DataTable Seleccionar()
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            
            try
            {
                SqlCon = Conexion.getIsntancia().CrearConexion();                
                SqlCommand Comando = new SqlCommand("categoriaSeleccionar", SqlCon);                
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

        public DataTable Buscar(string Valor) 
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getIsntancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("categoriaBuscar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                //Agregamos un parametro con el nombre valor de tipo varchar
                // que le voy a enviar y estoy recibiendo como parametro string valor
                Comando.Parameters.Add("@valor",SqlDbType.VarChar).Value=Valor;  
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
                SqlCommand Comando = new SqlCommand("categoriaExiste", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = Valor;
                SqlParameter ParExiste= new SqlParameter();
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
                Rpta = ex.Message;//Dejar mensaje de error
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }

        public string Insertar(Categoria OBj) {
           
            string Rpta = "";//Variable hay que iniciarla como cadena de string
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getIsntancia().CrearConexion();
                //Creamos la instancia y debemos enviarle dos valores
                SqlCommand Comando = new SqlCommand("categoriaInsertar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                //Enviamos dos parametros que son objeto de la clase tipo categoria
                Comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = OBj.Nombre;
                Comando.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = OBj.Descripcion;
                SqlCon.Open();
                //Si el resultado es satisfactoria devuelve un ok a la capa de negocio y si no se cumple manda un mensaje
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo ingresar el registro";
            }
            catch(Exception ex)
            {
                Rpta=ex.Message;//Dejar mensaje de error
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }

        public string Actualizar(Categoria OBj) 
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getIsntancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("categoriaActualizar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@idcategoria", SqlDbType.Int).Value = OBj.Idcategoria;
                Comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = OBj.Nombre;
                Comando.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = OBj.Descripcion;
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
                SqlCommand Comando = new SqlCommand("categoriaEliminar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@idcategoria", SqlDbType.Int).Value = Id;//Se envia parametro que se recibe en eliminar
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
                SqlCommand Comando = new SqlCommand("categoriaActivar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@idcategoria", SqlDbType.Int).Value = Id;
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
                SqlCommand Comando = new SqlCommand("categoriaDesactivar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@idcategoria", SqlDbType.Int).Value = Id;
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
