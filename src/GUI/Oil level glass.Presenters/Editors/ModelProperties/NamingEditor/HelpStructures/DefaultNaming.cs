using Oil_level_glass.Presenters.Editors.HelpStructures;

namespace Oil_level_glass.Presenters.Editors.ModelProperties.NamingEditor.HelpStructures
{
    public class DefaultNaming : DefaultSizes
    {
        public readonly string Namimg, Marking;

        public DefaultNaming(string namimg, string marking)
        {
            Marking = marking;

            Namimg = namimg;
        }
    }
}
