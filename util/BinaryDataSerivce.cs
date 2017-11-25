using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace University.util
{
    internal class BinaryDataSerivce<T> : IDataSerivce<T>
    {
        private readonly string _filePath;

        public BinaryDataSerivce(string filePath)
        {
            _filePath = filePath;
        }

        public void Write(T objectToWrite)
        {
            using (Stream stream = File.Open(_filePath, FileMode.Create))
            {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                binaryFormatter.Serialize(stream, objectToWrite);
            }
        }

        public T Read()
        {
            using (Stream stream = File.Open(_filePath, FileMode.Open))
            {
                if (stream.Length == 0) return default(T);
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                return (T) binaryFormatter.Deserialize(stream);
            }
        }
    }
}
