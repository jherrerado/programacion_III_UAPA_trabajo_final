using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YHDesign_project.Controller;

namespace YHDesign_project.View.Administrator.Finances
{
	public partial class EliminarFacturas : Form
	{
		public EliminarFacturas()
		{
			InitializeComponent();
		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			AgregarFactura delete = new AgregarFactura();
			delete.UpdateFactura("DESACTIVAR", txt_eliminar.Text);
			MessageBox.Show("Se ha eliminado satisfactoria mente");
			this.Hide();
		}

		private void txt_eliminar_TextChanged(object sender, EventArgs e)
		{
			FindControllers find = new FindControllers();
			dgv_eliminar_facturas.DataSource = find.GetFromDB($"SELECT * FROM facturas WHERE ID_FAC = '{txt_eliminar.Text}' && EST_FAC != 'DESACTIVAR'");
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Hide();
		}
	}
}
