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
    public partial class Inventario : Form
    {
        public Inventario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmPrincipal Pr = new FrmPrincipal();
            Pr.Show();
            this.Hide();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {


        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'autos72DataSet.ConsInventario' Puede moverla o quitarla según sea necesario.
            this.consInventarioTableAdapter.Fill(this.autos72DataSet.ConsInventario);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string estado = Convert.ToString(comboBoxEstado.SelectedItem);
                this.insInventarioTableAdapter.Fill(this.autos72DataSet.InsInventario, id_VehiculoTextBox.Text, placaTextBox.Text, chasisTextBox.Text, colorTextBox.Text, estado);
                this.consInventarioTableAdapter.Fill(this.autos72DataSet.ConsInventario);
                consInvXMarcaDataGridView.Visible = false;
                consInvXEstadoDataGridView1.Visible = false;
                insInventarioDataGridView.Visible = true;
                consInventarioDataGridView.Visible = false;
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }



        private void comboBoxLinea_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string busq = Convert.ToString(comboBoxLinea.SelectedItem);
                this.consVehiculoMarcaTableAdapter.Fill(this.autos72DataSet.ConsVehiculoMarca, busq);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string busq = Convert.ToString(comboBoxBusqEstado.SelectedItem);
                this.consInvXEstadoTableAdapter.Fill(this.autos72DataSet.ConsInvXEstado, busq);
                consInvXMarcaDataGridView.Visible = false;
                consInvXEstadoDataGridView1.Visible = true;
                insInventarioDataGridView.Visible = false;
                consInventarioDataGridView.Visible = false;
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void fillToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
        private void marcacomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string busq = Convert.ToString(marcacomboBox.SelectedItem);
                this.consInvXMarcaTableAdapter.Fill(this.autos72DataSet.ConsInvXMarca, busq);
                consInvXMarcaDataGridView.Visible = true;
                consInvXEstadoDataGridView1.Visible = false;
                insInventarioDataGridView.Visible = false;
                consInventarioDataGridView.Visible = false;
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.consInventarioTableAdapter.Fill(this.autos72DataSet.ConsInventario);
            consInvXMarcaDataGridView.Visible = false;
            consInvXEstadoDataGridView1.Visible = false;
            insInventarioDataGridView.Visible = false;
            consInventarioDataGridView.Visible = true;
        }
    }
}
