namespace Oil_level_glass.Core.COM.COMProviders
{
    internal static class ComConnector
    {
        public static object GetInstance(string progId)
        {
            Guid clsid;

            try
            {
                NativeMethods.CLSIDFromProgIDEx(progId, out clsid);
            }
            catch
            {
                NativeMethods.CLSIDFromProgID(progId, out clsid);
            }

            NativeMethods.GetActiveObject(ref clsid, nint.Zero, out var obj);

            return obj;
        }
    }
}
