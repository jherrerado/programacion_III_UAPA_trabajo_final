using MySql.Data.MySqlClient;
using Org.BouncyCastle.Bcpg.OpenPgp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using YHDesign_project.Model.Data;

namespace YHDesign_project.Controller
{
	class AddData
	{
		DbConnection db = new DbConnection();
		public bool AddFactura(
			string idFactura,
			string idEmpleados,
			string idCliente,
			string idEmpresa,
			string? idCotizacion,
			string? idDeuda,
			string estadoFactura,
			string fechaFactura
			)
		{
			// agregar factura
			string query = "INSERT INTO facturas (" +
				"ID_FAC, " +
				"ID_EMP, " +
				"ID_COT," +
				"ID_DEU," +
				"ID_CLI," +
				"ID_EMPR," +
				"EST_FAC," +
				"FEC_FAC)" +
				"VALUES (" +
				"@idFactura," +
				"@idEmpleados," +
				"@idCotizacion," +
				"@idDeuda," +
				"@idCliente," +
				"@idEmpresa," +
				"@estadoFactura," +
				"@fechaFactura)";

			using (MySqlConnection connection = db.GetConnection())
			{
				try
				{
					MySqlCommand cmd = new MySqlCommand(query, connection);
					cmd.Parameters.AddWithValue("@idFactura", idFactura);
					cmd.Parameters.AddWithValue("@idEmpleados", idEmpleados);
					cmd.Parameters.AddWithValue("@idCliente", idCliente);
					cmd.Parameters.AddWithValue("@idEmpresa", idEmpresa);
					cmd.Parameters.AddWithValue("@idCotizacion", idCotizacion);
					cmd.Parameters.AddWithValue("@idDeuda", idDeuda);
					cmd.Parameters.AddWithValue("@estadoFactura", estadoFactura);
					cmd.Parameters.AddWithValue("@fechaFactura", fechaFactura);
					cmd.ExecuteNonQuery();
					connection.Close();
					return true;
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex.Message);
					return false;
				}
			}
		}

		public bool AddCotizacion(
			string idCotizacion,
			string fechaCaducidad,
			string estadoCotizacion
			)
		{
			string query;

			// agregar cotizacion
			using (MySqlConnection connection = db.GetConnection())
			{
				try
				{
					query = "INSERT INTO cotizaciones (" +
						"ID_COT, " +
						"FEC_CAD_COT, " +
						"EST_COT" +
						")" +
						"VALUES (" +
						"@idCotizacion," +
						"@fechaCaducidad," +
						"@estadoCotizacion" +
						");";
					MySqlCommand cmd = new MySqlCommand(query, connection);
					cmd.Parameters.AddWithValue("@idCotizacion", idCotizacion);
					cmd.Parameters.AddWithValue("@fechaCaducidad", fechaCaducidad);
					cmd.Parameters.AddWithValue("@estadoCotizacion", estadoCotizacion);
					cmd.ExecuteNonQuery();
					connection.Close();
					return true;
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex.Message);
					return false;
				}
			}
		}

		public bool AddDeuda(
			string idDeuda,
			string estadoDeuda,
			string FechaLimite
			)
		{
			string query;
			// agregar deuda
			using (MySqlConnection connection = db.GetConnection())
			{
				try
				{
					query = "INSERT INTO deudas (" +
						"ID_DEU, " +
						"EST_DEU, " +
						"FEC_LIM_PAG_DEU" +
						")" +
						"VALUES (" +
						"@idDeuda," +
						"@estadoDeuda," +
						"@fechaLimite" +
						");";
					MySqlCommand cmd = new MySqlCommand(query, connection);
					cmd.Parameters.AddWithValue("@idDeuda", idDeuda);
					cmd.Parameters.AddWithValue("@estadoDeuda", estadoDeuda);
					cmd.Parameters.AddWithValue("@fechaLimite", FechaLimite);
					cmd.ExecuteNonQuery();
					connection.Close();
					return true;
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex.Message);
					return false;
				}
			}
		}

		public bool AddPedidos(
			string idPedido,
			DateTime fechaAceptacionPedido,
			DateTime fechaEntregaPedido,
			string estadoPedido,
			string comentario,
			string idDetalleFactura
			)
		{
			string query;
			// agregar pedido
			using (MySqlConnection connection = db.GetConnection())
			{
				try
				{
					query = "INSERT INTO pedidos (" +
						"ID_PED, " +
						"FEC_ACE_PED, " +
						"FEC_ENT_PED, " +
						"EST_PED, " +
						"COM_PED, " +
						"ID_DET_FAC" +
						")" +
						"VALUES (" +
						"@idPedido," +
						"@fechaAceptacionPedido," +
						"@fechaEntregaPedido," +
						"@estadoPedido," +
						"@comentario," +
						"@idDetalleFactura" +
						");";
					MySqlCommand cmd = new MySqlCommand(query, connection);
					cmd.Parameters.AddWithValue("@idPedido", idPedido);
					cmd.Parameters.AddWithValue("@fechaAceptacionPedido", fechaAceptacionPedido);
					cmd.Parameters.AddWithValue("@fechaEntregaPedido", fechaEntregaPedido);
					cmd.Parameters.AddWithValue("@estadoPedido", estadoPedido);
					cmd.Parameters.AddWithValue("@comentario", comentario);
					cmd.Parameters.AddWithValue("@idDetalleFactura", idDetalleFactura);
					cmd.ExecuteNonQuery();
					connection.Close();
					return true;
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex.Message);
					return false;
				}
			}
		}


		public bool AddDetalleFactura(
			string idDetalleFactura,
			string idArticulo,
			string? devolucion,
			string idFactura,
			string cantidad,
			decimal descuento,
			decimal impuesto,
			string precioUnitario,
			string? usuario
			)
		{

			decimal impuestoData = impuesto * (Convert.ToDecimal(precioUnitario) * Convert.ToDecimal(cantidad));
			decimal descuentoData = (descuento * Convert.ToDecimal(precioUnitario));
			decimal total = (Convert.ToDecimal(precioUnitario) * Convert.ToDecimal(cantidad)) - descuentoData + impuestoData;


			// agregar detalle factura
			string query = "INSERT INTO detalles_facturas (" +
				"ID_DET_FAC, " +
				"DEV_DET_FAC, " +
				"ID_FAC, " +
				"ID_ART, " +
				"CAN_ART_DET_FAC, " +
				"SUB_DET_FAC, " +
				"IMP_DET_FAC, " +
				"DES_DET_FAC, " +
				"TOT_DET_FAC," +
				"USU_DET_FAC," +
				"EST_DET_FAC)" +
				"VALUES (" +
				"@idDetalleFactura," +
				"@devolucion," +
				"@idFactura," +
				"@idArticulo," +
				"@cantidad," +
				"@subtotal," +
				"@impuesto," +
				"@descuento," +
				"@total," +
				"@usuDetFac, " +
				"'SIN INICIAR'" +
				");";
			using (MySqlConnection connection = db.GetConnection())
			{
				try
				{
					MySqlCommand cmd = new MySqlCommand(query, connection);
					cmd.Parameters.AddWithValue("@idDetalleFactura", idDetalleFactura);
					cmd.Parameters.AddWithValue("@idArticulo", idArticulo);
					cmd.Parameters.AddWithValue("@devolucion", devolucion);
					cmd.Parameters.AddWithValue("@idFactura", idFactura);
					cmd.Parameters.AddWithValue("@cantidad", cantidad);
					cmd.Parameters.AddWithValue("@descuento", descuentoData);
					cmd.Parameters.AddWithValue("@impuesto", impuestoData);
					cmd.Parameters.AddWithValue("@subtotal", precioUnitario);
					cmd.Parameters.AddWithValue("@total", total);
					cmd.Parameters.AddWithValue("@usuDetFac", usuario);
					cmd.ExecuteNonQuery();
					connection.Close();
					return true;
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex.Message);
					return false;
				}
			}

		}

		public bool AddGastos(
			string notaGas,
			string descripcionGas,
			string cantidadGas,
			string precioGas,
			string totalGas
			)
		{
			// agregar gas
			string query = "INSERT INTO gas (" +
					"NOT_GAS, " +
					"DES_GAS," +
					"CAN_GAS," +
					"PRE_GAS," +
					"TOT_GAS" +
					")" +
					"VALUES (" +
					"@idGas," +
					"@notaGas," +
					"@descripcionGas," +
					"@cantidadGas," +
					"@precioGas," +
					"@totalGas)";
			using (MySqlConnection connection = db.GetConnection())
			{
				try
				{
					MySqlCommand cmd = new MySqlCommand(query, connection);
					cmd.Parameters.AddWithValue("@notaGas", notaGas);
					cmd.Parameters.AddWithValue("@descripcionGas", descripcionGas);
					cmd.Parameters.AddWithValue("@cantidadGas", cantidadGas);
					cmd.Parameters.AddWithValue("@precioGas", precioGas);
					cmd.Parameters.AddWithValue("@totalGas", totalGas);
					cmd.ExecuteNonQuery();
					connection.Close();
					return true;
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex.Message);
					return false;
				}
			}
		}
	}
}
