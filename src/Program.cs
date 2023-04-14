namespace mysql_random_insert
{
	class Program
	{
		static void Main()
		{
			int i = 0;
			while (true)
			{
				try
				{
					StartApp();
					Console.WriteLine($"Rodada: {i} - Inseridos: {i * 5}");
					i++;
				}
				catch (Exception ex)
				{
					Console.WriteLine($"Erro --> {ex.Message}");
				}
			}
		}

		private static void StartApp()
		{
			Thread t1 = new Thread(new ThreadStart(StartCalls));
			Thread t2 = new Thread(new ThreadStart(StartCalls));
			Thread t3 = new Thread(new ThreadStart(StartCalls));
			Thread t4 = new Thread(new ThreadStart(StartCalls));
			Thread t5 = new Thread(new ThreadStart(StartCalls));

			t1.Start();
			t2.Start();
			t3.Start();
			t4.Start();
			t5.Start();
		}

		private static void StartCalls()
		{	
			new CallManager().Call();
		}
	}
}

