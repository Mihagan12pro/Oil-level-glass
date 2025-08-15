using Oil_level_glass.Enums;
using System.Collections;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Oil_level_glass.BaseClasses
{
    internal abstract class BaseKompasData : INotifyDataErrorInfo, INotifyPropertyChanged
    {
        protected readonly Dictionary<string, List<string>> errorsByPropertyName = new Dictionary<string, List<string>>();
        public Dictionary<string, List<string>> ErrorsByPropertyName => errorsByPropertyName;


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


        protected void AddError(string propertyName, string error)
        {
            if (!errorsByPropertyName.ContainsKey(propertyName))
                errorsByPropertyName[propertyName] = new List<string>();

            if (!errorsByPropertyName[propertyName].Contains((error)))
            {
                errorsByPropertyName[propertyName].Add((error));
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
