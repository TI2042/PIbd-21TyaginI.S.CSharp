using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LabTP
{
    public partial class FormGunConfig : Form
    {
        IAntiaircraftGun gun = null;
        private event gunDelegate eventAddGun;
        public FormGunConfig()
        {
            InitializeComponent();
            panelWhite.MouseDown += panelColor_MouseDown;
            panelBlack.MouseDown+= panelColor_MouseDown;
            panelRed.MouseDown+= panelColor_MouseDown;
            panelYellow.MouseDown+= panelColor_MouseDown;
            panelBlue.MouseDown+= panelColor_MouseDown;
            panelPink.MouseDown+= panelColor_MouseDown;
            panelAqua.MouseDown+= panelColor_MouseDown;
            panelGreen.MouseDown+= panelColor_MouseDown;

            buttonCancel.Click += (object sender, EventArgs e) => { Close(); };
        }

        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Control).DoDragDrop((sender as Control).BackColor, DragDropEffects.Move | DragDropEffects.Copy);
        }

        public void AddEvent(gunDelegate ev) {
            if (eventAddGun == null)
            {
                eventAddGun = new gunDelegate(ev);
            }
            else
            {
                eventAddGun += ev;
            }
        }

        private void labelBaseColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        private void labelBaseColor_DragDrop(object sender, DragEventArgs e)
        {
            if (gun != null)
            { gun.SetMainColor((Color)e.Data.GetData(typeof(Color)));
                DrawGun();
            }
        }
        private void DrawGun()
        {
            if(gun !=null)
            {
                Bitmap bmp = new Bitmap(pictureBoxGun.Width, pictureBoxGun.Height);
                Graphics gr = Graphics.FromImage(bmp);
                gun.SetPosition(50, 50, pictureBoxGun.Width, pictureBoxGun.Height);
                gun.DrawGun(gr);
                pictureBoxGun.Image = bmp;
            }
        }
        private void lableGun_MouseDown(object sender, MouseEventArgs e)
        {
            labelGun.DoDragDrop(labelGun.Text,DragDropEffects.Move|DragDropEffects.Copy);
        }

        private void lableBTR_MouseDown(object sender, MouseEventArgs e)
        {
            labelBTR.DoDragDrop(labelBTR.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void panelGun_DragEnter(object sender,DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        private void panelGun_DragDrop(object sender,DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Зенитка":
                    gun = new AntiaircraftGun(100, 500, Color.White, Color.Black, true, true, true);
                    break;
                case "БТР":
                    gun = new Gun(100, 500, Color.White);
                    break;
                
            }
            DrawGun();
        }
        private void labelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            if (gun != null)
            { if (gun is AntiaircraftGun)
                { (gun as AntiaircraftGun).SetDopColor((Color)e.Data.GetData(typeof(Color)));
                    DrawGun();
                }
            }
        }
        private void buttonOk_Click(object sender, EventArgs e)
        {
            eventAddGun?.Invoke(gun);
            Close();
        }    
    }
}
