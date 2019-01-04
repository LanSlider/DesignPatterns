namespace Strategy
{
    class Client
    {
        private readonly IService _service;

        public Client(IService service)
        {
            _service = service;
        }
    }
}
