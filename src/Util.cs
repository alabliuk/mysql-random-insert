using Microsoft.Extensions.Configuration;

namespace mysql_random_insert
{
	public class Util
	{
		readonly string _currentPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

		public IConfigurationRoot ReadTokensConnsettings(string _currentPath)
		{
			var builder = new ConfigurationBuilder()
					 .SetBasePath(_currentPath)
					 .AddJsonFile($"connsettings.json");
			var config = builder.Build();
			return config;
		}
	}
}
