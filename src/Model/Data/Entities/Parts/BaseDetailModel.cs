using Oil_level_glass.Model.ModelProperties.KompasFile;
using Oil_level_glass.Model.ModelProperties.Materials;
using Oil_level_glass.Model.ModelProperties.Other;
using System.Globalization;

namespace Oil_level_glass.Model.Data.Entities.Parts
{
    /// <summary>
    /// Base class for entities that describe solid parts
    /// </summary>
    public abstract class BaseDetailModel 
        : BaseEntityModel
    {
        protected readonly string mustBeGraterThanZero;
        protected readonly string size0MustBeGreaterThanSize1;

        public BaseDetailModel()
        {
            Appearance = new Appearance();

            File = new PartFile()
            {
                Name = new Name()
            };

            switch (CultureInfo.CurrentCulture.Name)
            {
                case "ru-RU":
                    {
                        mustBeGraterThanZero = "Размер '{0}' должен быть больше нуля!";
                        size0MustBeGreaterThanSize1 = "Размер '{0}' должен быть больше размера '{1}'!";

                        break;
                    }
                default:
                    {
                        mustBeGraterThanZero = "The '{0}' size must be greater than zero!";
                        size0MustBeGreaterThanSize1 = "The '{0}' size must be greater than the '{1}' size!";

                        break;
                    }
            }
        }

        public Appearance Appearance { get; init; }
        public Material? Material { get; init; }
    }
}