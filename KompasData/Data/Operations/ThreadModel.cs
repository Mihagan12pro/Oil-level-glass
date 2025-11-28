using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oil_level_glass.Model.Data.Operations
{
    public class ThreadModel : BaseModel
    {
        public double NominalDiameter { get; set; }

        public double Pitch { get; set; }

        public string Standard { get; set; } = string.Empty;

        protected override string CheckField(string columnName)
        {
            string error = string.Empty;

            if (columnName == nameof(Pitch) || columnName == nameof(NominalDiameter))
            {
                error = CheckMinimumValue(columnName);
            }
             
            return error;
        }
    }
}
