using Kompas6API5;
using KompasAPI7;
using NativeMethods;
using Oil_level_glass.Core;
using Oil_level_glass.Core.Records;
using System.Runtime.InteropServices;

namespace Oil_level_glass.COM
{
    public class ComConnectionChecker 
        : IConnectionChecker
    {
        public DialogResult Check(KompasDocumentType kompasDocument = KompasDocumentType.None)
        {
            DialogResult result = null;

            try
            {
                KompasObject kompasObject = (KompasObject)ComConnector
                    .GetInstance("KOMPAS.Application.5");

                IApplication application = (IApplication)kompasObject.ksGetApplication7();

                result = new DialogResult(true);

                switch(kompasDocument)
                {
                    case KompasDocumentType.SolidPart:
                        {
                            var document = application.ActiveDocument;

                            if (document == null || !(document is IPartDocument))
                            {
                                result = new DialogResult(false, "Для работы данного модуля необходимо создать новую деталь!", "ОШИБКА");
                            }
                            break;
                        }
                    case KompasDocumentType.Assembly:
                        {
                            var document = application.ActiveDocument;

                            if (document == null || !(document is IAssemblyDocument))
                            {
                                result = new DialogResult(false, "Для работы данного модуля необходимо создать новую сборку!", "ОШИБКА");
                            }
                            break;
                        }
                }
            }
            catch (COMException)
            {
                result = new DialogResult(false, "Для работы данного модуля необходим запущенный КОМПАС-3D!", "ВНИМАНИЕ!");
            }

            return result;
        }
    }
}
