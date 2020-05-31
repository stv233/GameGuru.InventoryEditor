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
    public partial class IfrLoadScreen : Form
    {
        int Timer;
        string[] Arg;
        public IfrLoadScreen(string [] arg)
        {
            InitializeComponent();
            Arg = arg;
        }

        private void IlbSite_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://stv233.pro/en");
        }

        private void ItmStart_Tick(object sender, EventArgs e)
        {
            IfrMain TIfrMain;
            Timer++;
            if (Timer > 2)
            {
                IlbStatus.Text = "Initialization";
                TIfrMain = new IfrMain();
                if (Timer > 6)
                {
                    if (Arg.Count() == 0)
                    {
                        TIfrMain.Show();
                        this.Hide();
                        ItmStart.Stop();
                    }
                    else
                    {
                        TIfrMain.Show();
                        TIfrMain.Open(Arg[0]);
                        this.Hide();
                        ItmStart.Stop();
                    }
                }
            }
           
        }
    }
}
