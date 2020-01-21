using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTP
{
    public class Gun : AbGun, IComparable<Gun>, IEquatable<Gun>
    {
        private const int GunWidth = 100;
        private const int GunHidth = 60;

        public Gun(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }

        public Gun(string info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 3)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
            }
        }

        public override void DrawGun(Graphics g)
        {
            Brush br = new SolidBrush(MainColor);
            Point point1 = new Point((int)StartX - 40, (int)StartY + 10);
            Point point2 = new Point((int)StartX + 40, (int)StartY + 10);
            Point point3 = new Point((int)StartX + 45, (int)StartY + 25);
            Point point4 = new Point((int)StartX - 45, (int)StartY + 25);
            Point[] trapezePoints = { point1, point2, point3, point4 };
            g.FillPolygon(br, trapezePoints);

            Brush brBc = new SolidBrush(Color.Black);
            g.FillEllipse(brBc, StartX - 30, StartY + 20, 15, 15);
            g.FillEllipse(brBc, StartX + 20, StartY + 20, 15, 15);
            g.FillRectangle(brBc, StartX, StartY, 10, 10);

            Point pointG1 = new Point((int)StartX + 10, (int)StartY - 15);
            Point pointG2 = new Point((int)StartX + 30, (int)StartY - 15);
            Point pointG3 = new Point((int)StartX + 30, (int)StartY - 10);
            Point pointG4 = new Point((int)StartX + 10, (int)StartY - 10);
            Point[] Guns = { pointG1, pointG2, pointG3, pointG4 };
            g.FillPolygon(brBc, Guns);

            Point pointBTR1 = new Point((int)StartX - 35, (int)StartY + 10);
            Point pointBTR2 = new Point((int)StartX + 35, (int)StartY + 10);
            Point pointBTR3 = new Point((int)StartX + 20, (int)StartY - 10);
            Point pointBTR4 = new Point((int)StartX - 20, (int)StartY - 10);
            Point[] BTRPoints = { pointBTR1, pointBTR2, pointBTR3, pointBTR4 };
            g.FillPolygon(br, BTRPoints);
        }

        public override void MoveGun(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                case Direction.Right:
                    if (StartX + step < PictureWight - GunWidth)
                    {
                        StartX += step;
                    }
                    break;
                case Direction.Left:
                    if (StartX - step > 0)
                    {
                        StartX -= step;
                    }
                    break;
                case Direction.Up:
                    if (StartY - step > 0)
                    {
                        StartY -= step;
                    }
                    break;
                case Direction.Down:
                    if (StartY + step < PictureHight - GunHidth)
                    {
                        StartY += step;
                    }
                    break;
            }
        }

        public override string ToString()
        {
            return MaxSpeed + ";" + Weight + ";" + MainColor.Name;
        }

        public int CompareTo(Gun other)
        {
            if (other == null)
            {
                return 1;
            }
            if (MaxSpeed != other.MaxSpeed)
            {
                return MaxSpeed.CompareTo(other.MaxSpeed);
            }
            if (Weight != other.Weight)
            {
                return Weight.CompareTo(other.Weight);
            }
            if (MainColor != other.MainColor)
            {
                MainColor.Name.CompareTo(other.MainColor.Name);
            }
            return 0;
        }

        public bool Equals(Gun other)
        {
            if (other == null)
            {
                return false;
            }
            if (GetType().Name != other.GetType().Name)
            {
                return false;
            }
            if (MaxSpeed != other.MaxSpeed)
            {
                return false;
            }
            if (Weight != other.Weight)
            {
                return false;
            }
            if (MainColor != other.MainColor)
            {
                return false;
            }
            return true;
        }

        public override bool Equals(Object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is Gun gunObj))
            {
                return false;
            }
            else
            {
                return Equals(gunObj);
            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
