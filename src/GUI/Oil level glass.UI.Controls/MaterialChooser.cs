using System.ComponentModel;

namespace Oil_level_glass.UI.Controls
{
    public partial class MaterialChooser : UserControl
    {
        private string _header, _materialTitle;

        private double _density;
        private int _hatchStyle;

        public MaterialChooser()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        [Browsable(true)]
        [Category("Appearance")]
        public string Header
        {
            get { return _header; }
            set
            {
                _header = value;

                groupBox.Text = _header;
                this.Invalidate();
            }
        }

        [Browsable(true)]
        [Category("Appearance")]
        public string MaterialTitle
        {
            get { return _materialTitle; }
            set
            {
                _materialTitle = value;

                tbMaterialTitle.Text = _header;
                this.Invalidate();
            }
        }

        [Category("Appearance")]
        public double Density
        {
            get { return _density; }
            set
            {
                _density = value;

                tbDensity.Text = _density.ToString();
                this.Invalidate();
            }
        }

        [Category("Appearance")]
        public int HatchStyle
        {
            get { return _hatchStyle; }
            set
            {
                _hatchStyle = value;

                switch(_hatchStyle)
                {
                    case 1:
                        tbHatchStyle.Text = "Неметал";    
                        break;

                    case 2:
                        tbHatchStyle.Text = "Дерево";
                        break;
                    
                    case 3:
                        tbHatchStyle.Text = "Камень естественный";
                        break;
                    
                    case 4:
                        tbHatchStyle.Text = "Керамика";
                        break;
                    
                    case 5:
                        tbHatchStyle.Text = "Бетон";
                        break;
                    
                    case 6:
                        tbHatchStyle.Text = "Стекло";
                        break;
                    
                    case 7:
                        tbHatchStyle.Text = "Жидкость";
                        break;
                    
                    case 8:
                        tbHatchStyle.Text = "Естественный грунт";
                        break;
                    
                    case 9:
                        tbHatchStyle.Text = "Насыпной грунт";
                        break;
                    
                    case 10:
                        tbHatchStyle.Text = "Камень искусственный";
                        break;
                    
                    case 11:
                        tbHatchStyle.Text = "Железобетон";
                        break;
                    
                    case 12:
                        tbHatchStyle.Text = "Напряженный железобетон";
                        break;
                    
                    case 13:
                        tbHatchStyle.Text = "Дерево в продольном сечении";
                        break;

                    case 14:
                        tbHatchStyle.Text = "Песок";
                        break;
                    
                    default:
                        tbHatchStyle.Text = "Метал";
                        break;
                }

                this.Invalidate();
            }
        }
    }
}
