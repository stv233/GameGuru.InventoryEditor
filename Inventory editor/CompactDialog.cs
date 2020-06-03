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
    public partial class CompactDialog : Form
    {
        public bool DontAskAgain
        {
            get
            {
                return IcbDontAsk.Checked;
            }
        }

        public string MessageString
        {
            set
            {

                IlbMessage.Text = value;
            }

            get
            {
                return IlbMessage.Text;
            }
        }

        public string Title
        {
            set
            {
                this.Text = value;
            }

            get
            {
                return this.Text;
            }
        }

        public CompactDialog()
        {
            InitializeComponent();
        }
    }
}
