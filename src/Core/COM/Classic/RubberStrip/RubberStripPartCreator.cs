using Oil_level_glass.Core.Classic.RubberStrip;
using Oil_level_glass.Model.Data.Entities.Parts.Classic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oil_level_glass.COM.Classic.RubberStrip
{
    internal class RubberStripPartCreator
        : ComSolidPartCreator<RubberStripModel>, IRubberStripPartCreator
    {
        public RubberStripModel RubberStrip { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

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

        public override void SaveFile()
        {
            throw new NotImplementedException();
        }
    }
}
