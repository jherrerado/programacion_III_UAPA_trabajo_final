using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YHDesign_project.Controller;

namespace YHDesign_project.View.Administrator.Orders
{
	public partial class Pedidos : UserControl
	{
		FindControllers find;
		public Pedidos()
		{
			InitializeComponent();
			find = new FindControllers();
		}

		private void Pedidos_Load(object sender, EventArgs e)
		{
			dgv_pedidos.DataSource = find.GetFromDB("SELECT df.ID_DET_FAC AS CODIGO, art.DES_ART AS ARTICULO, df.ID_FAC AS FACTURA, emp.NOM_EMP AS USUARIO\r\nFROM detallEs_facturas df\r\nLEFT JOIN ARTICULOS art ON df.ID_ART = art.ID_ART\r\nLEFT JOIN facturas f ON df.ID_FAC = f.ID_FAC\r\nLEFT JOIN empleados emp ON df.USU_DET_FAC = emp.ID_EMP\r\nWHERE f.EST_FAC = 'PEDIDO' AND df.EST_DET_FAC = 'PROGRESO';");
		}

		private void btn_buscar_Click(object sender, EventArgs e)
		{
		}

		private void btn_crear_Click(object sender, EventArgs e)
		{

		}

		private void btn_actualizar_Click(object sender, EventArgs e)
		{

		}

		private void btn_eliminar_Click(object sender, EventArgs e)
		{

		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			BandejasPedidos bandejas = new BandejasPedidos();
			bandejas.Show();
		}
	}
}
