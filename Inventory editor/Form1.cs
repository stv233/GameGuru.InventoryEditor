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
using System.IO;
using System.IO.Compression;

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
        Image[] Numbers = new Image[100];

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
            var IttTip = new ToolTip();

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
            IttTip.SetToolTip(IpbBackground,"Background");

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
            IttTip.SetToolTip(IpbItemZone, "Item zone");

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
            IttTip.SetToolTip(IpbBodyzone, "Decoration zone");

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
            IttTip.SetToolTip(IpbDescriptionzone, "Description zone");


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
            IttTip.SetToolTip(IpbBody, "Decoration");

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
            IttTip.SetToolTip(IpbWeaponSlot1, "Weapon Slot 1");

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
            IttTip.SetToolTip(IpbWeaponSlot2, "Weapon Slot 2");

            ReDrawEmptySlot();
            IbtGenerate_Click(sender, e);


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

        private void ResetLocation()
        {
            IpbBackground.Left = 0 * WPercent;
            IpbBackground.Top = 0 * HPercent;
            IpbBackground.Width = 100 * WPercent;
            IpbBackground.Height = 100 * HPercent;
            IpbItemZone.Left = 32 * WPercent;
            IpbItemZone.Top = 1 * HPercent;
            IpbItemZone.Width = 67 * WPercent;
            IpbItemZone.Height = 68 * HPercent;
            IpbBodyzone.Left = 1 * WPercent;
            IpbBodyzone.Top = 1 * HPercent;
            IpbBodyzone.Width = 28 * WPercent;
            IpbBodyzone.Height = 58 * HPercent;
            IpbDescriptionzone.Left = 32 * WPercent;
            IpbDescriptionzone.Top = 70 * HPercent;
            IpbDescriptionzone.Width = 67 * WPercent;
            IpbDescriptionzone.Height = 29 * HPercent;
            IpbBody.Left = 2 * WPercent;
            IpbBody.Top = 2 * HPercent;
            IpbBody.Width = 26 * WPercent;
            IpbBody.Height = 56 * HPercent;
            IpbWeaponSlot1.Left = 1 * WPercent;
            IpbWeaponSlot1.Top = 62 * HPercent;
            IpbWeaponSlot1.Width = 28 * WPercent;
            IpbWeaponSlot1.Height = 15 * HPercent;
            IpbWeaponSlot2.Left = 1 * WPercent;
            IpbWeaponSlot2.Top = 81 * HPercent;
            IpbWeaponSlot2.Width = 28 * WPercent;
            IpbWeaponSlot2.Height = 15 * HPercent;
        }

        private void ResetImages()
        {
            IpbBackground.Image = Properties.Resources.background;
            IpbItemZone.Image = Properties.Resources.itemzone;
            IpbBodyzone.Image = Properties.Resources.bodyzone;
            Description = Properties.Resources.descriptionzone;
            IpbDescriptionzone.Image = Description;
            Graphics g = Graphics.FromImage(IpbDescriptionzone.Image);
            g.DrawString("Description of item.", new Font("MV Boli", 45, FontStyle.Bold), new SolidBrush(Color.Blue), WPercent, HPercent);
            IpbBody.Image = Properties.Resources.body;
            IpbWeaponSlot1.Image = Properties.Resources.weaponslot1;
            IpbWeaponSlot2.Image = Properties.Resources.weaponslot2;
            EmptySlot = Properties.Resources.emptyslot;
            Selector = Properties.Resources.selector;
            IpbSelector.Image = Selector;
            ReDrawEmptySlot();
            IpbEquip.Image = Properties.Resources.equip;
            IpbUse.Image = Properties.Resources.use;
            IpbUnEquip.Image = Properties.Resources.unequip;
            IpbDelete.Image = Properties.Resources.delete;
        }

        private void ReDrawEmptySlot()
        {
            var IttTip = new ToolTip();
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
            IttTip.SetToolTip(IpbEmptySlot1, "Empty Slot");

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
            IttTip.SetToolTip(IpbEmptySlot2, "Empty Slot");

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
            IttTip.SetToolTip(IpbEmptySlot3, "Empty Slot");

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
            IttTip.SetToolTip(IpbEmptySlot4, "Empty Slot");

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
            IttTip.SetToolTip(IpbEmptySlot5, "Empty Slot");

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
            IttTip.SetToolTip(IpbEmptySlot6, "Empty Slot");

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
            IttTip.SetToolTip(IpbEmptySlot7, "Empty Slot");

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
            IttTip.SetToolTip(IpbEmptySlot8, "Empty Slot");

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
            IttTip.SetToolTip(IpbEmptySlot9, "Empty Slot");

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

        private void IlbColor_Click(object sender, EventArgs e)
        {
            var TIlbLabel = (Label)sender;
            var TIcdColor = new ColorDialog();
            if (TIcdColor.ShowDialog() == DialogResult.OK)
            {
                TIlbLabel.BackColor = TIcdColor.Color;
            }
        }

        private void Generate()
        {

            for (var i = 0; i < 99; i++)
            {
                Bitmap TBitMap = new Bitmap(500, 500);
                Image TImage = (Image)TBitMap;
                Graphics g = Graphics.FromImage(TImage);
                if (i + 1 < 10)
                {
                    using (var font = new Font(ItbFontName.Text, 250, FontStyle.Bold))
                    {
                        using (var brush = new SolidBrush(IlbColor.BackColor))
                        {
                            g.DrawString("0" + (i + 1).ToString(), font, brush, 0, 45);
                        }
                    }
                }
                else
                {
                    using (var font = new Font(ItbFontName.Text, 250, FontStyle.Bold))
                    {
                        using (var brush = new SolidBrush(IlbColor.BackColor))
                        {
                            g.DrawString((i + 1).ToString(), font, brush, 0, 45);
                        }
                    }
                }   
                Numbers[i] = TImage;
            }
            Bitmap TTBitMap = new Bitmap(500, 500);
            Image TTImage = (Image)TTBitMap;
            Graphics gr = Graphics.FromImage(TTImage);
            gr.DrawString("99+", new Font(ItbFontName.Text, 190, FontStyle.Bold), new SolidBrush(IlbColor.BackColor), 0, 80);
            Numbers[99] = TTImage;
        }

        private void IbtGenerate_Click(object sender, EventArgs e)
        {
            Generate();
            IpbNumber1.Image = Numbers[0];
            IpbNumber2.Image = Numbers[1];
            IpbNumber3.Image = Numbers[2];
            IpbNumber4.Image = Numbers[3];
            IpbNumber5.Image = Numbers[4];
            IpbNumber99AndMore.Image = Numbers[99];
            IpbNumber99.Image = Numbers[98];
            IpbNumber98.Image = Numbers[97];
            IpbNumber97.Image = Numbers[96];
            IpbNumber96.Image = Numbers[95];
        }

        private void Save(string path)
        {
            string Appdata = System.Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData);
            string TempPath = Appdata + "\\Inventory editor\\Saving";
            Directory.CreateDirectory(TempPath);

            IpbBackground.Image.Save(TempPath + "\\background", System.Drawing.Imaging.ImageFormat.Png);
            IpbBody.Image.Save(TempPath + "\\body", System.Drawing.Imaging.ImageFormat.Png);
            IpbBodyzone.Image.Save(TempPath + "\\bodyzone", System.Drawing.Imaging.ImageFormat.Png);
            IpbDelete.Image.Save(TempPath + "\\delete", System.Drawing.Imaging.ImageFormat.Png);
            Description.Save(TempPath + "\\descriptionzone", System.Drawing.Imaging.ImageFormat.Png);
            EmptySlot.Save(TempPath + "\\emptyslot", System.Drawing.Imaging.ImageFormat.Png);
            IpbEquip.Image.Save(TempPath + "\\equip", System.Drawing.Imaging.ImageFormat.Png);
            IpbItemZone.Image.Save(TempPath + "\\itemzone", System.Drawing.Imaging.ImageFormat.Png);
            Selector.Save(TempPath + "\\selector", System.Drawing.Imaging.ImageFormat.Png);
            IpbUnEquip.Image.Save(TempPath + "\\unequip", System.Drawing.Imaging.ImageFormat.Png);
            IpbUse.Image.Save(TempPath + "\\use", System.Drawing.Imaging.ImageFormat.Png);
            IpbWeaponSlot1.Image.Save(TempPath + "\\weaponslot1", System.Drawing.Imaging.ImageFormat.Png);
            IpbWeaponSlot2.Image.Save(TempPath + "\\weaponslot2", System.Drawing.Imaging.ImageFormat.Png);

            //Directory.CreateDirectory(TempPath + "\\Numbers\\");
            //for (var i = 0; i < 100; i++)
            //{
            //    var Temp = (Image)(Bitmap)Numbers[i];
            //    Temp.Save(TempPath + "\\Numbers\\" + i.ToString(), System.Drawing.Imaging.ImageFormat.Png);

            //}

            File.Create(TempPath + "\\styleinfo").Close();
            StreamWriter SW = File.AppendText(TempPath + "\\styleinfo");
            SW.WriteLine(IpbBackground.Left.ToString());
            SW.WriteLine(IpbBackground.Top.ToString());
            SW.WriteLine(IpbBackground.Width.ToString());
            SW.WriteLine(IpbBackground.Height.ToString());
            SW.WriteLine(IpbItemZone.Left.ToString());
            SW.WriteLine(IpbItemZone.Top.ToString());
            SW.WriteLine(IpbItemZone.Width.ToString());
            SW.WriteLine(IpbItemZone.Height.ToString());
            SW.WriteLine(IpbBodyzone.Left.ToString());
            SW.WriteLine(IpbBodyzone.Top.ToString());
            SW.WriteLine(IpbBodyzone.Width.ToString());
            SW.WriteLine(IpbBodyzone.Height.ToString());
            SW.WriteLine(IpbDescriptionzone.Left.ToString());
            SW.WriteLine(IpbDescriptionzone.Top.ToString());
            SW.WriteLine(IpbDescriptionzone.Width.ToString());
            SW.WriteLine(IpbDescriptionzone.Height.ToString());
            SW.WriteLine(IpbBody.Left.ToString());
            SW.WriteLine(IpbBody.Top.ToString());
            SW.WriteLine(IpbBody.Width.ToString());
            SW.WriteLine(IpbBody.Height);
            SW.WriteLine(IpbWeaponSlot1.Left.ToString());
            SW.WriteLine(IpbWeaponSlot1.Top.ToString());
            SW.WriteLine(IpbWeaponSlot1.Width.ToString());
            SW.WriteLine(IpbWeaponSlot1.Height.ToString());
            SW.WriteLine(IpbWeaponSlot2.Left.ToString());
            SW.WriteLine(IpbWeaponSlot2.Top.ToString());
            SW.WriteLine(IpbWeaponSlot2.Width.ToString());
            SW.WriteLine(IpbWeaponSlot2.Height.ToString());
            SW.WriteLine(ItbFontName.Text);
            SW.WriteLine((ColorTranslator.ToHtml(IlbColor.BackColor)).ToString());
            SW.Close();

            try
            {
                ZipFile.CreateFromDirectory(TempPath, path);
            }
            catch(System.IO.IOException)
            {
                File.Delete(path);
                ZipFile.CreateFromDirectory(TempPath, path);
            }
            Directory.Delete(TempPath, true);
        }

        public void Open(string path)
        {
            string Appdata = System.Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData);
            string TempPath = Appdata + "\\Inventory editor\\Opening";
            try
            {
                try
                {
                    ZipFile.ExtractToDirectory(path, TempPath);
                }
                catch (System.IO.IOException)
                {
                    Directory.Delete(TempPath, true);
                    ZipFile.ExtractToDirectory(path, TempPath);
                }


                using (var filestrem = new FileStream(TempPath + "\\background", FileMode.Open))
                {
                    IpbBackground.Image = Image.FromStream(filestrem);
                }

                using (var filestrem = new FileStream(TempPath + "\\body", FileMode.Open))
                {
                    IpbBody.Image = Image.FromStream(filestrem);
                }

                using (var filestrem = new FileStream(TempPath + "\\bodyzone", FileMode.Open))
                {
                    IpbBodyzone.Image = Image.FromStream(filestrem);
                }

                using (var filestrem = new FileStream(TempPath + "\\delete", FileMode.Open))
                {
                    IpbDelete.Image = Image.FromStream(filestrem);
                }

                using (var filestrem = new FileStream(TempPath + "\\descriptionzone", FileMode.Open))
                {
                    Description = Image.FromStream(filestrem);
                    IpbDescriptionzone.Image = Description;
                    Graphics g = Graphics.FromImage(IpbDescriptionzone.Image);
                    g.DrawString("Description of item.", new Font("MV Boli", 45, FontStyle.Bold), new SolidBrush(Color.Blue), WPercent, HPercent);
                }

                using (var filestrem = new FileStream(TempPath + "\\emptyslot", FileMode.Open))
                {
                    EmptySlot = Image.FromStream(filestrem);
                    ReDrawEmptySlot();
                }

                using (var filestrem = new FileStream(TempPath + "\\equip", FileMode.Open))
                {
                    IpbEquip.Image = Image.FromStream(filestrem);
                }

                using (var filestrem = new FileStream(TempPath + "\\itemzone", FileMode.Open))
                {
                    IpbItemZone.Image = Image.FromStream(filestrem);
                }

                using (var filestrem = new FileStream(TempPath + "\\selector", FileMode.Open))
                {
                    Selector = Image.FromStream(filestrem);
                    IpbSelector.Image = Selector;
                    ReDrawEmptySlot();
                }

                using (var filestrem = new FileStream(TempPath + "\\unequip", FileMode.Open))
                {
                    IpbUnEquip.Image = Image.FromStream(filestrem);
                }

                using (var filestrem = new FileStream(TempPath + "\\use", FileMode.Open))
                {
                    IpbUse.Image = Image.FromStream(filestrem);
                }

                using (var filestrem = new FileStream(TempPath + "\\weaponslot1", FileMode.Open))
                {
                    IpbWeaponSlot1.Image = Image.FromStream(filestrem);
                }

                using (var filestrem = new FileStream(TempPath + "\\weaponslot2", FileMode.Open))
                {
                    IpbWeaponSlot2.Image = Image.FromStream(filestrem);
                }


                StreamReader SR = new StreamReader(TempPath + "\\styleinfo");

                IpbBackground.Left = Convert.ToInt32(SR.ReadLine());
                IpbBackground.Top = Convert.ToInt32(SR.ReadLine());
                IpbBackground.Width = Convert.ToInt32(SR.ReadLine());
                IpbBackground.Height = Convert.ToInt32(SR.ReadLine());
                IpbItemZone.Left = Convert.ToInt32(SR.ReadLine());
                IpbItemZone.Top = Convert.ToInt32(SR.ReadLine());
                IpbItemZone.Width = Convert.ToInt32(SR.ReadLine());
                IpbItemZone.Height = Convert.ToInt32(SR.ReadLine());
                IpbBodyzone.Left = Convert.ToInt32(SR.ReadLine());
                IpbBodyzone.Top = Convert.ToInt32(SR.ReadLine());
                IpbBodyzone.Width = Convert.ToInt32(SR.ReadLine());
                IpbBodyzone.Height = Convert.ToInt32(SR.ReadLine());
                IpbDescriptionzone.Left = Convert.ToInt32(SR.ReadLine());
                IpbDescriptionzone.Top = Convert.ToInt32(SR.ReadLine());
                IpbDescriptionzone.Width = Convert.ToInt32(SR.ReadLine());
                IpbDescriptionzone.Height = Convert.ToInt32(SR.ReadLine());
                IpbBody.Left = Convert.ToInt32(SR.ReadLine());
                IpbBody.Top = Convert.ToInt32(SR.ReadLine());
                IpbBody.Width = Convert.ToInt32(SR.ReadLine());
                IpbBody.Height = Convert.ToInt32(SR.ReadLine());
                IpbWeaponSlot1.Left = Convert.ToInt32(SR.ReadLine());
                IpbWeaponSlot1.Top = Convert.ToInt32(SR.ReadLine());
                IpbWeaponSlot1.Width = Convert.ToInt32(SR.ReadLine());
                IpbWeaponSlot1.Height = Convert.ToInt32(SR.ReadLine());
                IpbWeaponSlot2.Left = Convert.ToInt32(SR.ReadLine());
                IpbWeaponSlot2.Top = Convert.ToInt32(SR.ReadLine());
                IpbWeaponSlot2.Width = Convert.ToInt32(SR.ReadLine());
                IpbWeaponSlot2.Height = Convert.ToInt32(SR.ReadLine());
                ItbFontName.Text = SR.ReadLine();
                IlbColor.BackColor = ColorTranslator.FromHtml(SR.ReadLine());

                IbtGenerate_Click(new object(), new EventArgs());

                SR.Close();

                Directory.Delete(TempPath, true);
            }
            catch (Exception exp)
            {
                MessageBox.Show("Failed to open the file.\n" + exp.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (
            var TIsfdSaveDialog = new SaveFileDialog
            {
                Title = "Save as",
                FileName = "Inventory style.ieis",
                Filter = "Inventory style (*.ieis)|*.ieis|All file (*.*)|*.*"
            })
            {

                if (TIsfdSaveDialog.ShowDialog() == DialogResult.OK)
                {
                    var TIlbSaving = new Label
                    {
                        AutoSize = true,
                        Text = "Saving...",
                        Parent = this
                    };
                    TIlbSaving.Left = this.Width / 2 - TIlbSaving.Width / 2;
                    TIlbSaving.Top = this.Height / 2 - TIlbSaving.Height / 2;
                    TIlbSaving.BringToFront();
                    ItcMain.Enabled = false;

                    Save(TIsfdSaveDialog.FileName);

                    TIlbSaving.Dispose();
                    ItcMain.Enabled = true;
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (
            var TIofdOpenDialog = new OpenFileDialog
            {
                Title = "Open",
                FileName = "Inventory style.ieis",
                Filter = "Inventory style (*.ieis)|*.ieis|All file (*.*)|*.*"
            })
            {

                if (TIofdOpenDialog.ShowDialog() == DialogResult.OK)
                {
                    ItcMain.Enabled = false;

                    Open(TIofdOpenDialog.FileName);

                    ItcMain.Enabled = true;
                }
            }
        }

        private void resetLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to reset the location?","Reset location",MessageBoxButtons.YesNo,MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                ResetLocation();
            }
        }

        private void resetImagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to reset the images?", "Reset images", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                ResetImages();
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to create a new inventory style?", "New style", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                ResetLocation();
                ResetImages();
                ItbFontName.Text = "Microsoft Sans Serif";
                IlbColor.BackColor = ColorTranslator.FromHtml("DodgerBlue");
                IbtGenerate_Click(new object(), new EventArgs());
            }
        }

        private void Export(string path)
        {

            Directory.CreateDirectory(path);

            IpbBackground.Image.Save(path + "\\background.png", System.Drawing.Imaging.ImageFormat.Png);
            IpbBody.Image.Save(path + "\\body.png", System.Drawing.Imaging.ImageFormat.Png);
            IpbBodyzone.Image.Save(path + "\\bodyzone.png", System.Drawing.Imaging.ImageFormat.Png);
            IpbDelete.Image.Save(path + "\\delete.png", System.Drawing.Imaging.ImageFormat.Png);
            Description.Save(path + "\\descriptionzone.png", System.Drawing.Imaging.ImageFormat.Png);
            EmptySlot.Save(path + "\\emptyslot.png", System.Drawing.Imaging.ImageFormat.Png);
            IpbEquip.Image.Save(path + "\\equip.png", System.Drawing.Imaging.ImageFormat.Png);
            IpbItemZone.Image.Save(path + "\\itemzone.png", System.Drawing.Imaging.ImageFormat.Png);
            Selector.Save(path + "\\selector.png", System.Drawing.Imaging.ImageFormat.Png);
            IpbUnEquip.Image.Save(path + "\\unequip.png", System.Drawing.Imaging.ImageFormat.Png);
            IpbUse.Image.Save(path + "\\use.png", System.Drawing.Imaging.ImageFormat.Png);
            IpbWeaponSlot1.Image.Save(path + "\\weaponslot1.png", System.Drawing.Imaging.ImageFormat.Png);
            IpbWeaponSlot2.Image.Save(path + "\\weaponslot2.png", System.Drawing.Imaging.ImageFormat.Png);

            Directory.CreateDirectory(path + "\\Numbers\\");
            for (var i = 0; i < 100; i++)
            {
                var Temp = (Image)(Bitmap)Numbers[i];
                Temp.Save(path + "\\Numbers\\" + (i + 1).ToString() +".png", System.Drawing.Imaging.ImageFormat.Png);

            }

            File.Create(path + "\\styleinfo.dat").Close();
            StreamWriter SW = File.AppendText(path + "\\styleinfo.dat");
            SW.WriteLine(IpbBackground.Left / WPercent);
            SW.WriteLine(IpbBackground.Top  /  HPercent);
            SW.WriteLine(IpbBackground.Width  /  WPercent);
            SW.WriteLine(IpbBackground.Height  /  HPercent);
            SW.WriteLine(IpbItemZone.Left / WPercent);
            SW.WriteLine(IpbItemZone.Top  /  HPercent);
            SW.WriteLine(IpbItemZone.Width  /  WPercent);
            SW.WriteLine(IpbItemZone.Height  /  HPercent);
            SW.WriteLine(IpbBodyzone.Left / WPercent);
            SW.WriteLine(IpbBodyzone.Top  /  HPercent);
            SW.WriteLine(IpbBodyzone.Width  /  WPercent);
            SW.WriteLine(IpbBodyzone.Height  /  HPercent);
            SW.WriteLine(IpbDescriptionzone.Left / WPercent);
            SW.WriteLine(IpbDescriptionzone.Top  /  HPercent);
            SW.WriteLine(IpbDescriptionzone.Width  /  WPercent);
            SW.WriteLine(IpbDescriptionzone.Height  /  HPercent);
            SW.WriteLine(IpbBody.Left / WPercent);
            SW.WriteLine(IpbBody.Top  /  HPercent);
            SW.WriteLine(IpbBody.Width  /  WPercent);
            SW.WriteLine(IpbBody.Height);
            SW.WriteLine(IpbWeaponSlot1.Left / WPercent);
            SW.WriteLine(IpbWeaponSlot1.Top  /  HPercent);
            SW.WriteLine(IpbWeaponSlot1.Width  /  WPercent);
            SW.WriteLine(IpbWeaponSlot1.Height  /  HPercent);
            SW.WriteLine(IpbWeaponSlot2.Left / WPercent);
            SW.WriteLine(IpbWeaponSlot2.Top  /  HPercent);
            SW.WriteLine(IpbWeaponSlot2.Width  /  WPercent);
            SW.WriteLine(IpbWeaponSlot2.Height  /  HPercent);
            SW.Close();
        }
        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var IfbdDialog = new FolderBrowserDialog())
            {
                if (IfbdDialog.ShowDialog() == DialogResult.OK)
                {
                    var IedExport = new ExportDialog();
                    if (IedExport.ShowDialog() == DialogResult.OK)
                    {
                        Export(IfbdDialog.SelectedPath + "\\" + IedExport.StyleName);
                    }
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void IfrMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
