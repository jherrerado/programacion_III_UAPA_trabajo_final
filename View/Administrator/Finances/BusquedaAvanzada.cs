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
	public partial class BusquedaAvanzada : Form
	{
		FindControllers buquedaAvanzadaController = new FindControllers();
		public BusquedaAvanzada()
		{
			InitializeComponent();
		}

		private void BusquedaAvanzada_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			// Buscar
			dgv_facturas.DataSource = buquedaAvanzadaController.GetFromDB($"SELECT f.ID_FAC, emp.NOM_EMP, cli.NOM_CLI, \r\n       cli.RNC_CLI, empr.ESL_EMPR, empr.TEL_EMPR \r\nFROM facturas f \r\nLEFT JOIN empleados emp ON f.ID_EMP = emp.ID_EMP \r\nLEFT JOIN clientes cli ON f.ID_CLI = cli.ID_CLI \r\nLEFT JOIN empresas empr ON f.ID_EMPR = empr.ID_EMPR\r\nWHERE cli.RNC_CLI = '{txt_buscar_ced.Text}';");
		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void button3_Click(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void button3_Click_1(object sender, EventArgs e)
		{
			dgv_det_facturas.DataSource = buquedaAvanzadaController.GetFromDB($"SELECT df.ID_DET_FAC AS CODIGO, art.DES_ART AS ARTICULO, df.SUB_DET_FAC AS SUBTOTAL, df.CAN_ART_DET_FAC AS CANTIDAD, df.IMP_DET_FAC AS IMPUESTO, df.DES_DET_FAC AS DESCUENTO, df.TOT_DET_FAC AS TOTAL\r\nFROM detallEs_facturas df\r\nLEFT JOIN ARTICULOS art ON df.ID_ART = art.ID_ART WHERE df.ID_FAC = '{txt_buscar_det_fac.Text}';");
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		private void txt_buscar_det_fac_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
