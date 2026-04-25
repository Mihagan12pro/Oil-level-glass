using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Oil_level_glass.Model.Data
{
    /// <summary>
    /// Base model class. Every domain model must be inherited from this class
    /// </summary>
    public abstract class BaseModel 
        : IDataErrorInfo, 
          INotifyPropertyChanged
    {
        public virtual string this[string columnName]
        {
            get
            {
                return CheckField(columnName);
            }
        }

        public virtual string Error => string.Empty;

        protected abstract string CheckField(string columnName);

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
