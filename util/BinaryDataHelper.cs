using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace University.util
{
    internal class BinaryDataHepler<T> : IDataHelper<T>
    {
        private readonly string _filePath;
        
        public BinaryDataHepler(string filePath, bool clean)
        {
            _filePath = filePath;
            if (clean || !File.Exists(_filePath)) Clean();
        }

        public void Write(T objectToWrite)
        {
            using (Stream stream = File.Open(_filePath, FileMode.Create))
            {
                var binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(stream, objectToWrite);
            }
        }

        public T Read()
        {
            using (Stream stream = File.Open(_filePath, FileMode.Open))
            {
                if (stream.Length == 0) return default(T);
                var binaryFormatter = new BinaryFormatter();
                return (T) binaryFormatter.Deserialize(stream);
            }
        }

        public void Clean()
        {
            if (File.Exists(_filePath)) File.Delete(_filePath);
            using (File.Create(_filePath))
            {
            };
        }
    }
}
