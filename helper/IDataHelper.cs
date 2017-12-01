namespace University.util
{
    internal interface IDataHelper<T>
    {
        void Clean();
        T Read();
        void Write(T objectToWrite);
    }
}
