namespace mysql_random_insert
{
	public class Business
	{
		private readonly Repository _repository;

		public Business()
		{
			_repository = new Repository();
		}

		public async Task<int> InsertWorkload()
		{
			return await _repository.InsertDb(new Random().Next(1, 6));
		}
	}
}
