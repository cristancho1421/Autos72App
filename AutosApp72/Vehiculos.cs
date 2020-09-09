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
    public partial class Vehiculos : Form
    {
        public Vehiculos()
        {
            InitializeComponent();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {


        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {            
            try
            {
                string Busq = Convert.ToString(marcacomboBox.SelectedItem);
                this.insVehiculoTableAdapter.Fill(this.autos72DataSet.InsVehiculo, Busq, new System.Nullable<int>(((int)(System.Convert.ChangeType(modeloTextBox.Text, typeof(int))))), lineaTextBox.Text, descripcionTextBox.Text, precio_NetoTextBox.Text, precio_TotalTextBox.Text);
                this.consVehiculoTableAdapter.Fill(this.autos72DataSet.ConsVehiculo);
                modeloTextBox.Clear(); lineaTextBox.Clear(); precio_NetoTextBox.Clear(); precio_TotalTextBox.Clear(); marcacomboBox.Text = "";
                insVehiculoDataGridView.Visible = true;
                consVehXMarcaDataGridView.Visible = false;
                consVehiculoDataGridView.Visible = false;
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

        private void precio_NetoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                string Busq = Convert.ToString(comboBox1.SelectedItem);
                this.consVehXMarcaTableAdapter.Fill(this.autos72DataSet.ConsVehXMarca, Busq);
                insVehiculoDataGridView.Visible = false;
                consVehXMarcaDataGridView.Visible = true;
                consVehiculoDataGridView.Visible = false;
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void Vehiculos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'autos72DataSet.ConsVehiculo' Puede moverla o quitarla según sea necesario.
            this.consVehiculoTableAdapter.Fill(this.autos72DataSet.ConsVehiculo);

        }

        private void descripcionTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.consVehiculoTableAdapter.Fill(this.autos72DataSet.ConsVehiculo);
            insVehiculoDataGridView.Visible = false;
            consVehXMarcaDataGridView.Visible = false;
            consVehiculoDataGridView.Visible = true;
        }
    }
}
