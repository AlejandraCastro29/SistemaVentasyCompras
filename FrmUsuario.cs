using System;
using System.Windows.Forms;
using Sistema.Negocio;

namespace Sistema.Presentacion
{
    public partial class FrmUsuario : Form
    {
        private string EmailAnt;
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void Listar()
        {
            try
            {
                DgvListado.DataSource = CN_Usuario.Listar();
                this.Formato();
                this.Limpiar();
                lbltotal.Text = "Total registros: " + Convert.ToString(DgvListado.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);//Explicación de la excepcion que ha ocurrido.
            }
        }

        private void Buscar()
        {
            try
            {
                DgvListado.DataSource = CN_Usuario.Buscar(txtBuscar.Text);//Pasamos el parametro por la caja de texto como string
                this.Formato();
                lbltotal.Text = "Total registros: " + Convert.ToString(DgvListado.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);//Explicación de la excepcion que ha ocurrido.
            }
        }

        private void CargarRol()
        {
            try
            {
                cboRol.DataSource = CN_Rol.Listar();//Hacemos referencia al procedimiento seleccionado
                cboRol.ValueMember = "idrol";//Valor de los items
                cboRol.DisplayMember = "nombre";//Texto a mostrar de cada item
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Formato()
        {
            DgvListado.Columns[0].Visible = false;
            DgvListado.Columns[1].Width = 50; //ID Usuario
            DgvListado.Columns[2].Visible = false; //Id Rol
            DgvListado.Columns[3].Width = 100; //Rol
            DgvListado.Columns[4].Width = 170; //Nombre
            DgvListado.Columns[5].HeaderText = "Documento";
            DgvListado.Columns[5].Width = 100;//Tipo Documento
            DgvListado.Columns[6].HeaderText = "Numero Doc.";
            DgvListado.Columns[6].Width = 100;//Num Documento
            DgvListado.Columns[7].HeaderText = "Dirección";
            DgvListado.Columns[7].Width = 120;//Direccion
            DgvListado.Columns[8].Width = 100;//Telefono
            DgvListado.Columns[9].Width = 120;//Corro
            DgvListado.Columns[9].HeaderText = "Correo";

        }

        private void Limpiar()
        {
            txtBuscar.Clear();
            txtId.Clear();
            txtNombre.Clear();
            txtNumDocumento.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            txtClave.Clear();
            btnInsertar.Visible = true; //Esta visible
            btnActualizar.Visible = false; //Esta oculto
            errorIcono.Clear();

            DgvListado.Columns[0].Visible = false;
            btnActivar.Visible = false;
            btnDesactivar.Visible = false;
            btnEliminar.Visible = false;
            chkSeleccionar.Checked = false; //Esta deselecionado en un principio
        }

        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MensajeOk(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            this.Listar();
            this.CargarRol();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                String Rpta = "";
                if (cboRol.Text == String.Empty || txtNombre.Text == String.Empty || txtEmail.Text == String.Empty || txtClave.Text == String.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos, serán remarcados.");
                    errorIcono.SetError(cboRol, "Ingrese un rol.");
                    errorIcono.SetError(txtNombre, "Ingrese un nombre.");
                    errorIcono.SetError(txtEmail, "Ingrese un correo.");
                    errorIcono.SetError(txtClave, "Ingrese una clave.");
                }
                else
                {   //Obtenemos el tipo de documento como.text osea el texto y no el valor seleccionado
                    Rpta = CN_Usuario.Insertar(Convert.ToInt32(cboRol.SelectedValue), txtNombre.Text.Trim(), cboTipoDocumento.Text.Trim(), txtNumDocumento.Text.Trim(), txtDireccion.Text.Trim(), txtTelefono.Text.Trim(), txtEmail.Text.Trim(), txtClave.Text.Trim());

                    if (Rpta.Equals("OK"))
                    {
                        this.MensajeOk("Se inserto de forma correcta el registro.");
                        this.Listar();
                        TabGeneral.SelectedIndex = 0;
                    }
                    else
                    {
                        this.MensajeError(Rpta);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);//Explicación de la excepcion que ha ocurrido.
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
            TabGeneral.SelectedIndex = 0;//Listado
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                String Rpta = ""; //Agregar que la caja de texto de Id no este vacia tambien
                if (txtId.Text == String.Empty || cboRol.Text == String.Empty || txtNombre.Text == String.Empty || txtEmail.Text == String.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos, serán remarcados.");
                    errorIcono.SetError(cboRol, "Ingrese un rol.");
                    errorIcono.SetError(txtNombre, "Ingrese un nombre.");
                    errorIcono.SetError(txtEmail, "Ingrese un correo.");
                    //No voy a validar la clave al momento de actualizar
                }
                else
                {   //Obtenemos el tipo de documento como.text osea el texto y no el valor seleccionado
                    Rpta = CN_Usuario.Actualizar(Convert.ToInt32(txtId.Text), Convert.ToInt32(cboRol.SelectedValue), txtNombre.Text.Trim(), cboTipoDocumento.Text.Trim(), txtNumDocumento.Text.Trim(), txtDireccion.Text.Trim(), txtTelefono.Text.Trim(), this.EmailAnt, txtEmail.Text.Trim(), txtClave.Text.Trim());

                    if (Rpta.Equals("OK"))
                    {
                        this.MensajeOk("Se actualizo de forma correcta el registro.");
                        this.Listar();
                        TabGeneral.SelectedIndex = 0;
                    }
                    else
                    {
                        this.MensajeError(Rpta);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void DgvListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.Limpiar();
                btnActualizar.Visible = true;
                btnInsertar.Visible = false;
                txtId.Text = Convert.ToString(DgvListado.CurrentRow.Cells[1].Value);//Idusuario
                cboRol.SelectedValue = Convert.ToString(DgvListado.CurrentRow.Cells[2].Value);//Idrol, con este ya seleccionamos el nombre del rol
                txtNombre.Text = Convert.ToString(DgvListado.CurrentRow.Cells[4].Value); //Nombre usuario
                cboTipoDocumento.Text = Convert.ToString(DgvListado.CurrentRow.Cells[5].Value);//Tipo documento
                txtNumDocumento.Text = Convert.ToString(DgvListado.CurrentRow.Cells[6].Value);//Num documento
                txtDireccion.Text = Convert.ToString(DgvListado.CurrentRow.Cells[7].Value); //Direccion
                txtTelefono.Text = Convert.ToString(DgvListado.CurrentRow.Cells[8].Value); //Telefono
                this.EmailAnt = Convert.ToString(DgvListado.CurrentRow.Cells[9].Value);//Email anterior
                txtEmail.Text = Convert.ToString(DgvListado.CurrentRow.Cells[9].Value);//Email nuevo

                TabGeneral.SelectedIndex = 1; //Mantenimiento
            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione desde la celda nombre.");
            }
        }

        private void DgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DgvListado.Columns["Seleccionar"].Index)
            {
                DataGridViewCheckBoxCell chkEliminar = (DataGridViewCheckBoxCell)DgvListado.Rows[e.RowIndex].Cells["Seleccionar"];
                chkEliminar.Value = !Convert.ToBoolean(chkEliminar.Value);
            }
        }

        private void chkSeleccionar_CheckedChanged(object sender, EventArgs e)
        {
            //Si esta marcado, la columna seleccionar y los botones estaran visibles
            if (chkSeleccionar.Checked)
            {
                DgvListado.Columns[0].Visible = true;
                btnActivar.Visible = true;
                btnDesactivar.Visible = true;
                btnEliminar.Visible = true;
            }
            else
            {
                DgvListado.Columns[0].Visible = false;
                btnActivar.Visible = false;
                btnDesactivar.Visible = false;
                btnEliminar.Visible = false;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                //El resultado de seleccionar ok or cancel se almacenara en la variable opcion
                Opcion = MessageBox.Show("Deseas eliminar el/los registro(s)?", "Sistema de ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    int Codigo;
                    string Rpta = "";

                    //Puedo eliminar mas de 1 registro a la vez
                    //Voy a recorrer las filas de DGVListado
                    foreach (DataGridViewRow Row in DgvListado.Rows)
                    {
                        //Si esta seleccionado es que deseo eliminar ese registro
                        if (Convert.ToBoolean(Row.Cells[0].Value))
                        {
                            Codigo = Convert.ToInt32(Row.Cells[1].Value);//Columna 1 del ID y 4 del Nombre
                            Rpta = CN_Usuario.Eliminar(Codigo);//Llamo al metodo eliminar y le paso el parametro valor

                            if (Rpta.Equals("OK"))
                            {
                                this.MensajeOk("Se elimino de forma correcta el registro: " + Convert.ToString(Row.Cells[4].Value));
                            }
                            else
                            {
                                this.MensajeError(Rpta);
                            }
                        }
                    }
                }
                this.Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnActivar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Deseas activar el/los registro(s)?", "Sistema de ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    int Codigo;
                    string Rpta = "";

                    //Puedo activar mas de 1 registro a la vez
                    //Voy a recorrer las filas de DGVListado
                    foreach (DataGridViewRow Row in DgvListado.Rows)
                    {
                        if (Convert.ToBoolean(Row.Cells[0].Value))
                        {
                            Codigo = Convert.ToInt32(Row.Cells[1].Value);//Columna 1 del ID y 4 del Nombre
                            Rpta = CN_Usuario.Activar(Codigo);//Llamo al metodo activar y le paso el parametro

                            if (Rpta.Equals("OK"))
                            {
                                this.MensajeOk("Se activo de forma correcta el registro: " + Convert.ToString(Row.Cells[4].Value));
                            }
                            else
                            {
                                this.MensajeError(Rpta);
                            }
                        }
                    }
                }
                this.Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnDesactivar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Deseas desactivar el/los registro(s)?", "Sistema de ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    int Codigo;
                    string Rpta = "";

                    //Puedo desactivar mas de 1 registro a la vez
                    //Voy a recorrer las filas de DGVListado
                    foreach (DataGridViewRow Row in DgvListado.Rows)
                    {
                        if (Convert.ToBoolean(Row.Cells[0].Value))
                        {
                            Codigo = Convert.ToInt32(Row.Cells[1].Value);//Columna 1 del ID y 4 del Nombre
                            Rpta = CN_Usuario.Desactivar(Codigo);//Llamo al metodo desactivar y le paso el parametro

                            if (Rpta.Equals("OK"))
                            {
                                this.MensajeOk("Se desactivo de forma correcta el registro: " + Convert.ToString(Row.Cells[4].Value));
                            }
                            else
                            {
                                this.MensajeError(Rpta);
                            }
                        }
                    }
                }
                this.Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
    }
 }

