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
            if (!File.Exists(fullName))
                throw new FileNotFoundException();

            return new PartObject(part.Parts.AddFromFile(fullName));
        }
    }
}
