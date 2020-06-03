using Inventory_editor.Properties;
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
        bool Ask;
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
            var Sett = new Settings();
            Timer++;
            if (Timer > 2)
            {
                IlbStatus.Text = "Initialization";    
                if (Timer > 6)
                {
                    if (Arg.Count() == 0)
                    {
                        if (Sett.CompactMod)
                        {
                            var TIfrMain = new IfrCompact();
                            TIfrMain.Show();
                            this.Hide();
                            ItmStart.Stop();
                        }
                        else
                        {
                            var TIfrMain = new IfrMain();
                            TIfrMain.Show();
                            this.Hide();
                            ItmStart.Stop();
                        }
                    }
                    else
                    {
                        if (Sett.CompactMod)
                        {
                            var TIfrMain = new IfrCompact();
                            TIfrMain.Show();
                            TIfrMain.Open(Arg[0]);
                            this.Hide();
                            ItmStart.Stop();
                        }
                        else
                        {
                            var TIfrMain = new IfrMain();
                            TIfrMain.Show();
                            TIfrMain.Open(Arg[0]);
                            this.Hide();
                            ItmStart.Stop();
                        }
                    }
                }
            }
           
        }

        private void IfrLoadScreen_Load(object sender, EventArgs e)
        {
            Size TResolution = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Size;
            var Sett = new Settings();
            if ((TResolution.Width < 1536) || (TResolution.Height < 864))
            {
                if (Sett.Ask == false)
                {
                    if (Ask == false)
                    {
                        ItmStart.Stop();
                        Ask = true;
                        var TIDialog = new CompactDialog();
                        if (TIDialog.ShowDialog() == DialogResult.Yes)
                        {
                            ItmStart.Start();

                            Sett.CompactMod = true;

                            Sett.Ask = TIDialog.DontAskAgain;

                            Sett.Save();

                            ItmStart.Start();

                        }
                        else
                        {
                            Sett.CompactMod = false;
                            Sett.Save();
                            ItmStart.Start();
                        }
                    }
                }
                else
                {
                    ItmStart.Start();
                }
            }
            else
            {
                ItmStart.Start();
            }
        }
    }
}
