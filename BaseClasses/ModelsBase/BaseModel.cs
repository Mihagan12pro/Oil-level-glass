using System.Collections;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Oil_level_glass.BaseClasses.ModelsBase
{
    internal abstract class BaseModel : BasePropertyChanger, INotifyDataErrorInfo
    {
        protected readonly Dictionary<string, List<string>> errorsByPropertyName = new Dictionary<string, List<string>>();
        public Dictionary<string, List<string>> ErrorsByPropertyName => errorsByPropertyName;


        public bool HasErrors => errorsByPropertyName.Any();


        public event EventHandler<DataErrorsChangedEventArgs>? ErrorsChanged;


        public IEnumerable GetErrors(string? propertyName)
        {
            return errorsByPropertyName.ContainsKey(propertyName) ? errorsByPropertyName[propertyName] : null;
        }


        protected void OnErrorsChanged(string propertyName)
        {
            ErrorsChanged?.Invoke(this, new DataErrorsChangedEventArgs(propertyName));
        }


        protected void AddError(string propertyName, string error)
        {
            if (!errorsByPropertyName.ContainsKey(propertyName))
                errorsByPropertyName[propertyName] = new List<string>();

            if (!errorsByPropertyName[propertyName].Contains(error))
            {
                errorsByPropertyName[propertyName].Add(error);
                OnErrorsChanged(propertyName);
            }
        }


        protected void ClearErrors(string propertyName)
        {
            if (errorsByPropertyName.ContainsKey(propertyName))
            {
                errorsByPropertyName.Remove(propertyName);
                OnErrorsChanged(propertyName);
            }
        }


        public override void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            ValidationContext context = new ValidationContext(this) { MemberName = prop };

            List<ValidationResult> results = new List<ValidationResult>();

            ClearErrors(prop);

            PropertyInfo? propertyInfo = this.GetType().GetProperty(prop);

            if (!Validator.TryValidateProperty(propertyInfo.GetValue(this), context, results))
            {
                foreach (ValidationResult result in results)
                {
                    AddError(prop, result.ErrorMessage);
                }
            }

            base.OnPropertyChanged(prop);
        }


        //public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        //{
        //    List<ValidationResult> errors = new List<ValidationResult>();

        //    return Validate(validationContext, errors);
        //}


        //protected virtual IEnumerable<ValidationResult> Validate(ValidationContext validationContext, List<ValidationResult> errors)
        //{
        //    return errors;
        //}
    }
}
