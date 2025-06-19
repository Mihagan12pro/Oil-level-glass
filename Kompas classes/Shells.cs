using Kompas6API5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oil_level_glass.Kompas_classes
{
    abstract class Shell
    {
        public bool Ok { get; set; }
    }

    interface ICopy
    {

    }

    interface I3DOperation
    {

    }


    class SketchShell : Shell
    {
        public ksEntity? Sketch { get; set; }

        public ksSketchDefinition? SketchDefinition { get; set; }

       
    }


    class BossExtrusionShell : Shell, ICopy, I3DOperation
    {
        public ksEntity? BossExtrusion { get; set; }

        public ksBossExtrusionDefinition? BossExtrusionDefinition { get; set; }
    }


    class CutRotatedShell : Shell, ICopy, I3DOperation
    {
        public ksEntity? CutRotated { get; set; }

        public ksCutRotatedDefinition? CutRotatedDefinition { get; set; }
    }


    class CircularCopyShell : Shell, ICopy
    {
        public ksEntity? CircularCopy { get; set; }

        public ksCircularCopyDefinition? CircularCopyDefinition { get; set; }
    }


    class ChamferShell : Shell, ICopy
    {
        public ksEntity? Chamfer { get; set; }

        public ksChamferDefinition? ChamferDefinition { get; set; }
    }


    class ThreadShell: Shell,ICopy
    {
        public ksEntity? Thread { get; set; }

        public ThreadDefinition? ThreadDefinition { get; set; }
    }
}
