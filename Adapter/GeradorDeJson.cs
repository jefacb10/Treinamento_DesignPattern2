using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Treinamento_DesignPattern_2.Adapter
{
    public class GeradorDeJson : IGerador
    {
        public string Gera(Cliente cliente)
        {
            JsonSerializer serializer = new JsonSerializer();
            StringWriter writer = new StringWriter();
            serializer.Serialize(writer, cliente);

            return writer.ToString();
        }
    }
}
