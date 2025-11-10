using KompasAPI7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oil_level_glass_Core
{
    public abstract class Base3DCreator : BaseCreator
    {
        public IPart7 Part { get; protected set; }

        protected IModelContainer modelContainer;

        public override void SaveDocument()
        {
            Part.Marking = EntityModel.File!.Name.Marking;
            Part.Name = EntityModel.File!.Name.Naming;
            Part.Update();

            base.SaveDocument();
        }

        public Base3DCreator(bool createNewDocument) : base(createNewDocument)
        {
        }
    }
}
