using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using YHDesign_project.Model.Data;

namespace YHDesign_project.Controller
{
	class UpdateData
	{
		private DbConnection db = new DbConnection();

		public bool UpdateFactura(
				string idFactura,
				string idEmpleados,
				string idCliente,
				string idEmpresa,
				string? idCotizacion,
				string? idDeuda,
				string estadoFactura
		)
		{
			// actualizar factura
			string query = "UPDATE facturas SET " +
											 "ID_EMP = @idEmpleados, " +
											 "ID_COT = @idCotizacion, " +
											 "ID_DEU = @idDeuda, " +
											 "ID_CLI = @idCliente, " +
											 "ID_EMPR = @idEmpresa, " +
											 "EST_FAC = @estadoFactura " +
											 "WHERE ID_FAC = @idFactura";

			using (MySqlConnection connection = db.GetConnection())
			{
				try
				{
					//connection.Open(); // Abrir conexión explícitamente

					MySqlCommand cmd = new MySqlCommand(query, connection);

					cmd.Parameters.AddWithValue("@idFactura", idFactura);
					cmd.Parameters.AddWithValue("@idEmpleados", idEmpleados);
					cmd.Parameters.AddWithValue("@idCliente", idCliente);
					cmd.Parameters.AddWithValue("@idEmpresa", idEmpresa);

					// Manejo adecuado para valores nulos
					if (idCotizacion == null)
						cmd.Parameters.AddWithValue("@idCotizacion", DBNull.Value);
					else
						cmd.Parameters.AddWithValue("@idCotizacion", idCotizacion);

					if (idDeuda == null)
						cmd.Parameters.AddWithValue("@idDeuda", DBNull.Value);
					else
						cmd.Parameters.AddWithValue("@idDeuda", idDeuda);

					cmd.Parameters.AddWithValue("@estadoFactura", estadoFactura);

					// Verificar si se actualizó alguna fila
					int rowsAffected = cmd.ExecuteNonQuery();
					return rowsAffected > 0;
				}
				catch (Exception ex)
				{
					Console.WriteLine($"Error al actualizar la factura: {ex.Message}");
					return false;
				}
			} // La conexión se cierra automáticamente aquí
		}

		public bool UpdateConfiguracion(
		int idConf,
		decimal porDes,
		decimal costPie,
		decimal valBasDetFac,
		decimal valBasFac,
		decimal valBasCot,
		decimal valBasDeu,
		decimal porPriPag,
		decimal porImp,
		decimal valBasPed
)
		{
			// Consulta SQL para actualizar la configuración
			string query = "UPDATE configuracion SET " +
										 "POR_DES = @porDes, " +
										 "COST_PIE = @costPie, " +
										 "VAL_BAS_DET_FAC = @valBasDetFac, " +
										 "VAL_BAS_FAC = @valBasFac, " +
										 "VAL_BAS_COT = @valBasCot, " +
										 "VAL_BAS_DEU = @valBasDeu, " +
										 "POR_PRI_PAG = @porPriPag, " +
										 "POR_IMP = @porImp, " +
										 "VAL_BAS_PED = @valBasPed " +
										 "WHERE ID_CONF = @idConf";


			using (MySqlConnection connection = db.GetConnection())
			{
				try
				{
					MySqlCommand cmd = new MySqlCommand(query, connection);

					cmd.Parameters.AddWithValue("@idConf", idConf);
					cmd.Parameters.AddWithValue("@costPie", costPie);
					cmd.Parameters.AddWithValue("@valBasDetFac", valBasDetFac);
					cmd.Parameters.AddWithValue("@valBasFac", valBasFac);
					cmd.Parameters.AddWithValue("@valBasCot", valBasCot);
					cmd.Parameters.AddWithValue("@valBasDeu", valBasDeu);
					cmd.Parameters.AddWithValue("@porPriPag", porPriPag);
					cmd.Parameters.AddWithValue("@porImp", porImp);
					cmd.Parameters.AddWithValue("@porDes", porDes);
					cmd.Parameters.AddWithValue("@valBasPed", valBasPed);
					int rowsAffected = cmd.ExecuteNonQuery();
					return rowsAffected > 0;
				}
				catch (Exception ex)
				{
					Console.WriteLine($"Error al actualizar la configuración: {ex.Message}");
					return false;
				}
			}


		}

		public bool UpdateDetalleFactura(
		string idDetFac,
		string idArt,
		int canArtDetFac,
		decimal subDetFac
)
		{
			// Consulta SQL para actualizar solo los 3 campos específicos solicitados
			string query = "UPDATE detalles_facturas SET " +
										 "ID_ART = @idArt, " +
										 "CAN_ART_DET_FAC = @canArtDetFac, " +
										 "SUB_DET_FAC = @subDetFac " +
										 "WHERE ID_DET_FAC = @idDetFac";

			using (MySqlConnection connection = db.GetConnection())
			{
				try
				{
					MySqlCommand cmd = new MySqlCommand(query, connection);
					cmd.Parameters.AddWithValue("@idDetFac", idDetFac);
					cmd.Parameters.AddWithValue("@idArt", idArt);
					cmd.Parameters.AddWithValue("@canArtDetFac", canArtDetFac);
					cmd.Parameters.AddWithValue("@subDetFac", subDetFac);

					int rowsAffected = cmd.ExecuteNonQuery();
					return rowsAffected > 0;
				}
				catch (Exception ex)
				{
					Console.WriteLine($"Error al actualizar los campos del detalle de factura: {ex.Message}");
					return false;
				}
			}
		}

		public bool UpdateEstadoDetalleFactura(
		string idDetFac,
		string usuario,
		string estado
)
		{
			// Consulta SQL para actualizar solo USU_DET_FAC y EST_DET_FAC
			string query = "UPDATE detalles_facturas SET " +
										 "USU_DET_FAC = @usuario, " +
										 "EST_DET_FAC = @estado " +
										 "WHERE ID_DET_FAC = @idDetFac";

			using (MySqlConnection connection = db.GetConnection())
			{
				try
				{
					MySqlCommand cmd = new MySqlCommand(query, connection);
					cmd.Parameters.AddWithValue("@idDetFac", idDetFac);
					cmd.Parameters.AddWithValue("@usuario", usuario);
					cmd.Parameters.AddWithValue("@estado", estado);

					int rowsAffected = cmd.ExecuteNonQuery();
					return rowsAffected > 0;
				}
				catch (Exception ex)
				{
					Console.WriteLine($"Error al actualizar el estado del detalle de factura: {ex.Message}");
					return false;
				}
			}
		}
	}
}
