namespace Sistema.Presentacion
{
    partial class FrmIngreso
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.tabMantenimiento = new System.Windows.Forms.TabPage();
            this.Detalle = new System.Windows.Forms.GroupBox();
            this.panelArticulos = new System.Windows.Forms.Panel();
            this.LblTotalArticulos = new System.Windows.Forms.Label();
            this.btnSalirArticulos = new System.Windows.Forms.Button();
            this.btnFiltrarArticulos = new System.Windows.Forms.Button();
            this.txtFiltrarArticulo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DGVArticulos = new System.Windows.Forms.DataGridView();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtTotalIVA = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.lblTotalA = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnVerArticulo = new System.Windows.Forms.Button();
            this.txtCodigoArticulo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DGVDetalle = new System.Windows.Forms.DataGridView();
            this.Cabecera = new System.Windows.Forms.GroupBox();
            this.txtIVA = new System.Windows.Forms.TextBox();
            this.Impuesto = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboComprobante = new System.Windows.Forms.ComboBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.btnBuscarProveedor = new System.Windows.Forms.Button();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.txtIdProveedor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TabGeneral = new System.Windows.Forms.TabControl();
            this.tabListado = new System.Windows.Forms.TabPage();
            this.panelListarDetalle = new System.Windows.Forms.Panel();
            this.txtTotalD = new System.Windows.Forms.TextBox();
            this.txtTotalIvaD = new System.Windows.Forms.TextBox();
            this.txtSubTotalD = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSalirDetalle = new System.Windows.Forms.Button();
            this.DGVListarDetalle = new System.Windows.Forms.DataGridView();
            this.btnAnular = new System.Windows.Forms.Button();
            this.chkSeleccionar = new System.Windows.Forms.CheckBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lbltotal = new System.Windows.Forms.Label();
            this.DgvListado = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            this.tabMantenimiento.SuspendLayout();
            this.Detalle.SuspendLayout();
            this.panelArticulos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDetalle)).BeginInit();
            this.Cabecera.SuspendLayout();
            this.TabGeneral.SuspendLayout();
            this.tabListado.SuspendLayout();
            this.panelListarDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListarDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).BeginInit();
            this.SuspendLayout();
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "(*) Indica que el dato es obligatorio.";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(261, 437);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(136, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(93, 437);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(136, 23);
            this.btnInsertar.TabIndex = 5;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(631, 25);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 4;
            this.txtId.Visible = false;
            // 
            // tabMantenimiento
            // 
            this.tabMantenimiento.Controls.Add(this.Detalle);
            this.tabMantenimiento.Controls.Add(this.Cabecera);
            this.tabMantenimiento.Controls.Add(this.btnCancelar);
            this.tabMantenimiento.Controls.Add(this.btnInsertar);
            this.tabMantenimiento.Location = new System.Drawing.Point(4, 22);
            this.tabMantenimiento.Name = "tabMantenimiento";
            this.tabMantenimiento.Padding = new System.Windows.Forms.Padding(3);
            this.tabMantenimiento.Size = new System.Drawing.Size(1046, 463);
            this.tabMantenimiento.TabIndex = 1;
            this.tabMantenimiento.Text = "Mantenimiento";
            this.tabMantenimiento.UseVisualStyleBackColor = true;
            // 
            // Detalle
            // 
            this.Detalle.Controls.Add(this.panelArticulos);
            this.Detalle.Controls.Add(this.txtTotal);
            this.Detalle.Controls.Add(this.txtTotalIVA);
            this.Detalle.Controls.Add(this.txtSubtotal);
            this.Detalle.Controls.Add(this.lblTotalA);
            this.Detalle.Controls.Add(this.label9);
            this.Detalle.Controls.Add(this.label3);
            this.Detalle.Controls.Add(this.label8);
            this.Detalle.Controls.Add(this.btnVerArticulo);
            this.Detalle.Controls.Add(this.txtCodigoArticulo);
            this.Detalle.Controls.Add(this.label7);
            this.Detalle.Controls.Add(this.DGVDetalle);
            this.Detalle.Location = new System.Drawing.Point(3, 109);
            this.Detalle.Name = "Detalle";
            this.Detalle.Size = new System.Drawing.Size(1006, 322);
            this.Detalle.TabIndex = 9;
            this.Detalle.TabStop = false;
            this.Detalle.Text = "Detalle";
            // 
            // panelArticulos
            // 
            this.panelArticulos.BackColor = System.Drawing.Color.Silver;
            this.panelArticulos.Controls.Add(this.LblTotalArticulos);
            this.panelArticulos.Controls.Add(this.btnSalirArticulos);
            this.panelArticulos.Controls.Add(this.btnFiltrarArticulos);
            this.panelArticulos.Controls.Add(this.txtFiltrarArticulo);
            this.panelArticulos.Controls.Add(this.label6);
            this.panelArticulos.Controls.Add(this.DGVArticulos);
            this.panelArticulos.Location = new System.Drawing.Point(64, 57);
            this.panelArticulos.Name = "panelArticulos";
            this.panelArticulos.Size = new System.Drawing.Size(786, 265);
            this.panelArticulos.TabIndex = 11;
            this.panelArticulos.Visible = false;
            // 
            // LblTotalArticulos
            // 
            this.LblTotalArticulos.AutoSize = true;
            this.LblTotalArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalArticulos.Location = new System.Drawing.Point(459, 238);
            this.LblTotalArticulos.Name = "LblTotalArticulos";
            this.LblTotalArticulos.Size = new System.Drawing.Size(92, 15);
            this.LblTotalArticulos.TabIndex = 5;
            this.LblTotalArticulos.Text = "Total Registros:";
            // 
            // btnSalirArticulos
            // 
            this.btnSalirArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirArticulos.ForeColor = System.Drawing.Color.Red;
            this.btnSalirArticulos.Location = new System.Drawing.Point(758, 7);
            this.btnSalirArticulos.Name = "btnSalirArticulos";
            this.btnSalirArticulos.Size = new System.Drawing.Size(22, 37);
            this.btnSalirArticulos.TabIndex = 4;
            this.btnSalirArticulos.Text = "X";
            this.btnSalirArticulos.UseVisualStyleBackColor = true;
            this.btnSalirArticulos.Click += new System.EventHandler(this.btnSalirArticulos_Click);
            // 
            // btnFiltrarArticulos
            // 
            this.btnFiltrarArticulos.Location = new System.Drawing.Point(391, 26);
            this.btnFiltrarArticulos.Name = "btnFiltrarArticulos";
            this.btnFiltrarArticulos.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrarArticulos.TabIndex = 3;
            this.btnFiltrarArticulos.Text = "Buscar";
            this.btnFiltrarArticulos.UseVisualStyleBackColor = true;
            this.btnFiltrarArticulos.Click += new System.EventHandler(this.btnFiltrarArticulos_Click);
            // 
            // txtFiltrarArticulo
            // 
            this.txtFiltrarArticulo.Location = new System.Drawing.Point(62, 28);
            this.txtFiltrarArticulo.Name = "txtFiltrarArticulo";
            this.txtFiltrarArticulo.Size = new System.Drawing.Size(302, 20);
            this.txtFiltrarArticulo.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Buscar";
            // 
            // DGVArticulos
            // 
            this.DGVArticulos.AllowUserToAddRows = false;
            this.DGVArticulos.AllowUserToDeleteRows = false;
            this.DGVArticulos.AllowUserToOrderColumns = true;
            this.DGVArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVArticulos.Location = new System.Drawing.Point(16, 75);
            this.DGVArticulos.Name = "DGVArticulos";
            this.DGVArticulos.ReadOnly = true;
            this.DGVArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVArticulos.Size = new System.Drawing.Size(748, 150);
            this.DGVArticulos.TabIndex = 0;
            this.DGVArticulos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVArticulos_CellDoubleClick);
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(856, 296);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 10;
            // 
            // txtTotalIVA
            // 
            this.txtTotalIVA.Enabled = false;
            this.txtTotalIVA.Location = new System.Drawing.Point(856, 256);
            this.txtTotalIVA.Name = "txtTotalIVA";
            this.txtTotalIVA.Size = new System.Drawing.Size(100, 20);
            this.txtTotalIVA.TabIndex = 9;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Enabled = false;
            this.txtSubtotal.Location = new System.Drawing.Point(856, 215);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(100, 20);
            this.txtSubtotal.TabIndex = 8;
            // 
            // lblTotalA
            // 
            this.lblTotalA.AutoSize = true;
            this.lblTotalA.Location = new System.Drawing.Point(795, 303);
            this.lblTotalA.Name = "lblTotalA";
            this.lblTotalA.Size = new System.Drawing.Size(31, 13);
            this.lblTotalA.TabIndex = 6;
            this.lblTotalA.Text = "Total";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(795, 263);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Total IVA";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(795, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Subtotal";
            // 
            // btnVerArticulo
            // 
            this.btnVerArticulo.Location = new System.Drawing.Point(539, 17);
            this.btnVerArticulo.Name = "btnVerArticulo";
            this.btnVerArticulo.Size = new System.Drawing.Size(75, 23);
            this.btnVerArticulo.TabIndex = 3;
            this.btnVerArticulo.Text = "Ver";
            this.btnVerArticulo.UseVisualStyleBackColor = true;
            this.btnVerArticulo.Click += new System.EventHandler(this.btnVerArticulos_Click);
            // 
            // txtCodigoArticulo
            // 
            this.txtCodigoArticulo.Location = new System.Drawing.Point(90, 20);
            this.txtCodigoArticulo.Name = "txtCodigoArticulo";
            this.txtCodigoArticulo.Size = new System.Drawing.Size(425, 20);
            this.txtCodigoArticulo.TabIndex = 2;
            this.txtCodigoArticulo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigoArticulo_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Articulo";
            // 
            // DGVDetalle
            // 
            this.DGVDetalle.AllowUserToAddRows = false;
            this.DGVDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVDetalle.Location = new System.Drawing.Point(6, 55);
            this.DGVDetalle.Name = "DGVDetalle";
            this.DGVDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVDetalle.Size = new System.Drawing.Size(986, 150);
            this.DGVDetalle.TabIndex = 0;
            this.DGVDetalle.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVDetalle_CellEndEdit);
            this.DGVDetalle.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.DGVDetalle_RowsRemoved);
            // 
            // Cabecera
            // 
            this.Cabecera.Controls.Add(this.txtIVA);
            this.Cabecera.Controls.Add(this.Impuesto);
            this.Cabecera.Controls.Add(this.label5);
            this.Cabecera.Controls.Add(this.label4);
            this.Cabecera.Controls.Add(this.cboComprobante);
            this.Cabecera.Controls.Add(this.txtNumero);
            this.Cabecera.Controls.Add(this.txtSerie);
            this.Cabecera.Controls.Add(this.btnBuscarProveedor);
            this.Cabecera.Controls.Add(this.txtProveedor);
            this.Cabecera.Controls.Add(this.txtIdProveedor);
            this.Cabecera.Controls.Add(this.label2);
            this.Cabecera.Controls.Add(this.label1);
            this.Cabecera.Controls.Add(this.txtId);
            this.Cabecera.Location = new System.Drawing.Point(3, 3);
            this.Cabecera.Name = "Cabecera";
            this.Cabecera.Size = new System.Drawing.Size(1006, 100);
            this.Cabecera.TabIndex = 8;
            this.Cabecera.TabStop = false;
            this.Cabecera.Text = "Cabecera";
            // 
            // txtIVA
            // 
            this.txtIVA.Location = new System.Drawing.Point(631, 58);
            this.txtIVA.Name = "txtIVA";
            this.txtIVA.Size = new System.Drawing.Size(100, 20);
            this.txtIVA.TabIndex = 16;
            this.txtIVA.Text = "0.13";
            // 
            // Impuesto
            // 
            this.Impuesto.AutoSize = true;
            this.Impuesto.Location = new System.Drawing.Point(551, 65);
            this.Impuesto.Name = "Impuesto";
            this.Impuesto.Size = new System.Drawing.Size(37, 13);
            this.Impuesto.TabIndex = 15;
            this.Impuesto.Text = "IVA (*)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(399, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Número";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(280, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Serie";
            // 
            // cboComprobante
            // 
            this.cboComprobante.FormattingEnabled = true;
            this.cboComprobante.Items.AddRange(new object[] {
            "Factura",
            "Boleta",
            "Ticket",
            "Guia"});
            this.cboComprobante.Location = new System.Drawing.Point(90, 63);
            this.cboComprobante.Name = "cboComprobante";
            this.cboComprobante.Size = new System.Drawing.Size(121, 21);
            this.cboComprobante.TabIndex = 12;
            this.cboComprobante.Text = "Factura";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(373, 65);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 11;
            // 
            // txtSerie
            // 
            this.txtSerie.Location = new System.Drawing.Point(244, 65);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(100, 20);
            this.txtSerie.TabIndex = 10;
            // 
            // btnBuscarProveedor
            // 
            this.btnBuscarProveedor.Location = new System.Drawing.Point(539, 22);
            this.btnBuscarProveedor.Name = "btnBuscarProveedor";
            this.btnBuscarProveedor.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarProveedor.TabIndex = 9;
            this.btnBuscarProveedor.Text = "Buscar";
            this.btnBuscarProveedor.UseVisualStyleBackColor = true;
            this.btnBuscarProveedor.Click += new System.EventHandler(this.btnBuscarProveedor_Click);
            // 
            // txtProveedor
            // 
            this.txtProveedor.Enabled = false;
            this.txtProveedor.Location = new System.Drawing.Point(247, 22);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(268, 20);
            this.txtProveedor.TabIndex = 8;
            // 
            // txtIdProveedor
            // 
            this.txtIdProveedor.Enabled = false;
            this.txtIdProveedor.Location = new System.Drawing.Point(90, 24);
            this.txtIdProveedor.Name = "txtIdProveedor";
            this.txtIdProveedor.Size = new System.Drawing.Size(121, 20);
            this.txtIdProveedor.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Comprobante (*)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Proveedor (*)";
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            // 
            // TabGeneral
            // 
            this.TabGeneral.Controls.Add(this.tabListado);
            this.TabGeneral.Controls.Add(this.tabMantenimiento);
            this.TabGeneral.Location = new System.Drawing.Point(2, 1);
            this.TabGeneral.Name = "TabGeneral";
            this.TabGeneral.SelectedIndex = 0;
            this.TabGeneral.Size = new System.Drawing.Size(1054, 489);
            this.TabGeneral.TabIndex = 1;
            // 
            // tabListado
            // 
            this.tabListado.Controls.Add(this.panelListarDetalle);
            this.tabListado.Controls.Add(this.btnAnular);
            this.tabListado.Controls.Add(this.chkSeleccionar);
            this.tabListado.Controls.Add(this.btnBuscar);
            this.tabListado.Controls.Add(this.txtBuscar);
            this.tabListado.Controls.Add(this.lbltotal);
            this.tabListado.Controls.Add(this.DgvListado);
            this.tabListado.Location = new System.Drawing.Point(4, 22);
            this.tabListado.Name = "tabListado";
            this.tabListado.Padding = new System.Windows.Forms.Padding(3);
            this.tabListado.Size = new System.Drawing.Size(1046, 463);
            this.tabListado.TabIndex = 0;
            this.tabListado.Text = "Listado";
            this.tabListado.UseVisualStyleBackColor = true;
            // 
            // panelListarDetalle
            // 
            this.panelListarDetalle.BackColor = System.Drawing.Color.Gainsboro;
            this.panelListarDetalle.Controls.Add(this.txtTotalD);
            this.panelListarDetalle.Controls.Add(this.txtTotalIvaD);
            this.panelListarDetalle.Controls.Add(this.txtSubTotalD);
            this.panelListarDetalle.Controls.Add(this.label12);
            this.panelListarDetalle.Controls.Add(this.label11);
            this.panelListarDetalle.Controls.Add(this.label10);
            this.panelListarDetalle.Controls.Add(this.btnSalirDetalle);
            this.panelListarDetalle.Controls.Add(this.DGVListarDetalle);
            this.panelListarDetalle.Location = new System.Drawing.Point(167, 87);
            this.panelListarDetalle.Name = "panelListarDetalle";
            this.panelListarDetalle.Size = new System.Drawing.Size(862, 281);
            this.panelListarDetalle.TabIndex = 8;
            this.panelListarDetalle.Visible = false;
            // 
            // txtTotalD
            // 
            this.txtTotalD.Enabled = false;
            this.txtTotalD.Location = new System.Drawing.Point(748, 241);
            this.txtTotalD.Name = "txtTotalD";
            this.txtTotalD.Size = new System.Drawing.Size(100, 20);
            this.txtTotalD.TabIndex = 7;
            // 
            // txtTotalIvaD
            // 
            this.txtTotalIvaD.Enabled = false;
            this.txtTotalIvaD.Location = new System.Drawing.Point(748, 215);
            this.txtTotalIvaD.Name = "txtTotalIvaD";
            this.txtTotalIvaD.Size = new System.Drawing.Size(100, 20);
            this.txtTotalIvaD.TabIndex = 6;
            // 
            // txtSubTotalD
            // 
            this.txtSubTotalD.Enabled = false;
            this.txtSubTotalD.Location = new System.Drawing.Point(748, 187);
            this.txtSubTotalD.Name = "txtSubTotalD";
            this.txtSubTotalD.Size = new System.Drawing.Size(100, 20);
            this.txtSubTotalD.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(695, 248);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Total";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(680, 222);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Total IVA";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(680, 194);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Subtotal";
            // 
            // btnSalirDetalle
            // 
            this.btnSalirDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirDetalle.ForeColor = System.Drawing.Color.Red;
            this.btnSalirDetalle.Location = new System.Drawing.Point(817, 13);
            this.btnSalirDetalle.Name = "btnSalirDetalle";
            this.btnSalirDetalle.Size = new System.Drawing.Size(33, 23);
            this.btnSalirDetalle.TabIndex = 1;
            this.btnSalirDetalle.Text = "X";
            this.btnSalirDetalle.UseVisualStyleBackColor = true;
            this.btnSalirDetalle.Click += new System.EventHandler(this.btnSalirDetalle_Click);
            // 
            // DGVListarDetalle
            // 
            this.DGVListarDetalle.AllowUserToAddRows = false;
            this.DGVListarDetalle.AllowUserToDeleteRows = false;
            this.DGVListarDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVListarDetalle.Location = new System.Drawing.Point(12, 42);
            this.DGVListarDetalle.Name = "DGVListarDetalle";
            this.DGVListarDetalle.ReadOnly = true;
            this.DGVListarDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVListarDetalle.Size = new System.Drawing.Size(838, 135);
            this.DGVListarDetalle.TabIndex = 0;
            // 
            // btnAnular
            // 
            this.btnAnular.Location = new System.Drawing.Point(954, 30);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(75, 23);
            this.btnAnular.TabIndex = 7;
            this.btnAnular.Text = "Anular";
            this.btnAnular.UseVisualStyleBackColor = true;
            this.btnAnular.Visible = false;
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // chkSeleccionar
            // 
            this.chkSeleccionar.AutoSize = true;
            this.chkSeleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSeleccionar.Location = new System.Drawing.Point(22, 283);
            this.chkSeleccionar.Name = "chkSeleccionar";
            this.chkSeleccionar.Size = new System.Drawing.Size(102, 19);
            this.chkSeleccionar.TabIndex = 4;
            this.chkSeleccionar.Text = "Seleccionar";
            this.chkSeleccionar.UseVisualStyleBackColor = true;
            this.chkSeleccionar.CheckedChanged += new System.EventHandler(this.chkSeleccionar_CheckedChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(560, 21);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(22, 21);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(520, 20);
            this.txtBuscar.TabIndex = 2;
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.Location = new System.Drawing.Point(721, 282);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(47, 16);
            this.lbltotal.TabIndex = 1;
            this.lbltotal.Text = "Total:";
            // 
            // DgvListado
            // 
            this.DgvListado.AllowUserToAddRows = false;
            this.DgvListado.AllowUserToDeleteRows = false;
            this.DgvListado.AllowUserToOrderColumns = true;
            this.DgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            this.DgvListado.Location = new System.Drawing.Point(22, 59);
            this.DgvListado.Name = "DgvListado";
            this.DgvListado.ReadOnly = true;
            this.DgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListado.Size = new System.Drawing.Size(1007, 209);
            this.DgvListado.TabIndex = 0;
            this.DgvListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListado_CellContentClick);
            this.DgvListado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListado_CellDoubleClick);
            // 
            // FrmIngreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1056, 484);
            this.Controls.Add(this.TabGeneral);
            this.Name = "FrmIngreso";
            this.Text = "Ingresos";
            this.Load += new System.EventHandler(this.FrmIngreso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            this.tabMantenimiento.ResumeLayout(false);
            this.Detalle.ResumeLayout(false);
            this.Detalle.PerformLayout();
            this.panelArticulos.ResumeLayout(false);
            this.panelArticulos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDetalle)).EndInit();
            this.Cabecera.ResumeLayout(false);
            this.Cabecera.PerformLayout();
            this.TabGeneral.ResumeLayout(false);
            this.tabListado.ResumeLayout(false);
            this.tabListado.PerformLayout();
            this.panelListarDetalle.ResumeLayout(false);
            this.panelListarDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListarDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorIcono;
        private System.Windows.Forms.TabControl TabGeneral;
        private System.Windows.Forms.TabPage tabListado;
        private System.Windows.Forms.Button btnAnular;
        private System.Windows.Forms.CheckBox chkSeleccionar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.DataGridView DgvListado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private System.Windows.Forms.TabPage tabMantenimiento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.GroupBox Cabecera;
        private System.Windows.Forms.TextBox txtIVA;
        private System.Windows.Forms.Label Impuesto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboComprobante;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.Button btnBuscarProveedor;
        private System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.TextBox txtIdProveedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Detalle;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtTotalIVA;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label lblTotalA;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnVerArticulo;
        private System.Windows.Forms.TextBox txtCodigoArticulo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView DGVDetalle;
        private System.Windows.Forms.Panel panelArticulos;
        private System.Windows.Forms.Label LblTotalArticulos;
        private System.Windows.Forms.Button btnSalirArticulos;
        private System.Windows.Forms.Button btnFiltrarArticulos;
        private System.Windows.Forms.TextBox txtFiltrarArticulo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView DGVArticulos;
        private System.Windows.Forms.Panel panelListarDetalle;
        private System.Windows.Forms.TextBox txtTotalD;
        private System.Windows.Forms.TextBox txtTotalIvaD;
        private System.Windows.Forms.TextBox txtSubTotalD;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSalirDetalle;
        private System.Windows.Forms.DataGridView DGVListarDetalle;
    }
}