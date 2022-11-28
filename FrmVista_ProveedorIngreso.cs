using Sistema.Negocio;
using System;
using System.Windows.Forms;

namespace Sistema.Presentacion
{
    public partial class FrmVista_ProveedorIngreso : Form
    {
        public FrmVista_ProveedorIngreso()
        {
            InitializeComponent();
        }

        private void Listar()
        {
            try
            {
                DgvListado.DataSource = CN_Persona.ListarProveedores();
                this.Formato();
                lbltotalproveedores.Text = "Total registros: " + Convert.ToString(DgvListado.Rows.Count);
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
                DgvListado.DataSource = CN_Persona.BuscarProveedores(txtBuscarProveedor.Text);//Pasamos el parametro por la caja de texto como string
                this.Formato();
                lbltotalproveedores.Text = "Total registros: " + Convert.ToString(DgvListado.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Formato()
        {
            DgvListado.Columns[0].Visible = false;//Seleccionar
            DgvListado.Columns[1].Width = 50; //ID 
            DgvListado.Columns[2].HeaderText = "Tipo Persona";
            DgvListado.Columns[2].Width = 100;
            DgvListado.Columns[3].Width = 170; //Nombre
            DgvListado.Columns[4].HeaderText = "Documento";
            DgvListado.Columns[4].Width = 100;
            DgvListado.Columns[5].HeaderText = "Numero Doc.";
            DgvListado.Columns[5].Width = 100;
            DgvListado.Columns[6].HeaderText = "Dirección";
            DgvListado.Columns[6].Width = 120;
            DgvListado.Columns[7].Width = 100;
            DgvListado.Columns[7].HeaderText = "Teléfono";
            DgvListado.Columns[8].Width = 120;
        }

        private void FrmVista_ProveedorIngreso_Load(object sender, EventArgs e)
        {
            //Al momento de cargar el formulario, si tenemos varios proveedores, no es recomendable ejecutar listar,
            //es mejor escribir el texto del proveedor que deseamos buscar y ahi seleccionar.
            this.Listar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void DgvListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Cuando haga doble clic al registro, el Id y el nombre del Proveedor se me deben regresar al FmIngreso
            Variables.IdProveedor = Convert.ToInt32(DgvListado.CurrentRow.Cells["ID"].Value);//Idproveedor
            Variables.NombreProveedor = Convert.ToString(DgvListado.CurrentRow.Cells["Nombre"].Value);//NombreProveedor
            //Una vez que envie los valores, se cierra el Frmvista
            this.Close();
        }
    }
}
