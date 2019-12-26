using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTP
{
    public abstract class AbGun : IAntiaircraftGun
    {
        protected float StartX;
        protected float StartY;
        protected int PictureWight;
        protected int PictureHight;
        public int MaxSpeed { protected set; get; }
        public float Weight { protected set; get; }
        public Color MainColor { protected set; get; }

        public abstract void DrawGun(Graphics g);

        public abstract void MoveGun(Direction direction);

        public void SetPosition(int x, int y, int width, int height)
        {
            StartX = x;
            StartY = y;
            PictureWight = width;
            PictureHight = height;
        }
    }
}
