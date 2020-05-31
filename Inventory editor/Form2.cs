using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_editor
{
    public partial class ExportDialog : Form
    {
        private string name;

        public string StyleName
        {
            get
            {
                return name;
            }
        }
        public ExportDialog()
        {
            InitializeComponent();
        }

        private void IbtOk_Click(object sender, EventArgs e)
        {
            name = ItbStyleName.Text;
        }
    }
}
