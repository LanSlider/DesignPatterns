using System.Xml;

namespace Adapter_Example
{
    class XMLService
    {
        public XmlDocument GetXMLData(string url)
        {
            var xml = new XmlDocument();
            xml.LoadXml("<People><Person Name='Nick' /><Person Name='Joe' /></People>");

            return xml;
        }
    }
}
