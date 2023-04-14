using Dapper;
using MySql.Data.MySqlClient;
using System.Data;

namespace mysql_random_insert
{
	public class Repository : ConnMySql
	{
		public async Task<int> InsertDb(int tableNumber)
		{
			using (IDbConnection con = new MySqlConnection(ConnString))
			{
				if (con.State == ConnectionState.Closed)
					con.Open();

				string runScript = ($"INSERT INTO `tb{tableNumber}` ( `col-a`, `col-b`, `col-c`, `create-date`) VALUES (UUID_SHORT(), HEX(UUID_SHORT()), UUID(), NOW());");

				return con.Execute(runScript, null, commandType: CommandType.Text);
			}
		}
	}
}
