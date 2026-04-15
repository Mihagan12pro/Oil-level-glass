using Oil_level_glass.Model.Data.Entities.Parts.Classic;
using Oil_level_glass.UI.Abstractions.Editors.RubberStrip;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oil_level_glass.UI.Editors.RubberStrip
{
    public partial class RubberStripEditorForm : Form, IRubberStripForm
    {
        public RubberStripEditorForm()
        {
            InitializeComponent();
        }

        public RubberStripModel Model { get; set; }
    }
}
