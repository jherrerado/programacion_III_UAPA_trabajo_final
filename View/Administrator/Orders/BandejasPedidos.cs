using Mysqlx.Crud;
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

namespace YHDesign_project.View.Administrator.Orders
{
	public partial class BandejasPedidos : Form
	{
		public BandejasPedidos()
		{
			InitializeComponent();
		}

		private void label5_Click(object sender, EventArgs e)
		{

		}

		private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
		{

		}

		private void BandejasPedidos_Load(object sender, EventArgs e)
		{
			FindControllers find = new FindControllers();
			// -----------------------------------------------------------------
			// AQUI VA LA CONFIGURACIÓN DEL COMBO BOX DE USUARIOS (CORREGIDA)
			DataTable dt = new DataTable();
			dt = find.GetFromDB("SELECT ID_EMP, NOM_EMP FROM empleados;");

			// En lugar de llenar manualmente los Items, configura el ComboBox con DataSource
			cb_usuario.DataSource = dt;
			cb_usuario.DisplayMember = "NOM_EMP";  // Lo que se muestra al usuario
			cb_usuario.ValueMember = "ID_EMP";     // El valor que se recupera con SelectedValue
																						 // -----------------------------------------------------------------

			dgv_facturas_pedidos.DataSource = find.GetFromDB("SELECT ID_FAC AS ID, EST_FAC AS DISPONIBLE FROM facturas WHERE EST_FAC = 'PEDIDO';");
			dgv_det_fac_pedidos.DataSource = find.GetFromDB("SELECT df.ID_DET_FAC AS CODIGO, art.DES_ART AS ARTICULO, df.ID_FAC\r\nFROM detallEs_facturas df\r\nLEFT JOIN ARTICULOS art ON df.ID_ART = art.ID_ART\r\nLEFT JOIN facturas f ON df.ID_FAC = f.ID_FAC\r\nWHERE f.EST_FAC = 'PEDIDO' AND df.EST_DET_FAC = 'SIN INICIAR';");
			dgv_pedidos_activos.DataSource = find.GetFromDB("SELECT df.ID_DET_FAC AS CODIGO, art.DES_ART AS ARTICULO, df.ID_FAC AS FACTURA, emp.NOM_EMP AS USUARIO\r\nFROM detallEs_facturas df\r\nLEFT JOIN ARTICULOS art ON df.ID_ART = art.ID_ART\r\nLEFT JOIN facturas f ON df.ID_FAC = f.ID_FAC\r\nLEFT JOIN empleados emp ON df.USU_DET_FAC = emp.ID_EMP\r\nWHERE f.EST_FAC = 'PEDIDO' AND df.EST_DET_FAC = 'PROGRESO';");
			rb_progreso.Checked = true;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			UpdateData update = new UpdateData();
			FindControllers find = new FindControllers();
			Pedidos pedidos = new Pedidos();
			string estadoPedidos = "";

			if (rb_progreso.Checked) estadoPedidos = "PROGRESO";
			else if (rb_hecho.Checked) estadoPedidos = "HECHO";
			else estadoPedidos = "SIN INICIAR";

			// Verificar que cb_usuario.SelectedValue no sea null
			if (cb_usuario.SelectedValue != null)
			{
				update.UpdateEstadoDetalleFactura(txt_codigo_pedidos.Text, cb_usuario.SelectedValue.ToString(), estadoPedidos);
				MessageBox.Show("Se ha actualizado el estado del pedido correctamente.");
			}
			else
			{
				// Mostrar mensaje de error o manejar el caso cuando no hay usuario seleccionado
				MessageBox.Show("Por favor seleccione un usuario antes de continuar.");
			}
			this.Hide();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Hide();
		}
	}
}
