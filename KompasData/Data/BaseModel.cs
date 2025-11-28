using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace Oil_level_glass.Model.Data
{
    public abstract class BaseModel : IDataErrorInfo
    {
        public virtual string this[string columnName]
        {
            get
            {
                return CheckField(columnName);
            }
        }

        public virtual string Error => throw new NotImplementedException();

        protected abstract string CheckField(string columnName);

        public static string TooSmallValueError => "Too small value!";

        public static string InvalidChamferAngleError => "Chamfer angle must be in range (0, 90)!";

        public static string EmptyStringError => "Can not be empty!";

        public static string InvalidDensityError => "Too small or too big density!";

        public static string DirectoryDoesNotExistsError => "Directory does not exists!";

        public static string FileDoesNotExistsError => "File does not exists!";
    }
}
