using Oil_level_glass.Enums;
using System.Collections;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Oil_level_glass.BaseClasses
{
    internal abstract class BaseKompasData : INotifyDataErrorInfo, INotifyPropertyChanged
    {
        protected readonly Dictionary<string, List<(string, InputError)>> errorsByPropertyName = new Dictionary<string, List<(string, InputError)>>();
        public Dictionary<string, List<(string, InputError)>> ErrorsByPropertyName => errorsByPropertyName;


        public bool HasErrors => errorsByPropertyName.Any();


        public event EventHandler<DataErrorsChangedEventArgs>? ErrorsChanged;


        public event PropertyChangedEventHandler? PropertyChanged;


        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }


        public IEnumerable GetErrors(string? propertyName)
        {
            return errorsByPropertyName.ContainsKey(propertyName) ? errorsByPropertyName[propertyName] : null;
        }


        protected void OnErrorsChanged(string propertyName)
        {
            ErrorsChanged?.Invoke(this, new DataErrorsChangedEventArgs(propertyName));
        }


        protected void AddError(string propertyName, string error, InputError input)
        {
            if (!errorsByPropertyName.ContainsKey(propertyName))
                errorsByPropertyName[propertyName] = new List<(string, InputError)>();

            if (!errorsByPropertyName[propertyName].Contains((error, input)))
            {
                errorsByPropertyName[propertyName].Add((error, input));
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


    }
}
