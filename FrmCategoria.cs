using System;
using System.Windows.Forms;
using Sistema.Negocio;

namespace Sistema.Presentacion
{
    public partial class FrmCategoria : Form
    {
        private string NombreAnt;
        public FrmCategoria()
        {
            InitializeComponent();
        }

        private void Listar()
        { 
            try
            {
                //No estamos creando objetos xq el metodo listar de CN Categoria es estatico.
                DgvListado.DataSource = CN_Categoria.Listar();
                this.Formato();
                this.Limpiar();
                lbltotal.Text = "Total registros: " + Convert.ToString(DgvListado.Rows.Count);
            }
            catch (Exception ex)
            {
            MessageBox.Show(ex.Message+ex.StackTrace);//Explicación de la excepcion que ha ocurrido.
            }
        }

        private void Buscar()
        {
            try
            {
                //No estamos creando objetos xq el metodo buscar de CN Categoria es estatico.
                DgvListado.DataSource = CN_Categoria.Buscar(txtBuscar.Text);//Pasamos el parametro por la caja de texto como string
                this.Formato();
                lbltotal.Text = "Total registros: " + Convert.ToString(DgvListado.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);//Explicación de la excepcion que ha ocurrido.
            }
        }

        private void Formato()
        {
            DgvListado.Columns[0].Visible = false;
            DgvListado.Columns[1].Visible = false;
            DgvListado.Columns[2].Width = 150;
            DgvListado.Columns[3].Width = 400;
            DgvListado.Columns[3].HeaderText = "Descripción";
            DgvListado.Columns[4].Width = 100;
        }

        private void Limpiar() 
        {
            txtBuscar.Clear();
            txtId.Clear();
            txtNombre.Clear();  
            txtDescripcion.Clear();
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

        private void FrmCategoria_Load(object sender, EventArgs e)
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
                if (txtNombre.Text==String.Empty) 
                {
                   this.MensajeError("Falta ingresar algunos datos, serán remarcados.");
                    errorIcono.SetError(txtNombre, "Ingrese un nombre.");
                }
                else
                {
                    Rpta = CN_Categoria.Insertar(txtNombre.Text.Trim(),txtDescripcion.Text.Trim());
                    //Lo que guarda la capa de negocios estara en la variable respuesta
                    //La capa de negocios se comunica con la capa Datos

                    if (Rpta.Equals("OK"))
                    {
                        this.MensajeOk("Se inserto de forma correcta el registro.");
                        this.Listar(); 
                        TabGeneral.SelectedIndex = 0;
                    }
                    else
                    {
                        this.MensajeError(Rpta);
                        //No deja ingresar una categoria que ya existe.
                        //En la capa negocios hemos validado que no se repitan categorias.
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
                String Rpta = "";
                if (txtNombre.Text == String.Empty || txtId.Text == String.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos, serán remarcados.");
                    errorIcono.SetError(txtNombre, "Ingrese un nombre.");
                }
                else
                {
                    Rpta = CN_Categoria.Actualizar(Convert.ToInt32(txtId.Text),this.NombreAnt,txtNombre.Text.Trim(),txtDescripcion.Text.Trim());
                
                    if (Rpta.Equals("OK"))
                    {
                        this.MensajeOk("Se actualizo de forma correcta el registro.");
                        this.Limpiar();
                        this.Listar();
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

        private void DgvListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try 
            {
                this.Limpiar();
                btnActualizar.Visible = true;
                btnInsertar.Visible = false;
                txtId.Text = Convert.ToString(DgvListado.CurrentRow.Cells["ID"].Value);
                this.NombreAnt = Convert.ToString(DgvListado.CurrentRow.Cells["Nombre"].Value);
                txtNombre.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Nombre"].Value);
                txtDescripcion.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Descripcion"].Value);
                TabGeneral.SelectedIndex = 1; //Mantenimiento
            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione desde la celda nombre.");
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

        private void DgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DgvListado.Columns["Seleccionar"].Index) 
            { 
                //Si es seleccionada una celda de la columna seleccionar
                //Se crea un objeto de tipo DGVCheckBoxCell que va ser igual a la celda seleccionada
                DataGridViewCheckBoxCell chkEliminar = (DataGridViewCheckBoxCell)DgvListado.Rows[e.RowIndex].Cells["Seleccionar"];
                chkEliminar.Value = !Convert.ToBoolean(chkEliminar.Value);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try 
            {
                DialogResult Opcion;
                //El resultado de seleccionar ok or cancel se almacenara en la variable opcion
                Opcion = MessageBox.Show("Deseas eliminar el/los registro(s)?", "Sistema de ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if(Opcion == DialogResult.OK)
                {
                    int Codigo;
                    string Rpta = "";

                    //Puedo eliminar mas de 1 registro a la vez
                    //Voy a recorrer las filas de DGVListado
                    foreach(DataGridViewRow Row in DgvListado.Rows)
                    {
                        //Si esta seleccionado es que deseo eliminar ese registro
                        if (Convert.ToBoolean(Row.Cells[0].Value)) 
                        {
                            Codigo =Convert.ToInt32(Row.Cells[1].Value);//Columna 1 del ID y 2 del Nombre
                            Rpta = CN_Categoria.Eliminar(Codigo);//Llamo al metodo eliminar y le paso el parametro

                            if (Rpta.Equals("OK"))
                            {
                                this.MensajeOk("Se elimino de forma correcta el registro: "+Convert.ToString(Row.Cells[2].Value));
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
                MessageBox.Show(ex.Message+ex.StackTrace);
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
                            Codigo = Convert.ToInt32(Row.Cells[1].Value);//Columna 1 del ID y 2 del Nombre
                            Rpta = CN_Categoria.Activar(Codigo);//Llamo al metodo activar y le paso el parametro

                            if (Rpta.Equals("OK"))
                            {
                                this.MensajeOk("Se activo de forma correcta el registro: " + Convert.ToString(Row.Cells[2].Value));
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
                            Codigo = Convert.ToInt32(Row.Cells[1].Value);//Columna 1 del ID y 2 del Nombre
                            Rpta = CN_Categoria.Desactivar(Codigo);//Llamo al metodo desactivar y le paso el parametro

                            if (Rpta.Equals("OK"))
                            {
                                this.MensajeOk("Se desactivo de forma correcta el registro: " + Convert.ToString(Row.Cells[2].Value));
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

        private void btnReportes_Click(object sender, EventArgs e)
        {
            Reportes.FrmReporteCategorias Reporte = new Reportes.FrmReporteCategorias();    
            Reporte.ShowDialog();   
        }
    }
}