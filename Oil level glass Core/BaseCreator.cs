using Kompas6API5;
using KompasAPI7;
using Oil_level_glass.Model;
using Oil_level_glass.Model.KompasFile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oil_level_glass_Core
{
    public abstract class BaseCreator
    {
        protected IApplication? application;

        protected IKompasDocument? kompasDocument;

        protected readonly bool createNewDocument;

        public required BaseEntityModel EntityModel { get; set; }

        public virtual void SaveDocument()
        {
            KompasFile? file = EntityModel.File;

            kompasDocument?.SaveAs(file?.FullName);
        }

        public virtual void Create()
        {
            SaveDocument();
        }


        public BaseCreator(bool createNewDocument)
        {
            this.createNewDocument = createNewDocument;

            application = NativeMethods.ComConnector.GetInstance("KOMPAS.Application.7") as IApplication;
        }
    }
}
