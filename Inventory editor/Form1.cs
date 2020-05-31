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
        Image Selector = Properties.Resources.selector;

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
            IpbBackground.DoubleClick += SelectImage;

            // Зона предметов.

            IpbItemZone.Left = 32 * WPercent;
            IpbItemZone.Top = 1 * HPercent;
            IpbItemZone.Width = 67 * WPercent;
            IpbItemZone.Height = 68 * HPercent;
            IpbItemZone.DoubleClick += SelectImage;

            // Зона тела.
            IpbBodyzone.Left = 1 * WPercent;
            IpbBodyzone.Top = 1 * HPercent;
            IpbBodyzone.Width = 28 * WPercent;
            IpbBodyzone.Height = 58 * HPercent;
            IpbBodyzone.DoubleClick += SelectImage;

            // Зона описания.
            IpbDescriptionzone.Left = 32 * WPercent;
            IpbDescriptionzone.Top = 70 * HPercent;
            IpbDescriptionzone.Width = 67 * WPercent;
            IpbDescriptionzone.Height = 29 * HPercent;
            IpbDescriptionzone.DoubleClick += SelectImage;

            // Тело.
            IpbBody.Left = 2 * WPercent;
            IpbBody.Top = 2 * HPercent;
            IpbBody.Width = 26 * WPercent;
            IpbBody.Height = 56 * HPercent;
            IpbBody.DoubleClick += SelectImage;

            // Слот оружия 1.
            IpbWeaponSlot1.Left = 1 * WPercent;
            IpbWeaponSlot1.Top = 62 * HPercent;
            IpbWeaponSlot1.Width = 28 * WPercent;
            IpbWeaponSlot1.Height = 15 * HPercent;
            IpbWeaponSlot1.DoubleClick += SelectImage;

            // Слот оружия 2.
            IpbWeaponSlot2.Left = 1 * WPercent;
            IpbWeaponSlot2.Top = 81 * HPercent;
            IpbWeaponSlot2.Width = 28 * WPercent;
            IpbWeaponSlot2.Height = 15 * HPercent;
            IpbWeaponSlot2.DoubleClick += SelectImage;

            ReDrawEmptySlot();

        }

        private void ReDrawEmptySlot()
        {
            IpbItemZone.Controls.Clear();

            var IpbEmptySlot1 = new PictureBox
            {
                Image = EmptySlot,
                BackgroundImage = Properties.Resources.EmptyBackGround,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Left = Convert.ToInt32((IpbItemZone.Width / 4.5) / 3),
                Top = Convert.ToInt32((IpbItemZone.Height / 4.5) / 3),
                Width = Convert.ToInt32(IpbItemZone.Width / 4.5),
                Height = Convert.ToInt32(IpbItemZone.Height / 4.5),
                Parent = IpbItemZone
            };
            IpbEmptySlot1.DoubleClick += SelectImageEmptySlot;

            var IpbEmptySlot2 = new PictureBox
            {
                Image = EmptySlot,
                BackgroundImage = Properties.Resources.EmptyBackGround,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Left = Convert.ToInt32((((IpbItemZone.Width / 4.5) / 3) * 2) + (IpbItemZone.Width / 4.5)),
                Top = Convert.ToInt32((IpbItemZone.Height / 4.5) / 3),
                Width = Convert.ToInt32(IpbItemZone.Width / 4.5),
                Height = Convert.ToInt32(IpbItemZone.Height / 4.5),
                Parent = IpbItemZone
            };
            IpbEmptySlot2.DoubleClick += SelectImageEmptySlot;

            var IpbEmptySlot3 = new PictureBox
            {
                Image = EmptySlot,
                BackgroundImage = Properties.Resources.EmptyBackGround,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Left = Convert.ToInt32((((IpbItemZone.Width / 4.5) / 3) * 3) + ((IpbItemZone.Width / 4.5) * 2)),
                Top = Convert.ToInt32((IpbItemZone.Height / 4.5) / 3),
                Width = Convert.ToInt32(IpbItemZone.Width / 4.5),
                Height = Convert.ToInt32(IpbItemZone.Height / 4.5),
                Parent = IpbItemZone
            };
            IpbEmptySlot3.DoubleClick += SelectImageEmptySlot;

            var IpbEmptySlot4 = new PictureBox
            {
                Image = EmptySlot,
                BackgroundImage = Properties.Resources.EmptyBackGround,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Left = Convert.ToInt32((IpbItemZone.Width / 4.5) / 3),
                Top = Convert.ToInt32((((IpbItemZone.Height / 4.5) / 3) * 2) + (IpbItemZone.Height / 4.5)),
                Width = Convert.ToInt32(IpbItemZone.Width / 4.5),
                Height = Convert.ToInt32(IpbItemZone.Height / 4.5),
                Parent = IpbItemZone
            };
            IpbEmptySlot4.DoubleClick += SelectImageEmptySlot;

            var IpbEmptySlot5 = new PictureBox
            {
                Image = EmptySlot,
                BackgroundImage = Properties.Resources.EmptyBackGround,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Left = Convert.ToInt32((((IpbItemZone.Width / 4.5) / 3) * 2) + (IpbItemZone.Width / 4.5)),
                Top = Convert.ToInt32((((IpbItemZone.Height / 4.5) / 3) * 2) + (IpbItemZone.Height / 4.5)),
                Width = Convert.ToInt32(IpbItemZone.Width / 4.5),
                Height = Convert.ToInt32(IpbItemZone.Height / 4.5),
                Parent = IpbItemZone
            };
            IpbEmptySlot5.DoubleClick += SelectImageEmptySlot;

            var IpbEmptySlot6 = new PictureBox
            {
                Image = EmptySlot,
                BackgroundImage = Properties.Resources.EmptyBackGround,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Left = Convert.ToInt32((((IpbItemZone.Width / 4.5) / 3) * 3) + ((IpbItemZone.Width / 4.5) * 2)),
                Top = Convert.ToInt32((((IpbItemZone.Height / 4.5) / 3) * 2) + (IpbItemZone.Height / 4.5)),
                Width = Convert.ToInt32(IpbItemZone.Width / 4.5),
                Height = Convert.ToInt32(IpbItemZone.Height / 4.5),
                Parent = IpbItemZone
            };
            IpbEmptySlot6.DoubleClick += SelectImageEmptySlot;

            var IpbEmptySlot7 = new PictureBox
            {
                Image = EmptySlot,
                BackgroundImage = Properties.Resources.EmptyBackGround,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Left = Convert.ToInt32((IpbItemZone.Width / 4.5) / 3),
                Top = Convert.ToInt32((((IpbItemZone.Height / 4.5) / 3) * 3) + ((IpbItemZone.Height / 4.5) * 2)),
                Width = Convert.ToInt32(IpbItemZone.Width / 4.5),
                Height = Convert.ToInt32(IpbItemZone.Height / 4.5),
                Parent = IpbItemZone
            };
            IpbEmptySlot7.DoubleClick += SelectImageEmptySlot;

            var IpbEmptySlot8 = new PictureBox
            {
                Image = EmptySlot,
                BackgroundImage = Properties.Resources.EmptyBackGround,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Left = Convert.ToInt32((((IpbItemZone.Width / 4.5) / 3) * 2) + (IpbItemZone.Width / 4.5)),
                Top = Convert.ToInt32((((IpbItemZone.Height / 4.5) / 3) * 3) + ((IpbItemZone.Height / 4.5) * 2)),
                Width = Convert.ToInt32(IpbItemZone.Width / 4.5),
                Height = Convert.ToInt32(IpbItemZone.Height / 4.5),
                Parent = IpbItemZone
            };
            IpbEmptySlot8.DoubleClick += SelectImageEmptySlot;

            var IpbEmptySlot9 = new PictureBox
            {
                Image = EmptySlot,
                BackgroundImage = Properties.Resources.EmptyBackGround,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Left = Convert.ToInt32((((IpbItemZone.Width / 4.5) / 3) * 3) + ((IpbItemZone.Width / 4.5) * 2)),
                Top = Convert.ToInt32((((IpbItemZone.Height / 4.5) / 3) * 3) + ((IpbItemZone.Height / 4.5) * 2)),
                Width = Convert.ToInt32(IpbItemZone.Width / 4.5),
                Height = Convert.ToInt32(IpbItemZone.Height / 4.5),
                Parent = IpbItemZone
            };
            IpbEmptySlot9.DoubleClick += SelectImageEmptySlot;

            var IpbSelector = new PictureBox
            {
                Image = Selector,
                BackgroundImage = Properties.Resources.EmptyBackGround,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Left = IpbEmptySlot1.Left - (1 * WPercent),
                Top = IpbEmptySlot1.Top - (1 * HPercent),
                Width = IpbEmptySlot1.Width + (2 * WPercent),
                Height = IpbEmptySlot1.Height + (2 * HPercent),
                Parent = IpbItemZone
            };
            IpbSelector.SendToBack();
        }

        private void SelectImage(object sender, EventArgs e)
        {
            var TIpbPictureBox = (PictureBox)sender;
            var TIofdOpen = new OpenFileDialog
            {
                Title = "Загрузить изображение",
                Filter = "PNG (*.png)|*.png|JPEG (*.jpg;*.jpeg;*.jpe;*jfif)|*.jpg;*.jpeg;*.jpe;*.jfif|Все файлы (*.*)|*.*"
            };

            if (TIofdOpen.ShowDialog() == DialogResult.OK)
            {
                var TBitMap = new Bitmap(TIofdOpen.FileName);
                TIpbPictureBox.Image = (Image)TBitMap;
            }
        }

        private void SelectImageEmptySlot(object sender, EventArgs e)
        {
            var TIpbPictureBox = (PictureBox)sender;
            var TIofdOpen = new OpenFileDialog
            {
                Title = "Загрузить изображение",
                Filter = "PNG (*.png)|*.png|JPEG (*.jpg;*.jpeg;*.jpe;*jfif)|*.jpg;*.jpeg;*.jpe;*.jfif|Все файлы (*.*)|*.*"
            };

            if (TIofdOpen.ShowDialog() == DialogResult.OK)
            {
                var TBitMap = new Bitmap(TIofdOpen.FileName);
                EmptySlot = (Image)TBitMap;
            }

            ReDrawEmptySlot();
        }
    }
}
