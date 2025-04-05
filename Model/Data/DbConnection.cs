using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace YHDesign_project.Model.Data
{
	class DbConnection
	{
		private MySqlConnection connection;
		private string server = "localhost";
		private string database = "db_yhdesign";
		private string user = "root";
		private string password = "40233";
		private string cadenaConecction;

		public DbConnection()
		{
			this.cadenaConecction = "server=" + this.server + ";database=" + this.database +
				";user=" + this.user + ";password=" + this.password + ";";
		}


		public MySqlConnection GetConnection()
		{
			this.connection = new MySqlConnection(this.cadenaConecction);
			this.connection.Open();

			return this.connection;
		}
	}
}
