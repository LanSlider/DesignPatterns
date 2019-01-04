namespace Bridge
{
    class Abstract
    {
        private readonly IService _service;

        public Abstract(IService service)
        {
            _service = service;
        }

        public void Operation()
        {
            _service.OperationImpl();
        }
    }
}
