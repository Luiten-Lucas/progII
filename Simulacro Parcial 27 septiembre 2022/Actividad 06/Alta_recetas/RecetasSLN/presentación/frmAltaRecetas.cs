using RecetasSLN.datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RecetasSLN.dominio;

namespace RecetasSLN.presentación
{
    public partial class frmAltaRecetas : Form
    {
        Helper helper = new Helper();
        int cantidadIngredientes = 0;
        int RecetaActual;
        public frmAltaRecetas(int nroReceta, DataTable tiposReceta)
        {
            InitializeComponent();
            lblTitulo.Text = lblTitulo.Text + nroReceta.ToString();
            lblCnt.Text = cantidadIngredientes.ToString();
            RecetaActual = nroReceta;
        }

        private void frmAltaRecetas_Load(object sender, EventArgs e)
        {
            dgvReceta.CurrentCell = null;
            DataTable tabla = new DataTable();
            DataTable tabla2 = new DataTable();
            tabla = helper.ConsultarIngredientes();
            cboIngredientes.DataSource = tabla;
            cboIngredientes.ValueMember = "id_ingrediente";
            cboIngredientes.DisplayMember = "n_ingrediente";
            tabla2 = helper.ConsultarTiposReceta();
            cboTipoReceta.DataSource = tabla2;
            cboTipoReceta.ValueMember = "idTipo";
            cboTipoReceta.DisplayMember = "nombreTipo";
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text.Length < 5 || txtNombre.Text.Length > 50)
            {
                MessageBox.Show("El nombre de la receta no puede contener menos de 5 caracteres o más de 50 ", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNombre.Focus();
            }
        }

        private void txtCheff_Leave(object sender, EventArgs e)
        {

            if (txtCheff.Text.Length < 5 || txtCheff.Text.Length > 100)
            {
                MessageBox.Show("El nombre del cheff no puede contener menos de 5 caracteres o más de 100 ", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCheff.Focus();
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in dgvReceta.Rows)
            {
                if (row.Cells[0].Value.Equals(cboIngredientes.Text))
                {
                    MessageBox.Show("Este ingrediente ya está cargado", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            if (nudCantidad.Value < 1)
            {
                MessageBox.Show("Debe indicar la cantidad deseada del ingrediente seleccionado", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string ingrediente = cboIngredientes.Text.ToString();
            int cantidad = (int)nudCantidad.Value;
            int idIngrediente = cboIngredientes.SelectedIndex;
            dgvReceta.Rows.Add(new object[] { ingrediente, cantidad, idIngrediente });
            cantidadIngredientes = cantidadIngredientes + cantidad;
            lblCnt.Text =  cantidadIngredientes.ToString();
        }

        private void dgvReceta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvReceta.CurrentCell.ColumnIndex == 3)
            {
                cantidadIngredientes = cantidadIngredientes- (int)dgvReceta.CurrentRow.Cells[1].Value;
                dgvReceta.Rows.RemoveAt(dgvReceta.CurrentCell.RowIndex);
                lblCnt.Text = cantidadIngredientes.ToString();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var confirmacion = MessageBox.Show("¿Está seguro de cancelar la carga de receta actual?", "Cancelar carga", MessageBoxButtons.YesNo);
            if (confirmacion == DialogResult.Yes)
            {
                Limpiar();
            }
            else { return; }
        }
        private void Limpiar()
        {
            dgvReceta.Rows.Clear();
            txtNombre.Text = "";
            txtCheff.Text = "";
            nudCantidad.Value = 0;
            cantidadIngredientes = 0;
            lblCnt.Text = cantidadIngredientes.ToString();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(dgvReceta.Rows.Count < 3)
            {
                MessageBox.Show("La receta debe contar con al menos 3 ingredientes", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            } else {
                var confirmacion = MessageBox.Show("Se procederá a cargar la receta "+txtNombre.Text+". ¿Ha olvidado ingredientes?", "Cancelar carga", MessageBoxButtons.YesNo);
                if (confirmacion == DialogResult.Yes)
                {
                    return;
                }
                else
                {
                    List<DetalleReceta> detalles = new List<DetalleReceta>();
                    foreach (DataGridViewRow row in dgvReceta.Rows)
                    {
                        DetalleReceta detalle = new DetalleReceta((string)row.Cells[0].Value, (int)row.Cells[1].Value, (int)row.Cells[2].Value, RecetaActual);
                        //ingrediente,cantidad,idIngrediente,Idreceta
                        detalles.Add(detalle);
                    }
                    helper.GuardarReceta(detalles,txtNombre.Text,txtCheff.Text,(int)cboTipoReceta.SelectedValue);
                    this.Limpiar();
                    return;
                }
            }
        }
    }
}

