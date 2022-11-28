using Sistema.Negocio;
using System;
using System.Data;
using System.Windows.Forms;

namespace Sistema.Presentacion
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable Tabla = new DataTable();
                Tabla = CN_Usuario.Login(txtEmail.Text,txtClave.Text);//Enviamos los dos parametros
                //Validar si el usuario es correcto al enviarle ese correo y clave 
                if (Tabla.Rows.Count <= 0) //Si mi objeto tabla tiene cero filas, al menos un registro valido.
                {
                    //Se envia el mensaje, el titulo del mensaje, button de OK e icono de error.
                    MessageBox.Show("El correo o la clave es incorrecta.","Acceso al Sistema",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else
                {
                    //Si tenemos al menos un registro, me evalue si el estado es true o false. Si es false no tiene acceso.
                    if (Convert.ToBoolean(Tabla.Rows[0][4]) == false)//Fila 0, columna 4 el estado
                    {
                        MessageBox.Show("Este usuario no esta activo.", "Acceso al Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        //Si el estado es true, tiene acceso.
                        FrmPrincipal Frm = new FrmPrincipal();
                        //Enviamos el Idusuario a las variables
                        Variables.IdUsuario= Convert.ToInt32(Tabla.Rows[0][0]);
                        Frm.Idusuario = Convert.ToInt32(Tabla.Rows[0][0]);//Fila 0, columna 0 id usuario
                        Frm.Idrol=Convert.ToInt32(Tabla.Rows[0][1]);//Fila 0, columna 1 id rol
                        Frm.Rol=Convert.ToString(Tabla.Rows[0][2]);//Fila 0, columna 2 Rol
                        Frm.Nombre=Convert.ToString(Tabla.Rows[0][3]); //Fila 0, columna 3 Nombre
                        Frm.Estado=Convert.ToBoolean((Tabla.Rows[0][4]));//Fila 0, columna 4 Estado
                        Frm.Show();//Mostrar el frm principal
                        this.Hide();//Que el frm login se oculte
                    }
                }
            }
            catch (Exception ex) 
            { 
                MessageBox.Show(ex.Message); 
            }
        }
    }
}
