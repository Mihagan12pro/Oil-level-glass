using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NativeMethods
{
    public static class ComConnector
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
