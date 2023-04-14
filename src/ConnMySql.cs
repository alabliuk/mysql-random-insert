using System.Reflection;

namespace mysql_random_insert
{
	public abstract class ConnMySql
	{
		public static string ConnString { get; private set; }

		public ConnMySql()
		{
			string currentPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
			var config = new Util().ReadTokensConnsettings(currentPath);
			ConnString = config.GetSection("ConnMySql:DB").Value;
		}
	}
}
