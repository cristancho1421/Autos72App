using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace AutosApp72
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.insClienteTableAdapter.Fill(this.autos72DataSet.InsCliente, new System.Nullable<int>(((int)(System.Convert.ChangeType(identificacionTextBox.Text, typeof(int))))), nombreTextBox.Text, direccionTextBox.Text, ciudadComboBox.Text, telefonoTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'autos72DataSet.ConsClientes' Puede moverla o quitarla según sea necesario.
            this.consClientesTableAdapter.Fill(this.autos72DataSet.ConsClientes);
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string cdad = Convert.ToString(ciudadComboBox.SelectedItem);
                this.insClienteTableAdapter.Fill(this.autos72DataSet.InsCliente, new System.Nullable<int>(((int)(System.Convert.ChangeType(identificacionTextBox.Text, typeof(int))))), nombreTextBox.Text, direccionTextBox.Text, cdad, telefonoTextBox.Text);
                identificacionTextBox.Clear(); nombreTextBox.Clear(); direccionTextBox.Clear(); telefonoTextBox.Clear();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            insClienteDataGridView.Visible = true;
            consClientexCiudadDataGridView.Visible = false;
            consClientesDataGridView.Visible = false;
            consClienteXidDataGridView.Visible = false;
            elimClienteDataGridView.Visible = false;
        }

        private void btnBuscarXciudad_Click(object sender, EventArgs e)
        {
            try
            {
                string Busq = Convert.ToString(comboBoxBusqCiudad.SelectedItem);
                this.consClientexCiudadTableAdapter.Fill(this.autos72DataSet.ConsClientexCiudad, Busq);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            consClientexCiudadDataGridView.Visible = true;
            insClienteDataGridView.Visible = false;
            consClientesDataGridView.Visible = false;
            consClienteXidDataGridView.Visible = false;
            elimClienteDataGridView.Visible = false;
        }

        private void btnBuscarXid_Click(object sender, EventArgs e)
        {
            try
            {
                int Busq = Convert.ToInt32(txtIdentBusq.Text);
                this.consClienteXidTableAdapter.Fill(this.autos72DataSet.ConsClienteXid, Busq);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            
            consClienteXidDataGridView.Visible = true;
            insClienteDataGridView.Visible = false;
            consClientesDataGridView.Visible = false;
            consClientexCiudadDataGridView.Visible = false;
            elimClienteDataGridView.Visible = false;
        }
        private void btnElimCliente_Click(object sender, EventArgs e)
        {
            elimClienteDataGridView.Visible = false;
            consClienteXidDataGridView.Visible = true;
            insClienteDataGridView.Visible = false;
            consClientesDataGridView.Visible = false;
            consClientexCiudadDataGridView.Visible = false;
            try
            {
                int idCliente = Convert.ToInt32(TxtElimCliente.Text);
                this.consClienteXidTableAdapter.Fill(this.autos72DataSet.ConsClienteXid, idCliente);
                DialogResult Dlg = MessageBox.Show("Desea borrar este contacto?", "Borrar Contacto", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (Dlg == DialogResult.Yes)
                {
                    this.elimClienteTableAdapter.Fill(this.autos72DataSet.ElimCliente, TxtElimCliente.Text);
                    elimClienteDataGridView.Visible = false;
                    consClienteXidDataGridView.Visible = false;
                    insClienteDataGridView.Visible = false;
                    consClientesDataGridView.Visible = true;
                    consClientexCiudadDataGridView.Visible = false;
                    TxtElimCliente.Clear();
                }
                else
                {
                    this.consClienteXidTableAdapter.Fill(this.autos72DataSet.ConsClienteXid, idCliente);
                    elimClienteDataGridView.Visible = false;
                    consClienteXidDataGridView.Visible = false;
                    insClienteDataGridView.Visible = false;
                    consClientesDataGridView.Visible = true;
                    consClientexCiudadDataGridView.Visible = false;
                    TxtElimCliente.Clear();
                }
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
