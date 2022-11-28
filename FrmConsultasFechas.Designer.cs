namespace Sistema.Presentacion
{
    partial class FrmConsultasFechas
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lbltotal = new System.Windows.Forms.Label();
            this.DgvListado = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TabGeneral = new System.Windows.Forms.TabControl();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            this.tabListado.SuspendLayout();
            this.panelListarDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListarDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).BeginInit();
            this.TabGeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            // 
            // tabListado
            // 
            this.tabListado.Controls.Add(this.label2);
            this.tabListado.Controls.Add(this.dtpFechaFin);
            this.tabListado.Controls.Add(this.label1);
            this.tabListado.Controls.Add(this.dtpFechaInicio);
            this.tabListado.Controls.Add(this.panelListarDetalle);
            this.tabListado.Controls.Add(this.btnBuscar);
            this.tabListado.Controls.Add(this.lbltotal);
            this.tabListado.Controls.Add(this.DgvListado);
            this.tabListado.Location = new System.Drawing.Point(4, 22);
            this.tabListado.Name = "tabListado";
            this.tabListado.Padding = new System.Windows.Forms.Padding(3);
            this.tabListado.Size = new System.Drawing.Size(1046, 411);
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
            this.panelListarDetalle.Location = new System.Drawing.Point(100, 123);
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
            this.btnSalirDetalle.Visible = false;
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
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(600, 17);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
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
            this.DgvListado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListado_CellDoubleClick);
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
            this.TabGeneral.Location = new System.Drawing.Point(-3, 1);
            this.TabGeneral.Name = "TabGeneral";
            this.TabGeneral.SelectedIndex = 0;
            this.TabGeneral.Size = new System.Drawing.Size(1054, 437);
            this.TabGeneral.TabIndex = 3;
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicio.Location = new System.Drawing.Point(92, 20);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaInicio.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Fecha inicio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(314, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Fecha fin:";
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFin.Location = new System.Drawing.Point(374, 19);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaFin.TabIndex = 11;
            // 
            // FrmConsultasFechas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 450);
            this.Controls.Add(this.TabGeneral);
            this.Name = "FrmConsultasFechas";
            this.Text = "Consultas de Ventas entre Fechas";
            this.Load += new System.EventHandler(this.FrmConsultasFechas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            this.tabListado.ResumeLayout(false);
            this.tabListado.PerformLayout();
            this.panelListarDetalle.ResumeLayout(false);
            this.panelListarDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListarDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).EndInit();
            this.TabGeneral.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorIcono;
        private System.Windows.Forms.TabControl TabGeneral;
        private System.Windows.Forms.TabPage tabListado;
        private System.Windows.Forms.Panel panelListarDetalle;
        private System.Windows.Forms.TextBox txtTotalD;
        private System.Windows.Forms.TextBox txtTotalIvaD;
        private System.Windows.Forms.TextBox txtSubTotalD;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSalirDetalle;
        private System.Windows.Forms.DataGridView DGVListarDetalle;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.DataGridView DgvListado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
    }
}