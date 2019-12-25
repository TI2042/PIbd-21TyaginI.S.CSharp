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
    public partial class FormBase : Form
    {

        Base<IAntiaircraftGun> bs;
        
        public FormBase()
        {
            InitializeComponent();
            bs = new Base<IAntiaircraftGun>(20, pictureBoxBase.Width, pictureBoxBase.Height);
            Draw();
            
        }
        private void Draw()
        {
            
                Bitmap bmp = new Bitmap(pictureBoxBase.Width, pictureBoxBase.Height);
                Graphics gr = Graphics.FromImage(bmp);
                bs.Draw(gr);
                pictureBoxBase.Image = bmp;
            
            
        }
        private void buttonSetCar_Click(object sender, EventArgs e)
        {
            
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var gun = new Gun(100, 1000, dialog.Color);
                    
                    int place = bs * gun;
                    
                    Draw();
                }
            
        }
 
        private void buttonSetSportCar_Click(object sender, EventArgs e)
        {
            
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    ColorDialog dialogDop = new ColorDialog();
                    if (dialogDop.ShowDialog() == DialogResult.OK)
                    {
                        var gun = new AntiaircraftGun(100, 1000, dialog.Color, dialogDop.Color, true, true, true);
                        int place = bs * gun;
                        if (place == -1)
                        {
                            MessageBox.Show("Нет свободныхмест", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        Draw();
                    }
                }
            
        }
        private void buttonTakeCar_Click(object sender, EventArgs e)
        {
            
                if (maskedTextBox.Text != "")
                {
                    var gun = bs / Convert.ToInt32(maskedTextBox.Text);
                    if (gun != null)
                    {
                        Bitmap bmp = new Bitmap(pictureBoxTake.Width, pictureBoxTake.Height);
                        Graphics gr = Graphics.FromImage(bmp);
                        gun.SetPosition(50, 50, pictureBoxTake.Width, pictureBoxTake.Height);
                        gun.DrawGun(gr);
                        pictureBoxTake.Image = bmp;
                    }
                    else
                    {
                        Bitmap bmp = new Bitmap(pictureBoxTake.Width, pictureBoxTake.Height);
                        pictureBoxTake.Image = bmp;
                    }
                    Draw();
                }
            
        }

        

        
    }
}
