using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oil_level_glass.Presenters.Wizards.Wizard3d
{
    public interface IWizard3dPresenter : IWizardPresenter
    {
        void UpdatePartSavingParameter(
            object tag,
            string folder,
            string naming,
            string marking);
    }
}
