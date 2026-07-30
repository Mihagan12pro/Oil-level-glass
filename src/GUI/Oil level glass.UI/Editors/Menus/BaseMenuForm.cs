using Oil_level_glass.Model.Data.Other;

namespace Oil_level_glass.UI.Editors.Menus
{
    public class BaseMenuForm<T> : Form
    {
        public required T Housing { get; set; }

        public required T Glass { get; set; }

        public required T RubberStrip { get; set; }

        protected Button btApply = new Button()
        {
            Text = "Применить",

            Enabled = false
        };

        protected Button btCancel = new Button()
        {
            Text = "Отмена"
        };

        protected ComboBox cbChoosePart = new ComboBox()
        {
            
        };

        public BaseMenuForm()
        {
            cbChoosePart.Items.Add("Корпус");
            cbChoosePart.Items.Add("Линза");
            cbChoosePart.Items.Add("Прокладка");

            btApply.Click += btApply_Click;
            btCancel.Click += btCancel_Click;

            cbChoosePart.SelectedIndexChanged += CbChoosePart_SelectedIndexChanged;
        }

        private void btCancel_Click(object? sender, EventArgs e)
        {
            if (cbChoosePart.SelectedIndex != -1)
            {
                switch (cbChoosePart.SelectedIndex)
                {
                    case 0:
                        {
                            SetControlsValues(Housing);

                            break;
                        }

                    case 1:
                        {
                            SetControlsValues(Glass);

                            break;
                        }

                    case 2:
                        {
                            SetControlsValues(RubberStrip);

                            break;
                        }
                }
            }
        }

        protected virtual void CbChoosePart_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (cbChoosePart.SelectedIndex != -1)
            {
                MakeControlsEnabled();

                switch (cbChoosePart.SelectedIndex)
                {
                    case 0:
                        {
                            SetControlsValues(Housing);

                            break;
                        }

                    case 1:
                        {
                            SetControlsValues(Glass);

                            break;
                        }

                    case 2:
                        {
                            SetControlsValues(RubberStrip);

                            break;
                        }
                }
            }
        }

        protected virtual void btApply_Click(object? sender, EventArgs e)
        {
            switch (cbChoosePart.SelectedIndex)
            {
                case 0:
                    {
                        GetControlsValues(Housing);
                        
                        break;
                    }

                case 1:
                    {
                        GetControlsValues(Glass);

                        break;
                    }

                case 2:
                    {
                        GetControlsValues(RubberStrip);

                        break;
                    }
            }
        }

        protected virtual void SetControlsValues(T t)
        {

        }

        protected virtual void GetControlsValues(T t)
        {

        }

        protected virtual void MakeControlsEnabled()
        {
            btApply.Enabled = true;
        }
    }
}
