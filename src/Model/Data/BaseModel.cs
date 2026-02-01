using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Oil_level_glass.Model.Data
{
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

        public virtual string Error => throw new NotImplementedException();

        protected virtual string CheckField(string columnName)
        {
            return string.Empty;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
