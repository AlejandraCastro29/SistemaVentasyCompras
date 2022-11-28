using Sistema.Negocio;
using System;
using System.Windows.Forms;

namespace Sistema.Presentacion
{
    public partial class FrmConsultasFechas : Form
    {
        public FrmConsultasFechas()
        {
            InitializeComponent();
        }

        private void Buscar()
        {
            try
            {
                DgvListado.DataSource = CN_Venta.ConsultasFechas(Convert.ToDateTime(dtpFechaInicio.Value),Convert.ToDateTime(dtpFechaFin.Value));
                this.Limpiar();
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
            DgvListado.Columns[0].Visible = false;
        }

        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MensajeOk(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void FrmConsultasFechas_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void DgvListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DGVListarDetalle.DataSource = CN_Venta.ListarDetalle(Convert.ToInt32(DgvListado.CurrentRow.Cells["ID"].Value));

                decimal SubTotal, Total;
                decimal IVA = Convert.ToDecimal(DgvListado.CurrentRow.Cells["Impuesto"].Value);
                Total = Convert.ToDecimal(DgvListado.CurrentRow.Cells["Total"].Value);
                SubTotal = Total / (1 + IVA);
                txtSubTotalD.Text = SubTotal.ToString("#0.00#");
                txtTotalIvaD.Text = (Total - SubTotal).ToString("#0.00#");
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
            panelListarDetalle.Visible = false;
        }
    }
}
