namespace Oil_level_glass.Model.Entities.Parts.Classic
{
    public class OilLevelGlassModel : BaseEntityModel
    {
        public required HousingModel HousingModel { get; set; }

        public required GlassModel GlassModel { get; set; }

        public required RubberStripModel RubberStripModel { get; set; }

        public double MainDiameter
        {
            get
            {
                return HousingModel.MainDiameter;
            }
            set
            {
                HousingModel.MainDiameter = value;
            }
        }

        public double MainHeight
        {
            get
            {
                return HousingModel.MainHeight;
            }
            set
            {
                HousingModel.MainHeight = value;
            }
        }

        public double BigSocketDiameter
        {
            get
            {
                return HousingModel.BigSocketDiameter;
            }
            set
            {
                HousingModel.BigSocketDiameter = value;
                RubberStripModel.ExternalDiameter = value;
                GlassModel.ExternalDiameter = value;
            }
        }

        public double SmallSocketDiameter
        {
            get
            {
                return HousingModel.SmallSocketDiameter;
            }
            set
            {
                HousingModel.SmallSocketDiameter = value;
                RubberStripModel.InternalDiameter = value;
            }
        }

        public OilLevelGlassModel()
        {
            File = new KompasFile.AssemblyFile();
        }
    }
}
