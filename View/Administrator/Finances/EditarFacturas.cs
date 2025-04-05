using Org.BouncyCastle.Tls.Crypto;
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
	public partial class EditarFacturas : Form
	{
		public EditarFacturas()
		{
			InitializeComponent();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			DeleteData delete = new DeleteData();
			FindControllers find = new FindControllers();
			delete.DeleteDetallefactura(txt_detalles_facturas_delete.Text);
			dgv_detalles_facturas.DataSource = find.GetFromDB($"SELECT * FROM detalles_facturas WHERE ID_FAC = '{txt_facturas.Text}';");
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			FindControllers find = new FindControllers();
			dgv_facturas.DataSource = find.GetFromDB($"SELECT * FROM facturas WHERE ID_FAC = '{txt_facturas.Text}' && EST_FAC != 'DESACTIVAR';");
			dgv_detalles_facturas.DataSource = find.GetFromDB($"SELECT df.ID_DET_FAC AS CODIGO, art.DES_ART AS ARTICULO, df.SUB_DET_FAC AS SUBTOTAL, df.IMP_DET_FAC AS IMPUESTO, df.DES_DET_FAC AS DESCUENTO, df.TOT_DET_FAC AS TOTAL\r\nFROM detallEs_facturas df\r\nLEFT JOIN ARTICULOS art ON df.ID_ART = art.ID_ART\r\nLEFT JOIN facturas f ON df.ID_FAC = f.ID_FAC\r\nWHERE df.ID_FAC = '{txt_facturas.Text}' && f.EST_FAC != 'DESACTIVAR';");
		}

		private void button5_Click(object sender, EventArgs e)
		{
			AgregarFactura agregarFactura = new AgregarFactura();
			agregarFactura.UpdateFactura("PAGADO", txt_facturas.Text);
			MessageBox.Show("Se ha generado el pagos satisfactoriamente");
			this.Hide();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			AgregarFactura agregarFactura = new AgregarFactura();
			agregarFactura.UpdateFactura("PEDIDO", txt_facturas.Text);
			MessageBox.Show("Se ha generado el pedidos satisfactoriamente");
			this.Hide();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Hide();
			MessageBox.Show("La factura ha sido actualizada");
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Hide();
		}
	}
}
