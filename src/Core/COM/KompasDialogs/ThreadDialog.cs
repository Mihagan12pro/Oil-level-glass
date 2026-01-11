using KompasAPI7;
using Oil_level_glass.Core.KompasDialogs;
using Oil_level_glass.Model.Data.Operations;

namespace Oil_level_glass.COM.KompasDialogs
{
    internal class ThreadDialog
        : ComDialogBase, IThreadDialog
    {
        protected internal ThreadDialog(IApplication application) : base(application)
        {
        }

        public void SelectThread(ThreadModel thread)
        {
            ThreadDialogParam dialogParam = (ThreadDialogParam)applicationDialogs.GetDialogParam(Kompas6Constants.KompasAPIObjectTypeEnum.ksObjectThreadDialogParam);

            applicationDialogs.SelectThread(hwnd, dialogParam);

            thread.Standard = dialogParam.Standart;
            thread.Pitch = dialogParam.P;
            thread.NominalDiameter = dialogParam.NominalDiameter;
        }

        public void SelectThread(
            ThreadModel thread,
            double maximumDiameter, 
            bool isStrictly = false)
        {
            ThreadDialogParam dialogParam = (ThreadDialogParam)applicationDialogs.GetDialogParam(Kompas6Constants.KompasAPIObjectTypeEnum.ksObjectThreadDialogParam);

            applicationDialogs.SelectThread(hwnd, dialogParam);

            bool isSuccess = true;

            if (isStrictly)
            {
                if (dialogParam.NominalDiameter >= maximumDiameter)
                    isSuccess = false;
            }
            else
            {
                if (dialogParam.NominalDiameter > maximumDiameter)
                    isSuccess = false;
            }

            if (isSuccess)
            {
                thread.Standard = dialogParam.Standart;
                thread.Pitch = dialogParam.P;
                thread.NominalDiameter = dialogParam.NominalDiameter;

                return;
            }

            application.MessageBoxEx("Была выбрана резьба со слишком большим номинальным диаметром!", "ОШИБКА!", 2);
        }
    }
}
