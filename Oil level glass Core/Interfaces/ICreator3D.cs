using KompasAPI7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oil_level_glass_Core.Interfaces
{
    public interface ICreator3D
    {
        IPart7 Part { get; }

        IModelContainer ModelContainer { get; }
    }
}
