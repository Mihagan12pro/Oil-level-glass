using Oil_level_glass.Core.Classic.Glass;
using Oil_level_glass.Model.Data.Entities.Parts.Classic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oil_level_glass.COM.Classic.Glass
{
    internal class GlassPartCreator
        : SolidPartCreator, IGlassPartCreator
    {
        public GlassModel GlassModel { get; set; }

        public void AddSketch1()
        {
            throw new NotImplementedException();
        }

        public void EditSketch1()
        {
            throw new NotImplementedException();
        }

        public void RotateSketch1()
        {
            throw new NotImplementedException();
        }
    }
}
