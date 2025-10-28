using KompasAPI7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oil_level_glass_Core
{
    public abstract class BaseAPI7Object
    {
        protected IApplication? application;

        protected IKompasDocument? kompasDocument;

        protected readonly bool createNewDocument;

        protected abstract void SaveDocument();


        public BaseAPI7Object(bool createNewDocument)
        {
            this.createNewDocument = createNewDocument;

            application = NativeMethods.ComConnector.GetInstance("KOMPAS.Application.7") as IApplication;
        }
    }
}
