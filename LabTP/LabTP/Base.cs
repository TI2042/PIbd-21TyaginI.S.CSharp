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
        private T[] _places;
        private int PictureWidth { get; set; }
        private int PictureHeight { get; set; }
        private const int _placeSizeWidth = 210;
        private const int _placeSizeHeight = 80;
        
        public Base(int sizes, int pictureWidth, int pictureHeight)
        {           
            _places = new T [sizes];
            PictureWidth = pictureWidth;
            PictureHeight = pictureHeight;
            for (int i = 0; i < _places.Length; i++)
            {
                _places[i] = null;
            }
        }
        public static int operator * (Base<T> p, T gun)
        {
            for (int i = 0; i < p._places.Length; i++)
            {
                if (p.CheckFreePlace(i))
                {
                    p._places[i]=gun;
                    p._places[i].SetPosition(30 + i / 30 * _placeSizeWidth + 30,i % 30 * _placeSizeHeight + 40, p.PictureWidth, p.PictureHeight);
                    return i;
                }
            }
            return -1;
        }

        public static T operator /(Base<T> p, int index)
        {
            if (index < 0 || index > p._places.Length)
            {
                return null;
            }
            if (!p.CheckFreePlace(index))
            {
                T gun = p._places[index];
                p._places= null;
                return gun;
            }
            return null;
        }
        private bool CheckFreePlace(int index)
        {
            return _places[index]==null;
        }
        public void Draw(Graphics g)
        {
            DrawBase(g);
            
            for (int i = 0; i < _places.Length; i++)
            {
                if (!CheckFreePlace(i))
                {
                    _places[i].DrawGun(g);
                }
            }
        }
        private void DrawBase(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            g.DrawRectangle(pen, 0, 0, (_places.Length / 5) * _placeSizeWidth, 480);
            for (int i = 0; i < _places.Length / 5; i++)
            {
                //отрисовываем, по 5 мест на линии
                for (int j = 0; j < 6; ++j)
                {                
                    g.DrawLine(pen, i * _placeSizeWidth, j * _placeSizeHeight,i * _placeSizeWidth + 110, j * _placeSizeHeight);
                } 
                g.DrawLine(pen, i * _placeSizeWidth, 0, i * _placeSizeWidth, 400);
            }
        }         
    }
}

