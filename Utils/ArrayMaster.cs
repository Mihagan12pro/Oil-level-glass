namespace Utils
{
    public static class ArrayMaster
    {
        public static Array ObjectToArray(object obj)
        {
            if (!(obj is Array))
                throw new InvalidDataException();

            return (Array)obj;
        }
    }
}
