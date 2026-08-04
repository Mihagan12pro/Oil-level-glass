using Oil_level_glass.UI.Presenters.Editors;

namespace Oil_level_glass.Presenters.Editors.ValueObjects
{
    public interface IValueObjectEditor<T> : IEditorPresenter
    {
        T Housing {  get; set;  }

        T RubberStrip { get; set; }

        T Glass { get; set; }
    }
}
