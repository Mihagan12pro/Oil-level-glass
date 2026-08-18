using System.ComponentModel;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Oil_level_glass.Model
{
    /// <summary>
    /// Base model class. Every domain model must be inherited from this class
    /// </summary>
    public abstract class BaseModel : IDataErrorInfo
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

        public bool HasErrors
            => Error != string.Empty;

        static BaseModel()
        {
            switch(CultureInfo.CurrentCulture.Name)
            {
                case "ru-RU":
                    {
                        messageCantBeGreaterThan = "Размер '{0}' не может превышать {1}!";
                        messageMustBeGraterThanZero = "Размер '{0}' должен быть больше нуля!";
                        messageSize0MustBeGreaterThanSize1 = "Размер '{0}' должен быть больше размера '{1}'!";
                        messageCantBeLessThan = "Размер '{0}' не может быть меньше {1}!";

                        break;
                    }
                default:
                    {
                        messageCantBeGreaterThan = "The '{0}' size can't be greater than {1}!";
                        messageMustBeGraterThanZero = "The '{0}' size must be greater than zero!";
                        messageSize0MustBeGreaterThanSize1 = "The '{0}' size must be greater than the '{1}' size!";
                        messageCantBeLessThan = "The '{0}' size can't be less than {1}!";

                        break;
                    }
            }
        }

        protected abstract string CheckField(string columnName);

        protected static readonly string messageCantBeGreaterThan;
        protected static readonly string messageCantBeLessThan;
        protected static readonly string messageMustBeGraterThanZero;
        protected static readonly string messageSize0MustBeGreaterThanSize1;
    }
}
