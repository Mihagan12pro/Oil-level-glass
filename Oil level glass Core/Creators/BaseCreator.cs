using KompasAPI7;
using Oil_level_glass_Core.Data.ModelProperties;

namespace Oil_level_glass_Core.Creators
{
    public abstract record BaseCreator
    {
        public ModelProperties? Properties { get; init; }


        protected void Save()
        {
            Properties?.SaveDocument();
        }


        public abstract void Create();
    }
}
