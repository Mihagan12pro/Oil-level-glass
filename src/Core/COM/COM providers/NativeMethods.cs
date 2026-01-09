using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace NativeMethods
{
    internal static class NativeMethods
    {
        private const string OLEAUT32 = "oleaut32.dll";
        private const string OLE32 = "ole32.dll";

        [DllImport(OLE32, PreserveSig = false)]
        [SuppressUnmanagedCodeSecurity]
        public static extern void CLSIDFromProgIDEx([MarshalAs(UnmanagedType.LPWStr)] string progId, out Guid clsid);

        [DllImport(OLE32, PreserveSig = false)]
        [SuppressUnmanagedCodeSecurity]
        public static extern void CLSIDFromProgID([MarshalAs(UnmanagedType.LPWStr)] string progId, out Guid clsid);

        [DllImport(OLEAUT32, PreserveSig = false)]
        [SuppressUnmanagedCodeSecurity]
        public static extern void GetActiveObject(ref Guid rclsid, nint reserved, [MarshalAs(UnmanagedType.Interface)] out object ppunk);
    }
}
