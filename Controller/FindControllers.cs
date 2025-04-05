using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YHDesign_project.Model.Data;


namespace YHDesign_project.Controller
{
	class FindControllers
	{
		DbConnection db = new DbConnection();

		public DataTable GetFromDB(string query)
		{
			DataTable dt = new DataTable();
			using (MySqlConnection connection = db.GetConnection())
			{
				try
				{
					MySqlCommand cmd = new MySqlCommand(query, connection);
					MySqlDataReader reader = cmd.ExecuteReader();
					dt.Load(reader);
					connection.Close();
					return dt;
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex.Message);
					return dt;
				}
			}
		}
	}
}
