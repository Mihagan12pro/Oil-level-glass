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

        public string Error
        {
            get
            {
                string error = string.Empty;

                Type modelType = this.GetType();
                foreach(PropertyInfo prop in modelType.GetProperties())
                {
                    if (typeof(BaseModel).IsAssignableFrom(prop.PropertyType))
                    {
                        BaseModel model = (BaseModel)prop.GetValue(this);

                        error += model.Error;
                    }
                    else
                    {
                        if (this[prop.Name] != string.Empty)
                        {
                            error += this[prop.Name] + '\n';
                        }
                    }
                }

                return error;
            }
        }


        protected abstract string CheckField(string columnName);

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
