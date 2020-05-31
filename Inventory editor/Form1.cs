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
    public partial class IfrMain : Form
    {
        public IfrMain()
        {
            InitializeComponent();
        }

        int WPercent;
        int HPercent;
        Image EmptySlot = Properties.Resources.emptyslot;

        private void IfrMain_Load(object sender, EventArgs e)
        {
            WPercent = Convert.ToInt32(ItpInventory.ClientSize.Width / 100);
            HPercent = Convert.ToInt32(ItpInventory.ClientSize.Height / 100);

            // Расстановка по дефолтным позициям.

            // Фон.
            IpbBackground.Left = 0 * WPercent;
            IpbBackground.Top = 0 * HPercent;
            IpbBackground.Width = 100 * WPercent;
            IpbBackground.Height = 100 * HPercent;

            // Зона предметов.

            IpbItemZone.Left = 32 * WPercent;
            IpbItemZone.Top = 1 * HPercent;
            IpbItemZone.Width = 67 * WPercent;
            IpbItemZone.Height = 68 * HPercent;

            // Зона тела.
            IpbBodyzone.Left = 1 * WPercent;
            IpbBodyzone.Top = 1 * HPercent;
            IpbBodyzone.Width = 28 * WPercent;
            IpbBodyzone.Height = 58 * HPercent;

            // Зона описания.
            IpbDescriptionzone.Left = 32 * WPercent;
            IpbDescriptionzone.Top = 70 * HPercent;
            IpbDescriptionzone.Width = 67 * WPercent;
            IpbDescriptionzone.Height = 29 * HPercent;

            // Тело.
            IpbBody.Left = 2 * WPercent;
            IpbBody.Top = 2 * HPercent;
            IpbBody.Width = 26 * WPercent;
            IpbBody.Height = 56 * HPercent;

            // Слот оружия 1.
            IpbWeaponSlot1.Left = 1 * WPercent;
            IpbWeaponSlot1.Top = 62 * HPercent;
            IpbWeaponSlot1.Width = 28 * WPercent;
            IpbWeaponSlot1.Height = 15 * HPercent;

            // Слот оружия 2.
            IpbWeaponSlot2.Left = 1 * WPercent;
            IpbWeaponSlot2.Top = 81 * HPercent;
            IpbWeaponSlot2.Width = 28 * WPercent;
            IpbWeaponSlot2.Height = 15 * HPercent;

        }

        private void DrawEmptySlot()
        {
            for (var i = 0; i < IpbItemZone.Controls.Count; i++)
            {
                ((PictureBox)(IpbItemZone.Controls[i])).Dispose();
            }
        }
    }
}
