using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutosApp72
{
    public partial class Revisiones : Form
    {
        public Revisiones()
        {
            InitializeComponent();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void Revisiones_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'autos72DataSet.ConsRevisiones' Puede moverla o quitarla según sea necesario.
            this.consRevisionesTableAdapter.Fill(this.autos72DataSet.ConsRevisiones);
            consRevisionesDataGridView.Visible = true;
            consRevXPlacaDataGridView1.Visible = false;
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardarRevision_Click(object sender, EventArgs e)
        {
            try
            {
                string c_Aceite = Convert.ToString(cambio_de_aceiteComboBox.SelectedItem);
                string c_Frenos = Convert.ToString(cambio_de_frenosComboBox.SelectedItem);
                string c_Filtro = Convert.ToString(cambio_de_filtroComboBox.SelectedItem);
                this.insRevisionTableAdapter.Fill(this.autos72DataSet.InsRevision, new System.Nullable<int>(((int)(System.Convert.ChangeType(id_ClienteTextBox.Text, typeof(int))))), txtMatricula.Text, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(fecha_RevisionDateTimePicker.Value, typeof(System.DateTime))))), c_Aceite, c_Filtro, c_Frenos);
                this.consRevisionesTableAdapter.Fill(this.autos72DataSet.ConsRevisiones);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }


        private void btnConsCliente_Click(object sender, EventArgs e)
        {
            try
            {
                this.datosclienteTableAdapter.Fill(this.autos72DataSet.datoscliente, new System.Nullable<int>(((int)(System.Convert.ChangeType(TxtidCliente.Text, typeof(int))))));
                this.consClienteXidTableAdapter.Fill(this.autos72DataSet.ConsClienteXid, new System.Nullable<int>(((int)(System.Convert.ChangeType(TxtidCliente.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void btnBuscarRev_Click(object sender, EventArgs e)
        {
            try
            {
                this.consRevXPlacaTableAdapter.Fill(this.autos72DataSet.ConsRevXPlaca, txtPlaca.Text);
                consRevisionesDataGridView.Visible = false;
                consRevXPlacaDataGridView1.Visible = true;
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmPrincipal Pr = new FrmPrincipal();
            Pr.Show();
            this.Hide();
        }
    }
}
