using Kompas6API5;
using KompasAPI7;
using Oil_level_glass.Model.Data.KompasFile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oil_level_glass.COM.Extensions
{
    internal static class DocumentV7Extensions
    {
        public static void SaveAs(this IKompasDocument document, KompasFile kompasFile)
        {
            document.SaveAs(kompasFile.FullName); 
        }
    }
}
