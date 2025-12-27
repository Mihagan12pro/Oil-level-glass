using Oil_level_glass.Core;
using Oil_level_glass.Model.Data.Entities.Parts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Oil_level_glass.COM.Extensions.Oil_level_Glass.COM_Extensions
{
    internal static class SolidPartCreatorExtensions
    {
        public static void SaveCom<TPartModel>(this ISolidPartCreator<TPartModel> solidPartCreator)
            where TPartModel : BaseDetailModel
        {

        }
    }
}
