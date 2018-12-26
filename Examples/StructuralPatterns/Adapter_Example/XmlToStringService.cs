using System.Xml;

namespace Adapter_Example
{
    class XmlToStringService
    {
        public string GetStringFromXMl(XmlDocument xml)
        {
            return xml.ToString();
        }
    }
}
