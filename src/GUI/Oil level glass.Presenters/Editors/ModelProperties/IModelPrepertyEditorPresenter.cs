using Oil_level_glass.Model;
using Oil_level_glass.Presenters.Editors.HelpStructures;
using Oil_level_glass.UI.Abstractions;
using Oil_level_glass.UI.Presenters.Editors;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Oil_level_glass.Presenters.Editors.ModelProperties
{
    public interface IModelPrepertyEditorPresenter<TModel, TView, TUpdateResults, TUpdateData, TDefaultSizes>
        : IEditorPresenter<TView, TUpdateResults, TUpdateData, TDefaultSizes>
        where TView : IView
        where TUpdateResults : UpdateResults
        where TDefaultSizes : DefaultSizes
        where TUpdateData : UpdateData
        where TModel : BaseModel
    {
        void AddModel(TModel model);

        IEnumerable Models { get; }

        void SelectModel(int index);
    }
}
