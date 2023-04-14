namespace mysql_random_insert
{
	class CallManager
	{
		private readonly Business _business;

		public CallManager()
		{
			_business = new Business();
		}

		public async Task<int> Call()
		{
			return await _business.InsertWorkload();
		}
	}
}
