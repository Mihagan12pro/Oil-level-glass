using KompasAPI7;
using Oil_level_glass_Core.Data.ModelProperties;

namespace Oil_level_glass_Core.Creators
{
    public abstract record BaseCreator
    {
        public ModelProperties<IKompasDocument>? Properties { get; init; }

        protected void Save()
        {
            Properties?.KompasDocument?.SaveAs(Properties?.KompasFile?.FullName);
        }


        public abstract void Create();
    }
}
