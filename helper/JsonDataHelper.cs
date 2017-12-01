using System.IO;
using System.Web.Script.Serialization;

namespace University.util
{
    internal class JsonDataHepler<T> : IDataHelper<T>
    {
        private readonly string _filePath;
        public JsonDataHepler(string filePath, bool clean)
        {
            _filePath = filePath;
            if (clean || !File.Exists(_filePath)) Clean();
        }

        public void Write(T objectToWrite)
        {
            var contentsToWriteToFile = new JavaScriptSerializer().Serialize(objectToWrite);

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
            return new JavaScriptSerializer().Deserialize<T>(File.ReadAllText(_filePath));
        }

        public void Clean()
        {
        if (File.Exists(_filePath)) File.Delete(_filePath);
        using (File.Create(_filePath))
        {
        }
        }
    }
}
