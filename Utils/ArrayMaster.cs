namespace Utils
{
    public static class ArrayMaster
    {
        public static Array ObjectToArray(object obj)
        {
            if (obj is Array)
                return (Array)obj;

            return new []{ obj };
        }
    }
}
