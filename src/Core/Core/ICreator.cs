namespace Oil_level_glass.Core
{
    /// <summary>
    /// Base interface for all builders
    /// </summary>
    public interface ICreator
    {
        /// <summary>
        /// Entry point. Here application initializes code for interaction with API
        /// </summary>
        void Initialize();

        /// <summary>
        /// Save file with a solid part
        /// </summary>
        void SaveFile();

        /// <summary>
        /// Set naming of the model
        /// </summary>
        void EditNaming();

        /// <summary>
        /// Set save folder
        /// </summary>
        void EditSavingParameter();
    }
}
