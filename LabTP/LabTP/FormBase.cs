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
        FormGunConfig form;
        MultiLevelBase bs;
        private const int countLevel = 5;
        
        public FormBase()
        {
            InitializeComponent();
            bs = new MultiLevelBase(countLevel, pictureBoxBase.Width, pictureBoxBase.Height);
            for(int i =0;i<countLevel;i++)
            {
                listBoxLevels.Items.Add("Уровень "+(i+1));
            }
            listBoxLevels.SelectedIndex = 0;
        }
        private void Draw()
        {         
            Bitmap bmp = new Bitmap(pictureBoxBase.Width, pictureBoxBase.Height);
            Graphics gr = Graphics.FromImage(bmp);
            bs.Draw(gr);
            pictureBoxBase.Image = bmp;     
        }
        private void buttonSetGun_Click(object sender, EventArgs e)
        {            
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Bitmap bmp = new Bitmap(pictureBoxBase.Width, pictureBoxBase.Height);
                Graphics gr = Graphics.FromImage(bmp);
                bs[listBoxLevels.SelectedIndex].Draw(gr);
                pictureBoxBase.Image = bmp;
            }
        }
 
        private void buttonSetAntiaircraftGun_Click(object sender, EventArgs e)
        {           
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    var gun = new Gun(100, 1000, dialog.Color);
                    int place = bs[listBoxLevels.SelectedIndex] * gun;
                    if (place == -1)
                    {
                        MessageBox.Show("Нет свободныхмест", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    Draw();
                }
            }         
        }
        private void buttonSetSportCar_Click(object sender, EventArgs e)
        {
            if (listBoxLevels.SelectedIndex > -1)
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
            }
        }

        private void listBoxLevels_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }

        private void buttonSetGun_Click(object sender, EventArgs e)
        {
            form = new FormGunConfig();
            form.AddEvent(AddGun);
            form.Show();
        }

        private void AddGun(IAntiaircraftGun gun)
        {
            if (gun != null && listBoxLevels.SelectedIndex > -1)
            { int place = bs[listBoxLevels.SelectedIndex] *gun; if (place > -1)
                { Draw();
                }
                else
                {
                    MessageBox.Show("Машину неудалось поставить");
                }
            }
        }
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (bs.SaveData(saveFileDialog.FileName))
                {
                    MessageBox.Show("Сохранение прошло успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Не сохранилось", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (bs.LoadData(openFileDialog.FileName))
                {
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Не загрузили", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Draw();
            }
        }
    }
}
