using MySql.Data.MySqlClient;
using Mysqlx.Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YHDesign_project.Model.Data;

namespace YHDesign_project.Controller
{
	class DeleteData
	{
		DbConnection db = new DbConnection();
		public bool DeleteDetallefactura(string idDetallesFacturas)
		{
			// Eliminar detalle de factura
			string query = "DELETE FROM detalles_facturas WHERE ID_DET_FAC = @IdDetallesFacturas";
			using (MySqlConnection connection = db.GetConnection())
			{
				try
				{
					MySqlCommand cmd = new MySqlCommand(query, connection);
					cmd.Parameters.AddWithValue("@IdDetallesFacturas", idDetallesFacturas);
					cmd.ExecuteNonQuery();
					return true;
				}
				catch (Exception ex)
				{
					Console.Write(ex.Message);
					return false;
				}
			}
		}
	}
}
