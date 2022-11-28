using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using Sistema.Negocio;
using System.IO;

namespace Sistema.Presentacion
{
    public partial class FrmArticulo : Form
    {
        private string RutaOrigen; 
        private string RutaDestino;
        private string Directorio = "C:\\Imagenes\\";//Donde voy almacenar las imagenes
        private string NombreAnt;
        public FrmArticulo()
        {
            InitializeComponent();
        }

        private void Listar()
        {
            try
            {
                //No estamos creando objetos xq el metodo listar de CN Articulo es estatico.
                DgvListado.DataSource = CN_Articulo.Listar();
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
                DgvListado.DataSource = CN_Articulo.Buscar(txtBuscar.Text);//Pasamos el parametro por la caja de texto como string
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
            DgvListado.Columns[0].Width = 100;//Seleccionar
            DgvListado.Columns[0].Visible = false;//Seleccionar
            DgvListado.Columns[1].Width = 50;//ID
            DgvListado.Columns[2].Visible = false;//IdCategoria
            DgvListado.Columns[3].Width = 100;//Nombre Categoria
            DgvListado.Columns[3].HeaderText = "Categoría";
            DgvListado.Columns[4].Width = 100;//Codigo
            DgvListado.Columns[4].HeaderText = "Codigo";
            DgvListado.Columns[5].Width = 150;//Nombre Articulo
            DgvListado.Columns[6].Width = 100;//Precio de Venta
            DgvListado.Columns[6].HeaderText = "Precio Venta";
            DgvListado.Columns[7].Width = 60;//Stock
            DgvListado.Columns[8].Width = 200;//Descripcion
            DgvListado.Columns[8].HeaderText = "Descripción";
            DgvListado.Columns[9].Width = 100;//Imagen
            DgvListado.Columns[10].Width = 100;//Estado
        }

        private void Limpiar()
        {
            txtBuscar.Clear();
            txtNombre.Clear();
            txtId.Clear();
            txtDescripcion.Clear();
            txtCodigo.Clear();
            txtPrecioVenta.Clear();
            txtStock.Clear();
            txtImagen.Clear();
            picImagen.Image = null;//No muestre ninguna imagen
            panelCodigo.BackgroundImage = null; //Dejarlo vacio
            btnGuardar.Enabled = true; //Deshabilitar
            btnInsertar.Visible = true;
            btnActualizar.Visible = false;
            errorIcono.Clear();
            this.RutaDestino = "";
            this.RutaOrigen = "";

            DgvListado.Columns[0].Visible = false;
            btnActivar.Visible = false;
            btnDesactivar.Visible = false;
            btnEliminar.Visible = false;
            chkSeleccionar.Checked = false;
        }

        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MensajeOk(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CargarCategoria()
        {
            try
            {
                cboCategoria.DataSource = CN_Categoria.Seleccionar();//Hacemos referencia al procedimiento seleccionado
                cboCategoria.ValueMember = "idcategoria";//Valor de los items
                cboCategoria.DisplayMember = "nombre";//Texto a mostrar de cada item
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void FrmArticulo_Load(object sender, EventArgs e)
        {
            this.Listar();
            this.CargarCategoria();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (file.ShowDialog() == DialogResult.OK) //Si he seleccionado un file de manera correcta 
            {
                picImagen.Image = Image.FromFile(file.FileName);//Imagen que he seleccionado en el picturebox
                txtImagen.Text = file.FileName.Substring(file.FileName.LastIndexOf("\\") + 1);//Obtiene el nombre de la imagen
                this.RutaOrigen = file.FileName;//Almacenar todo el directorio
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            BarcodeLib.Barcode Codigo = new BarcodeLib.Barcode();
            Codigo.IncludeLabel = true;
            panelCodigo.BackgroundImage = Codigo.Encode(BarcodeLib.TYPE.CODE128, txtCodigo.Text, Color.Black, Color.White, 400, 100);
            btnGuardar.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Image ImgFinal = (Image)panelCodigo.BackgroundImage.Clone();
            SaveFileDialog DialogGuardar = new SaveFileDialog();
            DialogGuardar.AddExtension = true;
            DialogGuardar.Filter = "Image PNG (*.png) | *.png";
            DialogGuardar.ShowDialog();
            if (!string.IsNullOrEmpty(DialogGuardar.FileName))
            {
                ImgFinal.Save(DialogGuardar.FileName, ImageFormat.Png);
            }
            ImgFinal.Dispose();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                String Rpta = "";
                //Validar que no esten vacias las cajas de texto
                if (cboCategoria.Text == String.Empty || txtNombre.Text == String.Empty || txtPrecioVenta.Text == String.Empty || txtStock.Text == String.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos, serán remarcados.");
                    //Muestra mensajes de validacion con errorprovider de los campos que estan vacios
                    errorIcono.SetError(cboCategoria, "Seleccione una categoria.");
                    errorIcono.SetError(txtNombre, "Ingrese un nombre.");
                    errorIcono.SetError(txtPrecioVenta, "Ingrese un precio de venta.");
                    errorIcono.SetError(txtStock, "Ingrese un stock inicial.");
                }
                else
                {
                    //Enviamos los parametros convertidos al metodo Insertar de la Clase Negocios.
                    Rpta = CN_Articulo.Insertar(Convert.ToInt32(cboCategoria.SelectedValue), txtCodigo.Text.Trim(), txtNombre.Text.Trim(), Convert.ToDecimal(txtPrecioVenta.Text), Convert.ToInt32(txtStock.Text), txtDescripcion.Text.Trim(), txtImagen.Text.Trim());

                    if (Rpta.Equals("OK"))//Si recibo un ok, es que inserte ese registro de manera correcta
                    {
                        this.MensajeOk("Se inserto de forma correcta el registro.");
                        //Si la imagen no esta vacia, significa que he seleccionado una imagen
                        if (txtImagen.Text != String.Empty)
                        {
                            this.RutaDestino = this.Directorio + txtImagen.Text;
                            File.Copy(this.RutaOrigen, this.RutaDestino);//Espera dos parametros:ruta origen y ruta destino
                        }
                        this.Listar();
                        TabGeneral.SelectedIndex = 0;
                    }
                    else
                    {
                        this.MensajeError(Rpta);
                        //No deja ingresar un articulo que ya existe.
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);//Explicación de la excepcion que ha ocurrido.
            }
        }
        
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                String Rpta = "";
                //Validar que no esten vacias las cajas de texto
                if (txtId.Text == string.Empty || cboCategoria.Text == String.Empty || txtNombre.Text == String.Empty || txtPrecioVenta.Text == String.Empty || txtStock.Text == String.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos, serán remarcados.");
                    errorIcono.SetError(cboCategoria, "Seleccione una categoria.");
                    errorIcono.SetError(txtNombre, "Ingrese un nombre.");
                    errorIcono.SetError(txtPrecioVenta, "Ingrese un precio de venta.");
                    errorIcono.SetError(txtStock, "Ingrese un stock inicial.");
                }
                else
                {
                    Rpta = CN_Articulo.Actualizar(Convert.ToInt32(txtId.Text), Convert.ToInt32(cboCategoria.SelectedValue), txtCodigo.Text.Trim(), this.NombreAnt, txtNombre.Text.Trim(), Convert.ToDecimal(txtPrecioVenta.Text), Convert.ToInt32(txtStock.Text), txtDescripcion.Text.Trim(), txtImagen.Text.Trim());

                    if (Rpta.Equals("OK"))
                    {
                        this.MensajeOk("Se actualizo de forma correcta el registro.");
                        //Si la imagen no esta vacia, significa que he seleccionado una imagen
                        if (txtImagen.Text != String.Empty && this.RutaOrigen != string.Empty)//Si selecciono una imagen significa que tengo una nueva ruta de origen
                        {
                            this.RutaDestino = this.Directorio + txtImagen.Text;
                            File.Copy(this.RutaOrigen, this.RutaDestino);//Espera dos parametros:ruta origen y ruta destino
                        }
                        this.Listar();
                        TabGeneral.SelectedIndex = 0;

                    }
                    else
                    {
                        this.MensajeError(Rpta);
                        //No deja ingresar un articulo que ya existe.
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
                    string Imagen = "";//Elimino el articulo de la base de datos y tambien la imagen del directorio

                    //Para recorrer todos los registros
                    foreach (DataGridViewRow Row in DgvListado.Rows)
                    {
                        //Si esta seleccionado es que deseo eliminar ese registro
                        if (Convert.ToBoolean(Row.Cells[0].Value))
                        {
                            Codigo = Convert.ToInt32(Row.Cells[1].Value);//Celda del ID 
                            Imagen = Convert.ToString(Row.Cells[9].Value);//Celda Imagen
                            Rpta = CN_Articulo.Eliminar(Codigo);//Llamo al metodo eliminar y le paso el parametro

                            if (Rpta.Equals("OK"))
                            {
                                this.MensajeOk("Se elimino el registro: " + Convert.ToString(Row.Cells[5].Value));//En la celda 5 esta el nombre
                                File.Delete(this.Directorio + Imagen);//Eliminar la imagen del directorio
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

        private void DgvListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Para actualizar y pasar del DGV a las cajas de texto
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
                MessageBox.Show("seleccione desde la celda nombre.");
            }
        }

        private void DgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Para eliminar un regsitro
            if (e.ColumnIndex == DgvListado.Columns["Seleccionar"].Index)
            {
                //Para marcar y desmarcar
                DataGridViewCheckBoxCell chkEliminar = (DataGridViewCheckBoxCell)DgvListado.Rows[e.RowIndex].Cells["Seleccionar"];
                chkEliminar.Value = !Convert.ToBoolean(chkEliminar.Value);
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
                            Codigo = Convert.ToInt32(Row.Cells[1].Value);//Celda 1 del ID
                            Rpta = CN_Articulo.Desactivar(Codigo);//Llamo al metodo desactivar y le paso el parametro

                            if (Rpta.Equals("OK"))
                            {
                                this.MensajeOk("Se desactivo de forma correcta el registro: " + Convert.ToString(Row.Cells[5].Value));//Celda 5 el nombre
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

                    //Puedo Activar mas de 1 registro a la vez
                    //Voy a recorrer las filas de DGVListado
                    foreach (DataGridViewRow Row in DgvListado.Rows)
                    {
                        if (Convert.ToBoolean(Row.Cells[0].Value))
                        {
                            Codigo = Convert.ToInt32(Row.Cells[1].Value);//Celda 1 del ID
                            Rpta = CN_Articulo.Activar(Codigo);//Llamo al metodo activar y le paso el parametro

                            if (Rpta.Equals("OK"))
                            {
                                this.MensajeOk("Se activo de forma correcta el registro: " + Convert.ToString(Row.Cells[5].Value));//Celda 5 el nombre
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
            Reportes.FrmReporteArticulos Reporte = new Reportes.FrmReporteArticulos();
            Reporte.ShowDialog();   
        }
    }    
}
