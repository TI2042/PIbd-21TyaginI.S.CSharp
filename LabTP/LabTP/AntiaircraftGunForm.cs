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
    public partial class AntiaircraftGunForm : Form
    {
        private AntiaircraftGun gun;
        public AntiaircraftGunForm()
        {
            InitializeComponent();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxGun.Width, pictureBoxGun.Height);
            Graphics gr = Graphics.FromImage(bmp);
            gun.DrawGun(gr);
            pictureBoxGun.Image = bmp;
        }
        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            gun = new AntiaircraftGun(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.DarkGreen, Color.Gray, true, true, true);
            gun.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxGun.Width, pictureBoxGun.Height);
            Draw();
        }
        private void ButtonMove_Click(object sender, EventArgs e)
        {
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    gun.MoveGun(Direction.Up);
                    break;
                case "buttonDown":
                    gun.MoveGun(Direction.Down);
                    break;
                case "buttonLeft":
                    gun.MoveGun(Direction.Left);
                    break;
                case "buttonRight":
                    gun.MoveGun(Direction.Right);
                    break;
            }
            Draw();
        }


    }
}
