using Sistema.Negocio;
using System;
using System.Windows.Forms;

namespace Sistema.Presentacion
{
    public partial class FrmCliente : Form
    {
        private string NombreAnt;
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void Listar()
        {
            try
            {
                DgvListado.DataSource = CN_Persona.ListarClientes();
                this.Formato();
                this.Limpiar();
                lbltotal.Text = "Total registros: " + Convert.ToString(DgvListado.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Buscar()
        {
            try
            {
                DgvListado.DataSource = CN_Persona.BuscarClientes(txtBuscar.Text);//Pasamos el parametro por la caja de texto como string
                this.Formato();
                lbltotal.Text = "Total registros: " + Convert.ToString(DgvListado.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Formato()
        {
            DgvListado.Columns[0].Visible = false;//Seleccionar
            DgvListado.Columns[1].Width = 50; //ID Persona
            DgvListado.Columns[2].HeaderText = "Tipo Persona";
            DgvListado.Columns[2].Width = 100; //Tipo Persona
            DgvListado.Columns[3].Width = 170; //Nombre
            DgvListado.Columns[4].HeaderText = "Documento";
            DgvListado.Columns[4].Width = 100;//Tipo Documento
            DgvListado.Columns[5].HeaderText = "Numero Doc.";
            DgvListado.Columns[5].Width = 100;//Num Documento
            DgvListado.Columns[6].HeaderText = "Dirección";
            DgvListado.Columns[6].Width = 120;//Direccion
            DgvListado.Columns[7].Width = 100;//Telefono
            DgvListado.Columns[8].Width = 120;//Correo
            DgvListado.Columns[8].HeaderText = "Correo";

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
            btnInsertar.Visible = true; //Esta visible
            btnActualizar.Visible = false; //Esta oculto
            errorIcono.Clear();

            DgvListado.Columns[0].Visible = false;
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

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            this.Listar();
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
                //Validar que no esten vacia las caja de texto
                if (txtNombre.Text == String.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos, serán remarcados.");
                    //Muestra mensaje de validacion con errorprovider delcampo que esta vacio.
                    errorIcono.SetError(txtNombre, "Ingrese un nombre.");
                }
                else
                {
                    //Del combobox nos interesa el texto y no el numero seleccionado.
                    Rpta = CN_Persona.Insertar("Cliente",txtNombre.Text.Trim(), cboTipoDocumento.Text, txtNumDocumento.Text.Trim(),txtDireccion.Text.Trim(),txtTelefono.Text.Trim(),txtEmail.Text.Trim());

                    if (Rpta.Equals("OK"))//Si recibo un ok, es que inserte ese registro de manera correcta
                    {
                        this.MensajeOk("Se inserto de forma correcta el registro.");
                        this.Listar();
                        TabGeneral.SelectedIndex = 0;
                    }
                    else
                    {
                        this.MensajeError(Rpta); //No deja ingresar una persona que ya existe.
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                String Rpta = "";
                //Validar que no esten vacias las cajas de texto
                if (txtId.Text == string.Empty || txtNombre.Text == String.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos, serán remarcados.");
                    errorIcono.SetError(txtNombre, "Ingrese un nombre.");                  
                }
                else
                {
                    Rpta = CN_Persona.Actualizar(Convert.ToInt32(txtId.Text),"Cliente", this.NombreAnt, txtNombre.Text.Trim(), cboTipoDocumento.Text, txtNumDocumento.Text.Trim(), txtDireccion.Text.Trim(), txtTelefono.Text.Trim(), txtEmail.Text.Trim());

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
                txtId.Text = Convert.ToString(DgvListado.CurrentRow.Cells[1].Value);//ID              
                this.NombreAnt = Convert.ToString(DgvListado.CurrentRow.Cells[3].Value);//Nombre
                txtNombre.Text = Convert.ToString(DgvListado.CurrentRow.Cells[3].Value);//Nombre
                cboTipoDocumento.Text = Convert.ToString(DgvListado.CurrentRow.Cells[4].Value);//Tipo Documento
                txtNumDocumento.Text=Convert.ToString(DgvListado.CurrentRow.Cells[5].Value);
                txtDireccion.Text= Convert.ToString(DgvListado.CurrentRow.Cells[6].Value);
                txtTelefono.Text=Convert.ToString(DgvListado.CurrentRow.Cells[7].Value);
                txtEmail.Text= Convert.ToString(DgvListado.CurrentRow.Cells[8].Value);
                TabGeneral.SelectedIndex = 1; //Mantenimiento
            }
            catch (Exception)
            {
                MessageBox.Show("seleccione desde la celda nombre.");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
            TabGeneral.SelectedIndex = 0;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Deseas eliminar el/los registro(s)?", "Sistema de ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    int Codigo;
                    string Rpta = "";
                    
                    //Para recorrer todos los registros
                    foreach (DataGridViewRow Row in DgvListado.Rows)
                    {
                        //Si esta seleccionado es que deseo eliminar ese registro
                        if (Convert.ToBoolean(Row.Cells[0].Value))
                        {
                            Codigo = Convert.ToInt32(Row.Cells[1].Value);//Celda ID
                            Rpta = CN_Persona.Eliminar(Codigo);//Llamo al metodo eliminar y le paso el parametro

                            if (Rpta.Equals("OK"))
                            {
                                this.MensajeOk("Se elimino el registro: " + Convert.ToString(Row.Cells[3].Value));//En la celda 5 esta el nombre

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

        private void chkSeleccionar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSeleccionar.Checked)
            {
                DgvListado.Columns[0].Visible = true;//Seleccionar
                btnEliminar.Visible = true;
            }
            else
            {
                DgvListado.Columns[0].Visible = false;
                btnEliminar.Visible = false;
            }
        }

        private void DgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DgvListado.Columns["Seleccionar"].Index)
            {
                //Para marcar y desmarcar
                DataGridViewCheckBoxCell chkEliminar = (DataGridViewCheckBoxCell)DgvListado.Rows[e.RowIndex].Cells["Seleccionar"];
                chkEliminar.Value = !Convert.ToBoolean(chkEliminar.Value);
            }
        }
    }
}
