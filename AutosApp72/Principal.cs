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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBoxClientes_Click(object sender, EventArgs e)
        {
            Clientes Cl = new Clientes();
            Cl.Show();
            this.Hide();
        }

        private void pictureBoxVentas_Click(object sender, EventArgs e)
        {
            Ventas Vt = new Ventas();
            Vt.Show();
            this.Hide();
        }

        private void pictureBoxRevision_Click(object sender, EventArgs e)
        {
            Revisiones Rv = new Revisiones();
            Rv.Show();
            this.Hide();
        }

        private void pictureBoxInventario_Click(object sender, EventArgs e)
        {
            Inventario Inv = new Inventario();
            Inv.Show();
            this.Hide();
        }

        private void pictureBoxVehiculo_Click(object sender, EventArgs e)
        {
            Vehiculos Vh = new Vehiculos();
            Vh.Show();
            this.Hide();
        }
    }
}
