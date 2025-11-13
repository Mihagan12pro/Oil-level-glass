namespace Utils
{
    public static class ArrayMaster
    {
        public static object[] ObjectToArray(object obj)
        {
            if (obj is object[])
                return (object[])obj;

            return new object[]{ obj };
        }
    }
}
