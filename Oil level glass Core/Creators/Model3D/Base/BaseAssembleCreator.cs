using KompasAPI7;
using Oil_level_glass_Core.Data.ModelProperties.Properties3D;
using Oil_level_glass_Core.Interfaces;
using Oil_level_glass_Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oil_level_glass_Core.Creators.Model3D.Base
{
    public abstract record BaseAssembleCreator : BaseCreator<ModelAssemblyProperties>, IKompas7Object
    {
        public IApplication Application { get; init; }

        public BaseAssembleCreator()
        {
            Properties = new ModelAssemblyProperties();

            Application = (IApplication)COMConnector.GetInstance("KOMPAS.Application.7");
        }
    }
}
