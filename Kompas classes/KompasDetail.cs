using Kompas6Constants3D;
using Kompas6API5;
namespace Oil_level_glass.Kompas_classes
{
    internal abstract class KompasDetail : IKompasModel
    {
        public Color ModelColor { get; set; }
        public string ?SavePath { get; set; }
        public string ?ModelName { get; set; }
        public string ?FileExtension { get; set; }

        
        protected void BossExtrude()
        {
            
        }
    }
}
