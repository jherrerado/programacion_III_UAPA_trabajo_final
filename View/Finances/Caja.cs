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
using YHDesign_project.View.Login;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace YHDesign_project.View.Administrator.Finances
{
	public partial class Caja : Form
	{
		private int codigoDetalleFacturaBase;
		private int filas;
		private int codigoFactura;
		private string idEmpleado;
		private string idCliente;
		private string idEmpresa;
		private int idCotizacion;
		private int idDeuda;
		private int idPedido;
		private decimal impuesto;
		private decimal descuento;
		private decimal primerPago;
		private decimal costoPie;
		private UpdateData updateData;
		public Caja()
		{
			InitializeComponent();
			DataTable dt = new DataTable();
			FindControllers valorBase = new FindControllers();
			updateData = new UpdateData();

			filas = 0; // valor de la filas de configuracion

			dt = valorBase.GetFromDB("SELECT * FROM configuracion");

			codigoDetalleFacturaBase = (int)dt.Rows[filas]["VAL_BAS_DET_FAC"];
			codigoFactura = (int)dt.Rows[filas]["VAL_BAS_FAC"];
			idCotizacion = (int)dt.Rows[filas]["VAL_BAS_COT"];
			idDeuda = (int)dt.Rows[filas]["VAL_BAS_DEU"];
			idPedido = (int)dt.Rows[filas]["VAL_BAS_PED"];

			impuesto = (decimal)dt.Rows[filas]["POR_IMP"];
			descuento = (decimal)dt.Rows[filas]["POR_DES"];
			primerPago = (decimal)dt.Rows[filas]["POR_PRI_PAG"];


			// --------------------------------------------------------------
			// PUDE SER QUE ESTE CODIGO SE CAMBIE A OTRO ARCHIVO PARA MEJORAR LA ORGANIZACION

			costoPie = (decimal)dt.Rows[filas]["COST_PIE"];


			// --------------------------------------------------------------
		}

		// =====================================================================

		private void AddDataFactura(string estadoFactura, string codCotizacion, string? codDeuda)
		{
			AddData addData = new AddData();
			addData.AddFactura(
				$"FAC{codigoFactura}",
				idEmpleado,
				idCliente,
				idEmpresa,
				codCotizacion,
				codDeuda,
				estadoFactura,
				DateTime.Now.ToString("dd/mm/yyyy hh:mm:ss")
			);
		}
		public void UpdateFactura(string estadoFactura, string codigoFactura)
		{
			
			UpdateData updateData = new UpdateData();
			updateData.UpdateFactura(
				codigoFactura,
				idEmpleado,
				idCliente,
				idEmpresa,
				null,
				null,
				estadoFactura
			);
		}

		private void UpdateFactura(string estadoFactura, string? codCotizacion, string? codDeuda)
		{
			UpdateData updateData = new UpdateData();
			updateData.UpdateFactura(
				$"FAC{codigoFactura}",
				idEmpleado,
				idCliente,
				idEmpresa,
				codCotizacion,
				codDeuda,
				estadoFactura
			);
		}
		// =====================================================================

		private void LimpiarDetallesFacturas()
		{

			txt_articulo.Text = "";
			nud_cantidad.Value = 0;
			nud_subTotal.Value = 0;
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void button5_Click(object sender, EventArgs e)
		{

		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			FindControllers find = new FindControllers();
			DataTable dt = new DataTable();
			dt = find.GetFromDB("SELECT * FROM empleados WHERE NOM_EMP = '" + cmb_empleados.SelectedItem.ToString() + "'");
			foreach (DataRow row in dt.Rows)
			{
				this.idEmpleado = row["ID_EMP"].ToString();
			}
		}

		private void label7_Click(object sender, EventArgs e)
		{

		}

		private void label8_Click(object sender, EventArgs e)
		{

		}

		private void groupBox3_Enter(object sender, EventArgs e)
		{

		}

		private void label12_Click(object sender, EventArgs e)
		{

		}

		private void button4_Click(object sender, EventArgs e)
		{

		}

		private void button6_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			codigoDetalleFacturaBase++;
			string idDetalleFactura = $"DFAC{codigoDetalleFacturaBase}";
			FindControllers find = new FindControllers();
			AddData addData = new AddData();

			addData.AddDetalleFactura(
					idDetalleFactura,
					txt_articulo.Text,
					null,
					$"FAC{codigoFactura}",
					nud_cantidad.Value.ToString(),
					0,
					impuesto,
					nud_subTotal.Value.ToString(),
					null
			);

			dgv_detalle_factura.DataSource = find.GetFromDB($"SELECT ID_DET_FAC AS 'DETALLES FACTURAS', DEV_DET_FAC AS DEVOLUCION, ID_FAC AS FACTURA, ID_ART AS ARTICULO, CAN_ART_DET_FAC AS CANTIDAD, SUB_DET_FAC as SUBTOTAL, IMP_DET_FAC AS IMPUESTO, DES_DET_FAC AS DESCUENTO FROM detalles_facturas WHERE ID_FAC = 'FAC{codigoFactura}';");
			;

			this.LimpiarDetallesFacturas();

			updateData.UpdateConfiguracion(
				2,
				descuento,
				costoPie,
				codigoDetalleFacturaBase,
				codigoFactura,
				idCotizacion,
				idDeuda,
				primerPago,
				impuesto,
				idPedido
			);
		}

		private void button7_Click(object sender, EventArgs e)
		{

		}

		private void Limpiar_Click(object sender, EventArgs e)
		{
			this.LimpiarDetallesFacturas();
		}

		private void groupBox2_Enter(object sender, EventArgs e)
		{

		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void AgregarFactura_Load(object sender, EventArgs e)
		{

			rb_fatura.Checked = true;




			DataTable dtEmpleados = new DataTable();
			DataTable dtClientes = new DataTable();
			DataTable dtEmpresa = new DataTable();

			FindControllers empleados = new FindControllers();
			lbl_cod_factura.Text = $"FAC{codigoFactura}";
			dtEmpleados = empleados.GetFromDB("SELECT * FROM empleados");
			dtClientes = empleados.GetFromDB("SELECT * FROM clientes");
			dtEmpresa = empleados.GetFromDB("SELECT * FROM empresas");

			foreach (DataRow row in dtEmpleados.Rows) { cmb_empleados.Items.Add(row["NOM_EMP"].ToString()); }
			foreach (DataRow row in dtClientes.Rows) { cmb_clientes.Items.Add(row["NOM_CLI"].ToString()); }
			foreach (DataRow row in dtEmpresa.Rows) { idEmpresa = row["ID_EMPR"].ToString(); }

			this.AddDataFactura("ACTIVA", null, null);
		}

		private void cmb_clientes_SelectedIndexChanged(object sender, EventArgs e)
		{
			// seleccionar a los clientes
			FindControllers find = new FindControllers();
			DataTable dt = new DataTable();
			dt = find.GetFromDB("SELECT * FROM clientes WHERE NOM_CLI = '" + cmb_clientes.SelectedItem.ToString() + "'");
			foreach (DataRow row in dt.Rows)
			{
				lbl_RNC_CEDULA.Text = row["RNC_CLI"].ToString();
				this.idCliente = row["ID_CLI"].ToString();
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			AddData addData = new AddData();
			FindControllers find = new FindControllers();
			this.UpdateFactura("PAGADO", null, null);


			DataTable subtotal = find.GetFromDB($"SELECT SUM(SUB_DET_FAC) AS SUBTOTAL FROM detalles_facturas WHERE ID_FAC = '{lbl_cod_factura.Text}'");
			DataTable calculoImpuesto = find.GetFromDB($"SELECT SUM(IMP_DET_FAC) AS IMPUESTO FROM detalles_facturas WHERE ID_FAC = '{lbl_cod_factura.Text}'");
			DataTable total = find.GetFromDB($"SELECT SUM(TOT_DET_FAC) AS TOTAL FROM detalles_facturas WHERE ID_FAC = '{lbl_cod_factura.Text}'");

			this.Hide();
			//calculo.Show();
			codigoFactura++;

			updateData.UpdateConfiguracion(
				2,
				descuento,
				costoPie,
				codigoDetalleFacturaBase,
				codigoFactura,
				idCotizacion,
				idDeuda,
				primerPago,
				impuesto,
				idPedido
			);

		}

		private void label18_Click(object sender, EventArgs e)
		{

		}

		private void label22_Click(object sender, EventArgs e)
		{

		}

		private void btn_enviar_cotizacion_Click(object sender, EventArgs e)
		{
			AddData addData = new AddData();
			bool saveCotizacion = addData.AddCotizacion(
				$"COT{idCotizacion}",
				dtp_fecha_caducidad.Value.ToString(),
				"ACTIVA"
			);
			if (saveCotizacion)
			{
				this.UpdateFactura("COTIZACION", $"COT{idCotizacion}", null);
				this.Hide();
				idCotizacion++;

				updateData.UpdateConfiguracion(
					2,
					descuento,
					costoPie,
					codigoDetalleFacturaBase,
					codigoFactura,
					idCotizacion,
					idDeuda,
					primerPago,
					impuesto,
					idPedido
				);

			}
			else
			{
				MessageBox.Show("Algo esta fallando, porfavor verifica que todos los datos estan bien," +
					"si llama al soporte");
			}
		}

		private void btn_enviear_deuda_Click(object sender, EventArgs e)
		{
			idDeuda++;
			AddData addData = new AddData();
			bool saveDeuda = addData.AddDeuda(
				$"DEU{idDeuda}",
				dtp_limite_pago.Value.ToString(),
				"ACTIVA"
			);

			if (saveDeuda)
			{
				MessageBox.Show($"{saveDeuda}");
				this.UpdateFactura("DEUDA", null, $"DEU{idDeuda}");
				this.Hide();
				idDeuda++;
				this.updateData.UpdateConfiguracion(
					2,
					descuento,
					costoPie,
					codigoDetalleFacturaBase,
					codigoFactura,
					idCotizacion,
					idDeuda,
					primerPago,
					impuesto,
					idPedido
				);
			}
			else
			{
				MessageBox.Show("Algo esta fallando, porfavor verifica que todos los datos estan bien, si llama al soporte");
			}
		}

		private void button9_Click(object sender, EventArgs e)
		{
			this.UpdateFactura("PEDIDO", null, null);
			codigoFactura++;
			this.Hide();
			idPedido++;
			this.updateData.UpdateConfiguracion(
				2,
				descuento,
				costoPie,
				codigoDetalleFacturaBase,
				codigoFactura,
				idCotizacion,
				idDeuda,
				primerPago,
				impuesto,
				idPedido
			);
		}

		private void rb_fatura_CheckedChanged(object sender, EventArgs e)
		{
			gb_cotizacion.Visible = false;
			gb_deuda.Visible = false;
			btn_enviar_cotizacion.Visible = false;
			btn_enviear_deuda.Visible = false;
			btn_primer_pago.Visible = true;
			btn_pago_total.Visible = true;
		}

		private void rb_cotizacion_CheckedChanged(object sender, EventArgs e)
		{
			gb_cotizacion.Visible = true;
			gb_deuda.Visible = false;
			btn_enviar_cotizacion.Visible = true;
			btn_enviear_deuda.Visible = false;
			btn_primer_pago.Visible = false;
			btn_pago_total.Visible = false;
		}

		private void rb_deuda_CheckedChanged(object sender, EventArgs e)
		{
			gb_deuda.Visible = true;
			gb_cotizacion.Visible = false;

			btn_enviar_cotizacion.Visible = false;
			btn_enviear_deuda.Visible = true;
			btn_primer_pago.Visible = false;
			btn_pago_total.Visible = false;
		}

		private void button8_Click(object sender, EventArgs e)
		{
			IniciarSesion iniciarSesion = new IniciarSesion();
			iniciarSesion.Show();
			this.Hide();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			ActulizarDetalesFacturasAgregar actualizar = new ActulizarDetalesFacturasAgregar();
			actualizar.Show();
		}
	}
}
