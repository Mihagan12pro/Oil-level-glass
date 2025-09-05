using Oil_level_glass_Core.Data.ModelProperties;

namespace Oil_level_glass_Core.Creators
{
    public abstract class BaseCreator<P> where P : ModelProperties
    {
        public P? Properties { get; set; }

        protected void Save()
        {
            Properties?.KompasDocument?.SaveAs(Properties?.KompasFile?.FullName);
        }


        public abstract void Create();
    }
}
