using Kompas6API5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oil_level_glass.Kompas_classes
{
    internal interface IKompasModel
    {
        Color ModelColor { get; set; }

        string SavePath { get; set; }

        string FileExtension { get; set; }

        string ModelName { get; set; }

        ksDocument3D Document3D { get; set; }

        static Kompas6API5.KompasObject ?Kompas { get; set; }
    }
}
