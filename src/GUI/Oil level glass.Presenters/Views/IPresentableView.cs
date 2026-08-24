using Oil_level_glass.Presenters.Presenters;
using Oil_level_glass.UI.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oil_level_glass.Presenters.Views
{
    /// <summary>
    /// View with presenter
    /// </summary>
    public interface IPresentableView<TPresenter> : IView
        where TPresenter : IPresenter
    {
    }
}
