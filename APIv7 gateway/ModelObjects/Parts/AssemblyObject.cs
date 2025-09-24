using KompasAPI7;

namespace APIv7_gateway.ModelObjects.Parts
{
    public class AssemblyObject : PartObject
    {
        internal AssemblyObject(IPart7 part) : base(part)
        {

        }


        public PartObject AddPartToAssembly(string fullName)
        {
            return new PartObject(part.Parts.AddFromFile(fullName));
        }
    }
}
