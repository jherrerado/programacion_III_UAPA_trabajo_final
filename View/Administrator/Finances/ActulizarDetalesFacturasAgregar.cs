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
	public partial class ActulizarDetalesFacturasAgregar : Form
	{
		public ActulizarDetalesFacturasAgregar()
		{
			InitializeComponent();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void btn_actualizar_Click(object sender, EventArgs e)
		{
			UpdateData update = new UpdateData();
			update.UpdateDetalleFactura(txt_codigo_det_fac.Text, txt_articulo.Text, Convert.ToInt32(nud_cantidad.Value), nud_subTotal.Value);
			MessageBox.Show("Detalle de factura actualizado");
			this.Hide();
		}
	}
}
