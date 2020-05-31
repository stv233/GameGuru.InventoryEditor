using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
        Image Description = Properties.Resources.descriptionzone;

        private struct Mouse
        {
            public Mouse(bool isclicked, bool changesize, int x, int y)
            {
                IsClicked = isclicked;
                ChangeSize = changesize;
                X = x;
                Y = y;
            }
            public bool IsClicked;
            public bool ChangeSize;
            public int X;
            public int Y;
        }


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
            IpbBackground.Tag = new Mouse(false, false, 0, 0);

            // Зона предметов.
            IpbItemZone.Left = 32 * WPercent;
            IpbItemZone.Top = 1 * HPercent;
            IpbItemZone.Width = 67 * WPercent;
            IpbItemZone.Height = 68 * HPercent;
            IpbItemZone.DoubleClick += SelectImage;
            IpbItemZone.Tag = new Mouse(false, false, 0, 0);
            IpbItemZone.MouseDown += Moved_MouseDown;
            IpbItemZone.MouseMove += Moved_MouseMove;
            IpbItemZone.MouseUp += Moved_MouseUp;
            IpbItemZone.Cursor = System.Windows.Forms.Cursors.Arrow;

            // Зона тела.
            IpbBodyzone.Left = 1 * WPercent;
            IpbBodyzone.Top = 1 * HPercent;
            IpbBodyzone.Width = 28 * WPercent;
            IpbBodyzone.Height = 58 * HPercent;
            IpbBodyzone.DoubleClick += SelectImage;
            IpbBodyzone.Tag = new Mouse(false, false, 0, 0);
            IpbBodyzone.MouseDown += Moved_MouseDown;
            IpbBodyzone.MouseMove += Moved_MouseMove;
            IpbBodyzone.MouseUp += Moved_MouseUp;
            IpbBodyzone.Cursor = System.Windows.Forms.Cursors.Arrow;

            // Зона описания.
            IpbDescriptionzone.Left = 32 * WPercent;
            IpbDescriptionzone.Top = 70 * HPercent;
            IpbDescriptionzone.Width = 67 * WPercent;
            IpbDescriptionzone.Height = 29 * HPercent;
            Graphics g = Graphics.FromImage(IpbDescriptionzone.Image);
            g.DrawString("Description of item.", new Font("MV Boli", 45, FontStyle.Bold), new SolidBrush(Color.Blue), WPercent, HPercent);
            IpbDescriptionzone.Invalidate();
            IpbDescriptionzone.DoubleClick += DescriptionSelectImage;
            IpbDescriptionzone.Tag = new Mouse(false, false, 0, 0);
            IpbDescriptionzone.MouseDown += Moved_MouseDown;
            IpbDescriptionzone.MouseMove += Moved_MouseMove;
            IpbDescriptionzone.MouseUp += Moved_MouseUp;
            IpbDescriptionzone.Cursor = System.Windows.Forms.Cursors.Arrow;


            // Тело.
            IpbBody.Left = 2 * WPercent;
            IpbBody.Top = 2 * HPercent;
            IpbBody.Width = 26 * WPercent;
            IpbBody.Height = 56 * HPercent;
            IpbBody.DoubleClick += SelectImage;
            IpbBody.Tag = new Mouse(false, false, 0, 0);
            IpbBody.MouseDown += Moved_MouseDown;
            IpbBody.MouseMove += Moved_MouseMove;
            IpbBody.MouseUp += Moved_MouseUp;
            IpbBody.Cursor = System.Windows.Forms.Cursors.Arrow;

            // Слот оружия 1.
            IpbWeaponSlot1.Left = 1 * WPercent;
            IpbWeaponSlot1.Top = 62 * HPercent;
            IpbWeaponSlot1.Width = 28 * WPercent;
            IpbWeaponSlot1.Height = 15 * HPercent;
            IpbWeaponSlot1.DoubleClick += SelectImage;
            IpbWeaponSlot1.Tag = new Mouse(false, false, 0, 0);
            IpbWeaponSlot1.MouseDown += Moved_MouseDown;
            IpbWeaponSlot1.MouseMove += Moved_MouseMove;
            IpbWeaponSlot1.MouseUp += Moved_MouseUp;
            IpbWeaponSlot1.Cursor = System.Windows.Forms.Cursors.Arrow;

            // Слот оружия 2.
            IpbWeaponSlot2.Left = 1 * WPercent;
            IpbWeaponSlot2.Top = 81 * HPercent;
            IpbWeaponSlot2.Width = 28 * WPercent;
            IpbWeaponSlot2.Height = 15 * HPercent;
            IpbWeaponSlot2.DoubleClick += SelectImage;
            IpbWeaponSlot2.Tag = new Mouse(false, false, 0, 0);
            IpbWeaponSlot2.MouseDown += Moved_MouseDown;
            IpbWeaponSlot2.MouseMove += Moved_MouseMove;
            IpbWeaponSlot2.MouseUp += Moved_MouseUp;
            IpbWeaponSlot2.Cursor = System.Windows.Forms.Cursors.Arrow;

            ReDrawEmptySlot();


            // Селектор
            IpbSelector.Image = Selector;
            IpbUse.Image = Properties.Resources.use;
            IpbUse.Click += SelectImage;
            IpbEquip.Image = Properties.Resources.equip;
            IpbEquip.Click += SelectImage;
            IpbUnEquip.Image = Properties.Resources.unequip;
            IpbUnEquip.Click += SelectImage;
            IpbDelete.Image = Properties.Resources.delete;
            IpbDelete.Click += SelectImage;

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
                Cursor = System.Windows.Forms.Cursors.Arrow,
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
                Cursor = System.Windows.Forms.Cursors.Arrow,
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
                Cursor = System.Windows.Forms.Cursors.Arrow,
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
                Cursor = System.Windows.Forms.Cursors.Arrow,
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
                Cursor = System.Windows.Forms.Cursors.Arrow,
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
                Cursor = System.Windows.Forms.Cursors.Arrow,
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
                Cursor = System.Windows.Forms.Cursors.Arrow,
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
                Cursor = System.Windows.Forms.Cursors.Arrow,
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
                Cursor = System.Windows.Forms.Cursors.Arrow,
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

        private void DescriptionSelectImage(object sender, EventArgs e)
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
                Description = (Image)TBitMap;
                IpbDescriptionzone.Image = Description;
                Graphics g = Graphics.FromImage(IpbDescriptionzone.Image);
                g.DrawString("Description of item.", new Font("MV Boli", 45, FontStyle.Bold), new SolidBrush(Color.Blue), WPercent, HPercent);
                IpbDescriptionzone.Invalidate();
            }
        }

        private void Moved_MouseDown(object sender, MouseEventArgs e)
        {
            var TIpbPictureBox = (PictureBox)sender;
            var TMouse = (Mouse)TIpbPictureBox.Tag;
            if (((TIpbPictureBox.Width - e.X) <= 10) && ((TIpbPictureBox.Height - e.Y) <= 10))
            {
                TIpbPictureBox.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
                TMouse.ChangeSize = true;
                TIpbPictureBox.Tag = TMouse;
            }
            else
            {
                TIpbPictureBox.Cursor = System.Windows.Forms.Cursors.SizeAll;
                TMouse.IsClicked = true;
                TMouse.X = e.X;
                TMouse.Y = e.Y;
                TIpbPictureBox.Tag = TMouse;
            }
        }

        private void Moved_MouseMove(object sender, MouseEventArgs e)
        {
            var TIpbPictureBox = (PictureBox)sender;
            if (((Mouse)TIpbPictureBox.Tag).IsClicked)
            {
                TIpbPictureBox.Left = TIpbPictureBox.Left + (e.X - ((Mouse)TIpbPictureBox.Tag).X);
                TIpbPictureBox.Top = TIpbPictureBox.Top + (e.Y - ((Mouse)TIpbPictureBox.Tag).Y);
            }

            else if (((Mouse)TIpbPictureBox.Tag).ChangeSize)
            {
                TIpbPictureBox.Width = e.X;
                TIpbPictureBox.Height = e.Y;
            }

            else
            {
                if (((TIpbPictureBox.Width - e.X) <= 10) && ((TIpbPictureBox.Height - e.Y) <= 10))
                {
                    TIpbPictureBox.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
                }
                else
                {
                    TIpbPictureBox.Cursor = System.Windows.Forms.Cursors.Arrow;
                }
            }
        }

        private void Moved_MouseUp(object sender, MouseEventArgs e)
        {
            var TIpbPictureBox = (PictureBox)sender;
            TIpbPictureBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            var TMouse = (Mouse)TIpbPictureBox.Tag;
            TMouse.IsClicked = false;
            TMouse.ChangeSize = false;
            TMouse.X = e.X;
            TMouse.Y = e.Y;
            TIpbPictureBox.Tag = TMouse;
        }

        private void IpbItemZone_Resize(object sender, EventArgs e)
        {
            ReDrawEmptySlot();
        }

        private void IpbSelector_Click(object sender, EventArgs e)
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
                Selector = (Image)TBitMap;
            }

            TIpbPictureBox.Image = Selector;
            ReDrawEmptySlot();
        }
    }
}
