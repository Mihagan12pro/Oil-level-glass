using Shared.Results;
using System.Reflection;

namespace Oil_level_glass.Presenters.Editors.EditorsData.BaseData
{
    public abstract class UpdateDataResults
    {
        public bool NoErrors
        {
            get
            {
                var results = this.GetType()
                                  .GetProperties()
                                  .Where(m => m.PropertyType == typeof(Result))
                                  .Select(r => (r.GetValue(this) as Result).IsSuccess);

                foreach ( var r in results )
                {
                    if (!r)
                        return false;   
                }

                return true;
            }
        }
    }
}
