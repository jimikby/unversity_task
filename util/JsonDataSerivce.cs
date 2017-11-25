using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Web.Script.Serialization;

namespace University.util
{
    internal class JsonDataSerivce<T> : IDataSerivce<T>
    {
        private readonly string _filePath;
        private readonly JavaScriptSerializer _jsonSerialiser;
        public JsonDataSerivce(string filePath)
        {
            _jsonSerialiser = new JavaScriptSerializer();
            _filePath = filePath;
        }

        public void Write(T objectToWrite)
        {
            var contentsToWriteToFile = _jsonSerialiser.Serialize(objectToWrite);

            TextWriter writer = null;
            try
            {
                writer = new StreamWriter(_filePath, false);
                writer.Write(contentsToWriteToFile);
            }
            finally
            {
                writer?.Close();
            }
        }

        public T Read()
        {
            return _jsonSerialiser.Deserialize<T>(File.ReadAllText(_filePath));
        }
    }
}
