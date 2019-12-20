using NLog;
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
        private Logger logger;
        public FormBase()
        {
            InitializeComponent();
            logger = LogManager.GetCurrentClassLogger();    
            bs = new MultiLevelBase(countLevel, pictureBoxBase.Width, pictureBoxBase.Height);
            for(int i =0;i<countLevel;i++)
            {
                listBoxLevels.Items.Add("Уровень "+(i+1));
            }
            listBoxLevels.SelectedIndex = 0;

        }
        private void Draw()
        {
            if(listBoxLevels.SelectedIndex>-1)
            {
                Bitmap bmp = new Bitmap(pictureBoxBase.Width, pictureBoxBase.Height);
                Graphics gr = Graphics.FromImage(bmp);
                bs[listBoxLevels.SelectedIndex].Draw(gr);
                pictureBoxBase.Image = bmp;
            }

        }
        private void buttonSetCar_Click(object sender, EventArgs e)
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var gun = new Gun(100, 1000, dialog.Color);

                    int place = bs[listBoxLevels.SelectedIndex] + gun;
                    if (place == -1)
                    {
                        MessageBox.Show("Нет свободных мест", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    Draw();
                }
            }
        }

        private void buttonSetSportCar_Click(object sender, EventArgs e)
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    ColorDialog dialogDop = new ColorDialog();
                    if (dialogDop.ShowDialog() == DialogResult.OK)
                    {
                        var gun = new AntiaircraftGun(100, 1000, dialog.Color, dialogDop.Color, true, true, true);
                        int place = bs[listBoxLevels.SelectedIndex] + gun;
                        if (place == -1)
                        {
                            MessageBox.Show("Нет свободныхмест", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        Draw();
                    }
                }
            }
        }
        private void buttonTakeCar_Click(object sender, EventArgs e)
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                if (maskedTextBox.Text != "")
                {
                    try
                    {
                        var gun = bs[listBoxLevels.SelectedIndex] - Convert.ToInt32(maskedTextBox.Text);
                        
                            Bitmap bmp = new Bitmap(pictureBoxTake.Width, pictureBoxTake.Height);
                            Graphics gr = Graphics.FromImage(bmp);
                            gun.SetPosition(50, 50, pictureBoxTake.Width, pictureBoxTake.Height);
                            gun.DrawGun(gr);
                            pictureBoxTake.Image = bmp;
                            logger.Info("Изъята техника" + gun.ToString() + " с места" + maskedTextBox.Text);

                        Draw();
                    }
                    catch (BaseNotFoundException ex)
                    {
                        MessageBox.Show(ex.Message, "Не найдено", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Bitmap bmp = new Bitmap(pictureBoxTake.Width, pictureBoxTake.Height);
                        pictureBoxTake.Image = bmp;
                    }
                    catch (Exception ex)
                    {
                        logger.Error("");
                        MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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
            {
                try
                {
                    int place = bs[listBoxLevels.SelectedIndex] +gun;
                    logger.Info("Добавлена техника" + gun.ToString() + " на место" + place);
                    Draw();
                }
                catch (BaseOverflowException ex)
                {
                    MessageBox.Show(ex.Message, "Переполнение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (BaseAlreadyHaveException ex)
                {
                    MessageBox.Show(ex.Message, "Дублирование", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    bs.SaveData(saveFileDialog.FileName);

                    MessageBox.Show("Сохранение прошло успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    MessageBox.Show("Не сохранилось", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Info("Сохранено в файл" + saveFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {


                    bs.LoadData(openFileDialog.FileName);
                    
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Загружено из файла" + openFileDialog.FileName);            
                   
                }
                catch (BaseOccupiedPlaceException ex)
                {
                    MessageBox.Show(ex.Message, "Занятоеместо", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестнаяошибкаприсохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Draw();
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            bs.Sort();
            Draw();
            logger.Info("Сортировка уровней");
        }
    }
}
