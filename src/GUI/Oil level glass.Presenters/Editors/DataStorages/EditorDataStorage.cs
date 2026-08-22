using Oil_level_glass.Presenters.Editors.EditorsData.BaseData;

namespace Oil_level_glass.Presenters.Editors.DataStorages
{
    public abstract class EditorDataStorage<TDefault, TPending, TResults> : EditorDataStorage
        where TDefault : DefaultDataValues
        where TPending : UpdateDataPending
        where TResults : UpdateDataResults
    {
        public required TDefault Default { get; set; }

        public required TPending Pending { get; set; }

        public required TResults Results { get; set; }
    }

    public abstract class EditorDataStorage
    {

    }
}
