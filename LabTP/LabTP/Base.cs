using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTP
{
    public class Base<T> where T: class, IAntiaircraftGun
    {
        private Dictionary<int, T> _places;
        private int PictureWidth { get; set; }
        private int PictureHeight { get; set; }
        private const int _placeSizeWidth = 210;
        private const int _placeSizeHeight = 80;
        private int _maxCount;

        public Base(int sizes, int pictureWidth, int pictureHeight)
        {
            _maxCount = sizes;
            _places = new Dictionary<int, T>();
            PictureWidth = pictureWidth;
            PictureHeight = pictureHeight;
        }
        public static int operator *(Base<T> p, T gun)
        {
            if (p._places.Count == p._maxCount)
            {
                return -1;
            }
            for (int i = 0; i < p._maxCount; i++)
            {
                if (p.CheckFreePlace(i))
                {
                    p._places.Add(i, gun);
                    p._places[i].SetPosition(30 + i / 30 * _placeSizeWidth + 30, i % 30 * _placeSizeHeight + 40, p.PictureWidth, p.PictureHeight);
                    return i;
                }
            }
            return -1;
        }

        public static T operator /(Base<T> p, int index)
        {
            if (!p.CheckFreePlace(index))
            {
                T gun = p._places[index];
                p._places.Remove(index);
                return gun;
            }
            return null;
        }
        private bool CheckFreePlace(int index)
        {
            return !_places.ContainsKey(index);
        }
        public void Draw(Graphics g)
        {
            DrawBase(g);
            var keys = _places.Keys.ToList();
            for (int i = 0; i < keys.Count; i++)
            {
                _places[keys[i]].DrawGun(g);
            }
        }
        private void DrawBase(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            g.DrawRectangle(pen, 0, 0, (_maxCount / 5) * _placeSizeWidth, 480);
            for (int i = 0; i < _maxCount / 5; i++)
            {

                for (int j = 0; j < 6; ++j)
                {
                    g.DrawLine(pen, i * _placeSizeWidth, j * _placeSizeHeight,i * _placeSizeWidth + 110, j * _placeSizeHeight);
                } 
                g.DrawLine(pen, i * _placeSizeWidth, 0, i * _placeSizeWidth, 400);
                g.DrawLine(pen, i * _placeSizeWidth + 110, 0, i * _placeSizeWidth + 110, 400);
            }
        }
        
        public T this[int ind]
        { get
            {
                if (_places.ContainsKey(ind))
                {
                    return _places[ind];
                }
                return null;
            }
            set
            {
                if (CheckFreePlace(ind))
                {
                    _places.Add(ind, value);
                    _places[ind].SetPosition(50 + ind / 50 * _placeSizeWidth + 5, ind % 5 * _placeSizeHeight + 35, PictureWidth, PictureHeight);
                }
            }
        }
    }
}

