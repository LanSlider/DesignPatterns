namespace Iterator
{
    class Client
    {
        private readonly IEnumerable _collection;

        public Client(IEnumerable collection)
        {
            _collection = collection;
        }
    }
}
