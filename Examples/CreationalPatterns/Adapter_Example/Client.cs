namespace Adapter_Example
{
    class Client
    {
        private readonly XMLService _xmlService;
        private readonly SendService _sendService;
        private readonly XmlToStringService _xmlToStringService;

        public Client()
        {
            _xmlService = new XMLService();
            _sendService = new SendService();
            _xmlToStringService = new XmlToStringService();
        }

        public void SendData()
        {
            var xml = _xmlService.GetXMLData("dfsdf");
            var xmlStringData = _xmlToStringService.GetStringFromXMl(xml);
            _sendService.SendDataOnEmail(xmlStringData, "dfaf");
        }
    }
}
