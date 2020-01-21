using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTP
{
    public interface IAntiaircraftGun
    {
        void SetPosition (int x, int y, int width, int height);
        void MoveGun(Direction direction);
        void DrawGun(Graphics g);
        void SetMainColor(Color color);
    }
}
