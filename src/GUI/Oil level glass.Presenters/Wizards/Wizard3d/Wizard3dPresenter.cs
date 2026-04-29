using Oil_level_glass.Model.Data.Entities.Parts.Classic;
using Oil_level_glass.Presenters.Enums;
using Oil_level_glass.UI.Abstractions.Wizards.Wizard3d;
using Oil_level_glass.Core.COM;
using Shared.Results;

namespace Oil_level_glass.Presenters.Wizards.Wizard3d
{
    internal class Wizard3dPresenter : IWizard3dPresenter
    {
        private readonly IWizard3dForm _wizardForm;

        private readonly HousingModel _housing;
        private readonly RubberStripModel _stripModel;
        private readonly GlassModel _glass;

        public Action InvokeGlassEditor { get; }
        public Action InvokeHousingEditor { get; }
        public Action InvokeRubberStripEditor { get; }

        public Action CheckData { get; }

        public void InvokeEditor(object tag)
        {
            if (tag is Part part)
            {
                switch(part)
                {
                    case Part.Housing:
                        InvokeHousingEditor();
                        break;

                    case Part.RubberStrip:
                        InvokeRubberStripEditor();
                        break;

                    case Part.Glass:
                        InvokeGlassEditor();
                        break;
                }
            }
        }

        public void UpdateModel()
        {
            _stripModel.ExternalDiameter = _glass.Diameter;
            _housing.GlassSocketDiameter = _stripModel.ExternalDiameter;

            _housing.GlassSocketHeight = _stripModel.Height * 2 + _glass.Height;
            _housing.CentralHoleDiameter = _stripModel.InternalDiameter;

            CheckData.Invoke();
        }

        public Result Create()
        {
            Result result = null;

            CreatorsFactory creatorsFactory = new CreatorsFactory();
           
            var housingCreator = creatorsFactory.CreateHousingPartCreator(_housing);
            result = housingCreator.Create();

            if (result.IsSuccess)
            {
                var rubberStripCreator = creatorsFactory.CreateRubberStripPartCreator(_stripModel);
                result = rubberStripCreator.Create();

                if (result.IsSuccess)
                {
                    var glassCreator = creatorsFactory.CreateGlassPart(_glass);
                    result = glassCreator.Create();

                    if (result.IsSuccess)
                    {
                        var oliLevelGlassCreator = creatorsFactory.CreateOilLevelGlassPartCreator(_glass, _stripModel, _housing);
                        return oliLevelGlassCreator.Create();
                    }
                }
            }

            return result;
        }

        public Wizard3dPresenter(
            IWizard3dForm wizardForm, 
            GlassModel glass,
            RubberStripModel rubberStrip, 
            HousingModel housing,
            Action invokeGlassEditor,
            Action invokeRubberStripEditor,
            Action invokeHousingEditor,
            Action checkData)
        {
            _wizardForm = wizardForm;

            _glass = glass;
            _stripModel = rubberStrip;
            _housing = housing;

            InvokeGlassEditor = invokeGlassEditor;
            InvokeRubberStripEditor = invokeRubberStripEditor;
            InvokeHousingEditor = invokeHousingEditor;

            CheckData = checkData;
        }
    }
}
