using Oil_level_glass.Presenters.Editors.HelpStructures;

namespace Oil_level_glass.Presenters.Editors.ModelProperties.NamingEditor.HelpStructures
{
    public class NamingUpdateData : UpdateData
    {
        public readonly string Naming, Marking;

        public NamingUpdateData(string naming, string marking)
        {
            Naming = naming;

            Marking = marking;
        }
    }
}
