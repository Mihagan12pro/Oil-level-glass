using Kompas6API5;
using Kompas6Constants3D;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oil_level_glass.Kompas_classes
{
    internal abstract class KompasAssemble : IKompasModel
    {
        public Color ModelColor { get; set; }
        public string ?SavePath { get; set; }
        public string ?FileExtension { get; set; }
        public string ?ModelName { get; set; }
        public ksDocument3D? Document3D { get; set; }

        protected  ksPart assemble;


        public virtual void CreateAssemble()
        {
            Document3D = IKompasModel.Kompas.Document3D();

            Document3D.Create(false,false);

            assemble = (ksPart)Document3D.GetPart((short)Part_Type.pTop_Part);
        }

        public KompasAssemble()
        {
            FileExtension = ".a3d";
        }
    }
}
