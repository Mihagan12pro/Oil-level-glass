using Shared.Results;

namespace Oil_level_glass.Presenters.Editors.ModelProperties.Folder
{
    internal class ModelFolderPresenter : ModelPropertiesPresenter, IModelFolderPresenter
    {
        public Result Update(string folder)
        {
            if (Directory.Exists(folder))
                return new Result(false, "This folder does not exists!");

            return new Result(true);
        }
    }
}
