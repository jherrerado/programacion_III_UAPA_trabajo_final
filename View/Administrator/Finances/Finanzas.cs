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
using YHDesign_project.View.Administrator.Finances;

namespace YHDesign_project.View.Admin.Finances
{
	public partial class Finanzas : UserControl
	{
		FindControllers facturacionController = new FindControllers();
		public Finanzas()
		{
			InitializeComponent();
		}

		private void button2_Click(object sender, EventArgs e)
		{
		}

		private void Finanzas_Load(object sender, EventArgs e)
		{
			lbl_finanzas_title.Text = "Filtrar Facturas: ";
			dtp_entre_segundo_valor.Value = dtp_entre_primer_valor.Value.AddDays(31);
			dgv_finanzas_data.DataSource = facturacionController.GetFromDB($"SELECT f.ID_FAC, emp.NOM_EMP, cli.NOM_CLI, cli.RNC_CLI, empr.ESL_EMPR, empr.TEL_EMPR, f.FEC_FAC " +
				$"\r\nFROM facturas f \r\nleft join empleados emp on f.ID_EMP = emp.ID_EMP \r\nleft join clientes cli on f.ID_CLI = cli.ID_CLI " +
				$"\r\nleft join empresas empr on f.ID_EMPR = empr.ID_EMPR " +
				$"\r\nWHERE FEC_FAC BETWEEN '{dtp_entre_primer_valor.Value.ToShortDateString()}' AND '{dtp_entre_segundo_valor.Value.ToShortDateString()}' AND EST_FAC = 'PAGADO';");
		}

		private void btn_facturacion_Click(object sender, EventArgs e)
		{
			lbl_finanzas_title.Text = "Facturación";
			dgv_finanzas_data.DataSource = facturacionController.GetFromDB("SELECT f.ID_FAC, emp.NOM_EMP, cli.NOM_CLI, " +
				"cli.RNC_CLI, empr.ESL_EMPR, empr.TEL_EMPR, f.FEC_FAC FROM facturas f left join empleados emp " +
				"on f.ID_EMP = emp.ID_EMP left join clientes cli on f.ID_CLI = cli.ID_CLI left join empresas empr " +
				"on f.ID_EMPR = empr.ID_EMPR WHERE f.EST_FAC = \"PAGADO\";");
		}

		private void button1_Click(object sender, EventArgs e)
		{
			lbl_finanzas_title.Text = "Cotizacion";
			dgv_finanzas_data.DataSource = facturacionController.GetFromDB("SELECT f.ID_FAC, emp.NOM_EMP, cli.NOM_CLI, cli.RNC_CLI, empr.ESL_EMPR, empr.TEL_EMPR, cot.FEC_CAD_COT, cot.EST_COT FROM facturas f left join empleados emp on f.ID_EMP = emp.ID_EMP left join clientes cli on f.ID_CLI = cli.ID_CLI left join empresas empr on f.ID_EMPR = empr.ID_EMPR left join cotizaciones cot on f.ID_COT = cot.ID_COT WHERE f.EST_FAC = \"COTIZACION\";");
		}

		private void button4_Click_2(object sender, EventArgs e)
		{
			lbl_finanzas_title.Text = "Deudas";
			dgv_finanzas_data.DataSource = facturacionController.GetFromDB("SELECT f.ID_FAC, emp.NOM_EMP, cli.NOM_CLI, cli.RNC_CLI, empr.ESL_EMPR, empr.TEL_EMPR,\r\n\t\t deu.Fec_LIM_PAG_DEU, deu.EST_DEU\r\nFROM facturas f \r\nleft join empleados emp on f.ID_EMP = emp.ID_EMP \r\nleft join clientes cli on f.ID_CLI = cli.ID_CLI \r\nleft join empresas empr on f.ID_EMPR = empr.ID_EMPR\r\nleft join deudas deu on f.ID_DEU = deu.ID_DEU WHERE f.EST_FAC = \"DEUDA\";");
		}

		private void button7_Click(object sender, EventArgs e)
		{

		}
		private void button6_Click(object sender, EventArgs e)
		{
			BusquedaAvanzada busquedaAvanzada = new BusquedaAvanzada();
			busquedaAvanzada.Show();
		}

		private void button8_Click(object sender, EventArgs e)
		{

		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void button3_Click(object sender, EventArgs e)
		{
			AgregarFactura agregarFactura = new AgregarFactura();
			agregarFactura.Show();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			EditarFacturas editarFacturas = new EditarFacturas();
			editarFacturas.Show();
		}

		private void button7_Click_1(object sender, EventArgs e)
		{
			EliminarFacturas eliminarFacturas = new EliminarFacturas();
			eliminarFacturas.Show();
		}

		private void lbl_finanzas_title_Click(object sender, EventArgs e)
		{

		}

		private void dtp_entre_segundo_valor_ValueChanged(object sender, EventArgs e)
		{

		}

		private void button2_Click_1(object sender, EventArgs e)
		{
			switch (lbl_finanzas_title.Text)
			{
				case "Filtrar Facturas: ":
					dgv_finanzas_data.DataSource = facturacionController.GetFromDB($"SELECT f.ID_FAC, emp.NOM_EMP, cli.NOM_CLI, cli.RNC_CLI, empr.ESL_EMPR, empr.TEL_EMPR, f.FEC_FAC " +
				$"\r\nFROM facturas f \r\nleft join empleados emp on f.ID_EMP = emp.ID_EMP \r\nleft join clientes cli on f.ID_CLI = cli.ID_CLI " +
				$"\r\nleft join empresas empr on f.ID_EMPR = empr.ID_EMPR " +
				$"\r\nWHERE FEC_FAC BETWEEN '{dtp_entre_primer_valor.Value.ToShortDateString()}' AND '{dtp_entre_segundo_valor.Value.ToShortDateString()}' AND EST_FAC = 'PAGADO';");
					break;
				case "Facturación":
					dgv_finanzas_data.DataSource = facturacionController.GetFromDB($"SELECT f.ID_FAC, emp.NOM_EMP, cli.NOM_CLI, cli.RNC_CLI, empr.ESL_EMPR, empr.TEL_EMPR, f.FEC_FAC " +
				$"\r\nFROM facturas f \r\nleft join empleados emp on f.ID_EMP = emp.ID_EMP \r\nleft join clientes cli on f.ID_CLI = cli.ID_CLI " +
				$"\r\nleft join empresas empr on f.ID_EMPR = empr.ID_EMPR " +
				$"\r\nWHERE FEC_FAC BETWEEN '{dtp_entre_primer_valor.Value.ToShortDateString()}' AND '{dtp_entre_segundo_valor.Value.ToShortDateString()}' AND EST_FAC = 'PAGADO';");
					break;
				case "Cotizacion":
					dgv_finanzas_data.DataSource = facturacionController.GetFromDB($"SELECT f.ID_FAC, emp.NOM_EMP, cli.NOM_CLI, cli.RNC_CLI, empr.ESL_EMPR, empr.TEL_EMPR, cot.FEC_CAD_COT, cot.EST_COT " +
						"FROM facturas f left join empleados emp on f.ID_EMP = emp.ID_EMP left join clientes cli on f.ID_CLI = cli.ID_CLI left join empresas empr on f.ID_EMPR = empr.ID_EMPR " +
						"left join cotizaciones cot on f.ID_COT = cot.ID_COT " +
						$"WHERE FEC_FAC BETWEEN '{dtp_entre_primer_valor.Value.ToShortDateString()}' AND '{dtp_entre_segundo_valor.Value.ToShortDateString()}' AND f.EST_FAC = \"COTIZACION\";");
					break;
				case "Deudas":
					dgv_finanzas_data.DataSource = facturacionController.GetFromDB("SELECT f.ID_FAC, emp.NOM_EMP, cli.NOM_CLI, cli.RNC_CLI, empr.ESL_EMPR, empr.TEL_EMPR," +
						"\r\n\t\t deu.Fec_LIM_PAG_DEU, deu.EST_DEU\r\nFROM facturas f \r\nleft join empleados emp on f.ID_EMP = emp.ID_EMP \r\nleft join clientes cli on f.ID_CLI = cli.ID_CLI" +
						" \r\nleft join empresas empr on f.ID_EMPR = empr.ID_EMPR\r\nleft join deudas deu on f.ID_DEU = deu.ID_DEU" +
						$"WHERE FEC_FAC BETWEEN '{dtp_entre_primer_valor.Value.ToShortDateString()}' AND '{dtp_entre_segundo_valor.Value.ToShortDateString()}' AND f.EST_FAC = \"DEUDA\";");
					break;
			}



		}
	}
}
