using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTP
{
    class AntiaircraftGun : Gun
    {
        public Color DopColor { private set; get; }
        public bool FrontArmor { private set; get; }// передняя броня
        public bool MuzzleBraker { private set; get; }// дульный тормоз
        public bool Radar { private set; get; }//радар
        public AntiaircraftGun(int maxSpeed, float weight, Color mainColor, Color dopColor,
            bool frontArmor, bool muzzleBraker, bool radar): base(maxSpeed, weight, mainColor)
        {

            DopColor = dopColor;
            FrontArmor = frontArmor;
            MuzzleBraker = muzzleBraker;
            Radar = radar;
        }

        public override void DrawGun(Graphics g)
        {
            Brush br = new SolidBrush(MainColor);
            base.DrawGun(g);
            Brush brBc = new SolidBrush(Color.Black);

            Point pointG1 = new Point((int)StartX + 15, (int)StartY - 5);
            Point pointG2 = new Point((int)StartX + 35, (int)StartY - 25);
            Point pointG3 = new Point((int)StartX + 40, (int)StartY - 20);
            Point pointG4 = new Point((int)StartX + 20, (int)StartY);
            Point[] Guns = { pointG1, pointG2, pointG3, pointG4 };
            g.FillPolygon(brBc, Guns);

            if (Radar)
            {
                Rectangle rect = new Rectangle((int)StartX + 10, (int)StartY - 25, 10, 10);
                g.FillPie(br, rect, 250, 180);
            }

            if (FrontArmor)
            {
                Brush br2 = new SolidBrush(DopColor);
                Point pointF1 = new Point((int)StartX, (int)StartY - 15);
                Point pointF2 = new Point((int)StartX + 20, (int)StartY - 15);
                Point pointF3 = new Point((int)StartX + 35, (int)StartY + 10);
                Point pointF4 = new Point((int)StartX + 15, (int)StartY + 10);
                Point[] parall = { pointF1, pointF2, pointF3, pointF4 };
                g.FillPolygon(br2, parall);
            }
            if (MuzzleBraker)
            {
                Brush brGr = new SolidBrush(Color.Gray);
                Point pointM4 = new Point((int)StartX + 35, (int)StartY - 25);
                Point pointM2 = new Point((int)StartX + 45, (int)StartY - 35);
                Point pointM3 = new Point((int)StartX + 40, (int)StartY - 20);
                Point pointM1 = new Point((int)StartX + 50, (int)StartY - 30);
                Point[] mB = { pointM1, pointM2, pointM3, pointM4 };
                g.FillPolygon(brGr, mB);
            }

        }

    }
}
