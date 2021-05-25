using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace Treinamento_DesignPattern_2.Adapter
{
    public class GeradorDeXml : IGerador
    {

        public string Gera(Cliente cliente)
        {
            XmlSerializer serializer = new XmlSerializer(cliente.GetType());
            StringWriter writer = new StringWriter();
            serializer.Serialize(writer, cliente);
            return writer.ToString();
        }
    }
}
