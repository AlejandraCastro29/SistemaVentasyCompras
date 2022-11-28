using Sistema.Negocio;
using System;
using System.Data;
using System.Windows.Forms;

namespace Sistema.Presentacion
{
    public partial class FrmVenta : Form
    {
        //Declaramos un datatable dtDetalle para CrearTabla

        private DataTable DtDetalle = new DataTable();
        public FrmVenta()
        {
            InitializeComponent();
        }

        private void Listar()
        {
            try
            {
                DgvListado.DataSource = CN_Venta.Listar();
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
                DgvListado.DataSource = CN_Venta.Buscar(txtBuscar.Text);
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
            DgvListado.Columns[1].Visible = false;//ID
            DgvListado.Columns[2].Visible = false;//ID Usuario
            DgvListado.Columns[3].Width = 150;//Usuario
            DgvListado.Columns[4].Width = 150;//Cliente
            DgvListado.Columns[5].HeaderText = "Comprobante";
            DgvListado.Columns[5].Width = 100;
            DgvListado.Columns[6].HeaderText = "Serie";
            DgvListado.Columns[6].Width = 70;
            DgvListado.Columns[7].HeaderText = "Número";
            DgvListado.Columns[7].Width = 70;
            DgvListado.Columns[8].HeaderText = "Fecha";
            DgvListado.Columns[8].Width = 70;
            DgvListado.Columns[9].HeaderText = "Impuesto";
            DgvListado.Columns[9].Width = 100;
            DgvListado.Columns[10].HeaderText = "Total";
            DgvListado.Columns[10].Width = 100;
            DgvListado.Columns[11].Width = 100;//Estado
        }

        private void Limpiar()
        {
            txtBuscar.Clear();
            txtId.Clear();
            txtCodigoArticulo.Clear();
            txtIdCliente.Clear();
            txtCliente.Clear();
            txtSerie.Clear();
            txtNumero.Clear();
            DtDetalle.Clear();
            txtSubtotal.Text = "0.00";
            txtTotalIVA.Text = "0.00";
            txtTotal.Text = "0.00";
            btnInsertar.Visible = true; //Esta visible
            errorIcono.Clear();

            DgvListado.Columns[0].Visible = false;
            btnAnular.Visible = false;
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

        private void CrearTabla()
        {
            //Agregamos columnas al datatable DtDetalle
            //Me espera dos paramentros: el nombre de la columna y el tipo de datos de la columna

            this.DtDetalle.Columns.Add("idarticulo", System.Type.GetType("System.Int32"));
            this.DtDetalle.Columns.Add("codigo", System.Type.GetType("System.String"));
            this.DtDetalle.Columns.Add("articulo", System.Type.GetType("System.String"));
            this.DtDetalle.Columns.Add("stock", System.Type.GetType("System.Int32"));
            this.DtDetalle.Columns.Add("cantidad", System.Type.GetType("System.Int32"));
            this.DtDetalle.Columns.Add("precio", System.Type.GetType("System.Decimal"));
            this.DtDetalle.Columns.Add("descuento", System.Type.GetType("System.Decimal"));
            this.DtDetalle.Columns.Add("importe", System.Type.GetType("System.Decimal"));


            //Mi dgvdetalle sea igual al datatable detalle

            DGVDetalle.DataSource = this.DtDetalle;

            DGVDetalle.Columns[0].Visible = false;
            DGVDetalle.Columns[1].HeaderText = "Codigo";
            DGVDetalle.Columns[1].Width = 100;
            DGVDetalle.Columns[2].HeaderText = "Artículo";
            DGVDetalle.Columns[2].Width = 200;
            DGVDetalle.Columns[3].HeaderText = "Stock";
            DGVDetalle.Columns[3].Width = 50;
            DGVDetalle.Columns[4].HeaderText = "Cantidad";
            DGVDetalle.Columns[4].Width = 50;
            DGVDetalle.Columns[5].HeaderText = "Precio";
            DGVDetalle.Columns[5].Width = 70;
            DGVDetalle.Columns[6].HeaderText = "Descuento";
            DGVDetalle.Columns[6].Width = 60;
            DGVDetalle.Columns[7].HeaderText = "Importe";
            DGVDetalle.Columns[7].Width = 80;

            //Columna solo lectura
            DGVDetalle.Columns[1].ReadOnly = true;//Codigo
            DGVDetalle.Columns[2].ReadOnly = true;//Articulo
            DGVDetalle.Columns[3].ReadOnly = true;//Stock
            DGVDetalle.Columns[7].ReadOnly = true;//Importe
        }

        private void FrmVenta_Load(object sender, EventArgs e)
        {
            this.Listar();
            this.CrearTabla();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            //Crear un objeto  de Frmvista, usar show dialog para cuando el FrmVista se cierre, pase el valor a las cajas de texto
            FrmVista_ClienteVenta vista =new FrmVista_ClienteVenta();
            vista.ShowDialog();//No puede regresar al formulario anterior sino selecciono un cliete o cierro el formulario.
            txtIdCliente.Text=Convert.ToString(Variables.IdCliente);    
            txtCliente.Text=Variables.NombreCliente;
        }

        private void txtCodigoArticulo_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                //Si se da clic en la tecla enter, voy hacer la consulta a la capa negocios,
                //enviandole lo que tengo en esta caja de texto.
                if (e.KeyCode == Keys.Enter)
                {
                    //El datatable tabla se llena con lo que obtengo en buscarcodigo
                    DataTable Tabla = new DataTable();
                    Tabla = CN_Articulo.BuscarCodigoVenta(txtCodigoArticulo.Text.Trim());
                    //Si el datatable tiene cero filas, quiere decir que no existe.
                    if (Tabla.Rows.Count <= 0)
                    {
                        this.MensajeError("No existe artículo con ese código de barras o no hay stock.");
                    }
                    else
                    {
                        //LLamammos al metodo Agregardetalle y le enviamos los parametros
                        this.AgregarDetalle(Convert.ToInt32(Tabla.Rows[0][0]), Convert.ToString(Tabla.Rows[0][1]), Convert.ToString(Tabla.Rows[0][2]), Convert.ToInt32(Tabla.Rows[0][4]), Convert.ToDecimal(Tabla.Rows[0][3]));
                        //En el indice 0 columna 0 esta el ID, 0 columna 1 codigo, 0 columna 2 nombre, indice 0 columna 4 stock y en el indice 0 columna 3 precio. Es el orden en que aparecen el el proc almacenado.
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AgregarDetalle(int IdArticulo, string Codigo, string Nombre, int Stock, decimal Precio)
        {
            //Indica que si permite agregar articulos al Detalle
            bool Agregar = true;

            //Voy a recorrer cada fila del detalle y verificar si existe o no el articulo
            foreach (DataRow FilaTemp in DtDetalle.Rows)
            {
                //Si mi fila temp con la columna idarticulo son iguales, no permito que se agregue.
                if (Convert.ToInt32(FilaTemp["idarticulo"]) == IdArticulo)
                {
                    Agregar = false;
                    this.MensajeError("El artículo ya ha sido agregado.");
                }
            }
            // Si el articulo que deseamos agregar no se encuentra en el dt Detalle, entonces lo agregamos.
            if (Agregar)
            {
                DataRow Fila = DtDetalle.NewRow();
                Fila["idarticulo"] = IdArticulo;
                Fila["codigo"] = Codigo;
                Fila["articulo"] = Nombre;
                Fila["stock"] = Stock;
                Fila["cantidad"] = 1;
                Fila["precio"] = Precio;
                Fila["descuento"] = 0;
                Fila["importe"] = Precio;// 1 x precio

                this.DtDetalle.Rows.Add(Fila);//Despues que agrego el detalle, llamo al metodo calculardetalles
                this.DtDetalle.AcceptChanges(); //Acepta el cambio en Detalle
                this.CalcularTotales(); //Llamo al metodo calcular detalles
            }
        }

        private void CalcularTotales()
        {
            decimal Total = 0;
            decimal SubTotal = 0;
            decimal TotalIVA = 0;

            //Si tengo cero filas, no va ser necesario recorrerlo, el total sera 0.
            if (DGVDetalle.Rows.Count == 0)
            {
                Total = 0;
            }
            else
            { //Si tengo al menos una fila, recorrerlo y calcular el total.
                foreach (DataRow FilaTemp in DtDetalle.Rows)
                {
                    try
                    {
                        if (FilaTemp.RowState != DataRowState.Deleted)
                            SubTotal = SubTotal + Convert.ToDecimal(FilaTemp["importe"]);
                        TotalIVA = (SubTotal * Convert.ToDecimal(txtIVA.Text));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            txtSubtotal.Text = SubTotal.ToString("#0.00#");
            txtTotalIVA.Text = TotalIVA.ToString("#0.00#");
            txtTotal.Text = (SubTotal + TotalIVA).ToString("#0.00#");
        }

        private void btnVerArticulo_Click(object sender, EventArgs e)
        {
            panelArticulos.Visible = true; 
        }

        private void btnSalirArticulos_Click(object sender, EventArgs e)
        {
            panelArticulos.Visible = false;
        }

        private void btnFiltrarArticulos_Click(object sender, EventArgs e)
        {
            try
            {
                DGVArticulos.DataSource = CN_Articulo.BuscarVenta(txtFiltrarArticulo.Text.Trim());
                this.FormatoArticulos();
                LblTotalArticulos.Text = "Total Registros: " + Convert.ToString(DGVArticulos.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormatoArticulos()
        {
            DGVArticulos.Columns[1].Visible = false;
            DGVArticulos.Columns[2].Width = 100;
            DGVArticulos.Columns[3].HeaderText = "Categoria";
            DGVArticulos.Columns[3].Width = 100;
            DGVArticulos.Columns[3].HeaderText = "Código";
            DGVArticulos.Columns[4].Width = 150;
            DGVArticulos.Columns[5].Width = 100;
            DGVArticulos.Columns[5].HeaderText = "Precio Venta";
            DGVArticulos.Columns[6].Width = 60;
            DGVArticulos.Columns[7].Width = 200;
            DGVArticulos.Columns[7].HeaderText = "Descripción";
            DGVArticulos.Columns[8].Width = 100;
        }

        private void DGVArticulos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Todos los valores los pasamos a detalle
            int IdArticulo, Stock;
            string Codigo, Nombre;
            decimal Precio;
            IdArticulo = Convert.ToInt32(DGVArticulos.CurrentRow.Cells["ID"].Value);//lo que tengo en mi dgvArticulos en la fila seleccionada
            Codigo = Convert.ToString(DGVArticulos.CurrentRow.Cells["Codigo"].Value);
            Nombre = Convert.ToString(DGVArticulos.CurrentRow.Cells["Nombre"].Value);
            Stock = Convert.ToInt32(DGVArticulos.CurrentRow.Cells["Stock"].Value);
            Precio = Convert.ToDecimal(DGVArticulos.CurrentRow.Cells["Precio_Venta"].Value);
            this.AgregarDetalle(IdArticulo, Codigo, Nombre, Stock, Precio);
        }

        private void DGVDetalle_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //Declaro un objeto fila, la fila donde se encuentra la celda que estoy modificando.
            DataRow Fila = (DataRow)DtDetalle.Rows[e.RowIndex];

            string Articulo = Convert.ToString(Fila["articulo"]);//almaceno el valor de esa celda articulo en la variable articulo
            int Cantidad = Convert.ToInt32(Fila["cantidad"]);
            int Stock = Convert.ToInt32(Fila["stock"]);
            decimal Precio = Convert.ToDecimal(Fila["precio"]);
            decimal Descuento = Convert.ToDecimal(Fila["descuento"]);

            //Agrego una estructura condicional, si la cantidad es mayor al stock, envio un mensaje de error.
            if (Cantidad>Stock)
            {
                //A lo mucho la cantidad puede ser igual al stock
                Cantidad = Stock;
                this.MensajeError("La cantidad de venta del articulo " + Articulo + " supera el stock disponible " + Stock);
                Fila["cantidad"] = Cantidad;
            }
            Fila["importe"] = (Precio * Cantidad)-Descuento;
            this.CalcularTotales();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
            TabGeneral.SelectedIndex = 0;//Regresamos al tab listado
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                String Rpta = "";
                if (txtIdCliente.Text == String.Empty || txtIVA.Text == String.Empty || txtNumero.Text == String.Empty || DGVDetalle.Rows.Count == 0)
                {
                    this.MensajeError("Falta ingresar algunos datos, serán remarcados.");
                    errorIcono.SetError(txtIdCliente, "Seleccione un cliente.");
                    errorIcono.SetError(txtIVA, "Ingrese un impuesto.");
                    errorIcono.SetError(txtNumero, "Ingrese un número de comprobante.");
                    errorIcono.SetError(DGVDetalle, "Debe tener al menos un detalle.");


                }
                else
                {
                    Rpta = CN_Venta.Insertar(Convert.ToInt32(txtIdCliente.Text), Variables.IdUsuario, cboComprobante.Text, txtSerie.Text.Trim(), txtNumero.Text.Trim(), Convert.ToDecimal(txtIVA.Text), Convert.ToDecimal(txtTotal.Text), DtDetalle);

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
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void DgvListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DGVListarDetalle.DataSource = CN_Venta.ListarDetalle(Convert.ToInt32(DgvListado.CurrentRow.Cells["ID"].Value));

                decimal SubTotal, Total;
                decimal IVA = Convert.ToDecimal(DgvListado.CurrentRow.Cells["Impuesto"].Value);
                Total = Convert.ToDecimal(DgvListado.CurrentRow.Cells["Total"].Value);
                SubTotal=Total/(1+IVA); 
                txtSubTotalD.Text = SubTotal.ToString("#0.00#");
                txtTotalIvaD.Text =(Total-SubTotal).ToString("#0.00#");
                txtTotalD.Text = Total.ToString("#0.00#");

                panelListarDetalle.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSalirDetalle_Click(object sender, EventArgs e)
        {
            panelListarDetalle.Visible=false;   
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

        private void chkSeleccionar_CheckedChanged(object sender, EventArgs e)
        {

            //Si esta marcado, la columna seleccionar y los botones estaran visibles
            if (chkSeleccionar.Checked)
            {
                DgvListado.Columns[0].Visible = true;
                btnAnular.Visible = true;
            }
            else
            {
                DgvListado.Columns[0].Visible = false;
                btnAnular.Visible = false;
            }
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Deseas anular el/los registro(s)?", "Sistema de ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    int Codigo;
                    string Rpta = "";

                    foreach (DataGridViewRow Row in DgvListado.Rows)
                    {
                        if (Convert.ToBoolean(Row.Cells[0].Value))
                        {
                            Codigo = Convert.ToInt32(Row.Cells[1].Value);//Columna 1 del ID 
                            Rpta = CN_Venta.Anular(Codigo);//Llamo al metodo anular y le paso el ID

                            if (Rpta.Equals("OK"))
                            {
                                this.MensajeOk("Se anulo el registro: " + Convert.ToString(Row.Cells[6].Value) + "-" + Convert.ToString(Row.Cells[7].Value));//Serie y Numero comprobante
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

        private void btnComprobante_Click(object sender, EventArgs e)
        {
            try 
            {
                Variables.IdVenta = Convert.ToInt32(DgvListado.CurrentRow.Cells["ID"].Value);
                Reportes.FrmReporteComprobante Reporte=new Reportes.FrmReporteComprobante();    
                Reporte.ShowDialog();   
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
