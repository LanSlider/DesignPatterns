using System.Xml;

namespace Adapter_Example
{
    class XmlToStringService : SendService
    {
        private readonly XMLService _xmlService;

        public XmlToStringService(XMLService xmlService)
        {
            _xmlService = xmlService;
        }

        public override void Request()
        {
            var xmlData = _xmlService.GetXMLData("baseurl.com").ToString();
            base.SendDataOnEmail(xmlData, "email@email.com");
        }
    }
}
