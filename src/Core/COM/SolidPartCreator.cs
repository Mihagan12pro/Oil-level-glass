using KompasAPI7;
using Oil_level_glass.COM.Extensions;
using Oil_level_glass.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oil_level_glass.COM
{
    internal abstract class SolidPartCreator 
        : Creator, ISolidPartCreator
    {
        public IPart7? Part7 { get; private set; }

        public IPartDocument? PartDocument { get; private set; }

        public IModelContainer ModelContainer { get; private set; }

        public void EditAppearances()
        {
            throw new NotImplementedException();
        }

        public void EditMaterial()
        {
            throw new NotImplementedException();
        }

        public override void Initialize()
        {
            base.Initialize();

            PartDocument = KompasObject.GetPartDocument();

            Part7 = PartDocument.TopPart;

            ModelContainer = (IModelContainer)Part7;
        }
    }
}
