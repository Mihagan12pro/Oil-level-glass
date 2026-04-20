using Oil_level_glass.Model.Data.Materials;
using System.ComponentModel;

namespace Oil_level_glass.Model.Data.Entities.Parts.Classic
{
    public class RubberStripModel : BaseDetailModel
    {
        private double _internalDiameter, _height, _externalDiameter;

        [DisplayName("Internal diameter")]
        public double InternalDiameter
        {
            get
            {
                return _internalDiameter; 
            }
            set
            {
                _internalDiameter = value;

                OnPropertyChanged();
            }
        }

        [DisplayName("External diameter")]
        public double ExternalDiameter
        {
            get
            {
                return _externalDiameter; 
            }
            set
            {
                _externalDiameter = value;

                OnPropertyChanged();
            }
        }

        [DisplayName("Height")]
        public double Height
        {
            get 
            {
                return _height;
            }
            set
            {
                _height = value;

                OnPropertyChanged();
            }
        }

        protected override string CheckField(string columnName)
        {
            string error = string.Empty;

            switch(columnName)
            {
                case nameof(Height):
                    {
                        if (Height <= 0)
                            error = "Ring height must be greater than zero!";

                        break;
                    }
                case nameof(InternalDiameter):
                    {
                        if (InternalDiameter <= 0)
                            error = "Ring internal diameter must be greater than zero!";
                        else if (InternalDiameter >= ExternalDiameter)
                            error = "External diameter must be greater than internal diameter!";

                        break;
                    }
                case nameof(ExternalDiameter):
                    {
                        if (ExternalDiameter <= 0)
                            error = "Ring external diameter must be greater than zero!";
                        else if (InternalDiameter >= ExternalDiameter)
                            error = "External diameter must be greater than internal diameter!";

                        break;
                    }
            }

            return error;
        }

        public override string Error
        {
            get
            {
                string[] errorsArray = new string[0];

                string heightError = this[nameof(Height)];
                if (heightError != string.Empty)
                {
                    int length = errorsArray.Length;

                    Array.Resize(ref errorsArray, length + 1);
                    errorsArray[length] = heightError + '\n'; 
                }


                string externalDiameterError = this[nameof(ExternalDiameter)];
                if (externalDiameterError != string.Empty)
                {
                    int length = errorsArray.Length;

                    Array.Resize(ref errorsArray, length + 1);
                    errorsArray[length] = externalDiameterError + '\n';
                }

                string internalDiameterError = this[nameof(InternalDiameter)];
                if (internalDiameterError != string.Empty)
                {
                    int length = errorsArray.Length;

                    Array.Resize(ref errorsArray, length + 1);
                    errorsArray[length] = internalDiameterError + '\n';
                }

                string errors = string.Empty;
                IEnumerable<string> errorsDictionary = errorsArray.Distinct();
                foreach (string error in errorsDictionary)
                {
                    errors += error;   
                }

                return errors;
            }
        }


        public RubberStripModel()
        {
            Material = new Rubber();
        }
    }
}