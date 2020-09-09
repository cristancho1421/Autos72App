using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutosApp72
{
    public partial class Ventas : Form
    {
        public Ventas()
        {
            InitializeComponent();
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'autos72DataSet.Venta' Puede moverla o quitarla según sea necesario.
            this.ventaTableAdapter.Fill(this.autos72DataSet.Venta);
            // TODO: esta línea de código carga datos en la tabla 'autos72DataSet.Cliente' Puede moverla o quitarla según sea necesario.
            this.clienteTableAdapter.Fill(this.autos72DataSet.Cliente);
            // TODO: esta línea de código carga datos en la tabla 'autos72DataSet.ConsVentas' Puede moverla o quitarla según sea necesario.
            this.consVentasTableAdapter.Fill(this.autos72DataSet.ConsVentas);
            
        }

        private void btnAsignar_Click(object sender, EventArgs e)
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


        private void btnAsingarVeh_Click(object sender, EventArgs e)
        {
            try
            {
                string linea = Convert.ToString(comboBoxLinea.SelectedItem);
                this.consVehiculoMarcaTableAdapter.Fill(this.autos72DataSet.ConsVehiculoMarca, linea);

                this.consColorTableAdapter.Fill(this.autos72DataSet.ConsColor, new System.Nullable<int>(((int)(System.Convert.ChangeType(id_VehiculoTextBox.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btnGuardarVenta_Click(object sender, EventArgs e)
        {
            try
            {
                this.insVentaTableAdapter.Fill(this.autos72DataSet.InsVenta, new System.Nullable<int>(((int)(System.Convert.ChangeType(id_ClienteTextBox.Text, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(id_VehiculoTextBox.Text, typeof(int))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(fecha_ventaDateTimePicker.Value, typeof(System.DateTime))))), colorTextBox.Text);
                this.consVentasTableAdapter.Fill(this.autos72DataSet.ConsVentas);
                TxtidCliente.Clear(); nombreTextBox.Clear(); comboBoxLinea.Text = ""; marcaTextBox.Clear();            
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
                string linea = Convert.ToString(comboBoxLinea.SelectedItem);
                this.consVehiculoMarcaTableAdapter.Fill(this.autos72DataSet.ConsVehiculoMarca, linea);

                this.consColorTableAdapter.Fill(this.autos72DataSet.ConsColor, new System.Nullable<int>(((int)(System.Convert.ChangeType(id_VehiculoTextBox.Text, typeof(int))))));
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
