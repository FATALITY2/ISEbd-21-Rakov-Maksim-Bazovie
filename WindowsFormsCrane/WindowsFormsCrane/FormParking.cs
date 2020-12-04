using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NLog;

namespace WindowsFormsCrane
{
    public partial class FormParking : Form
    {
        private readonly ParkingCollection parkingCollection;

        private readonly Logger logger;
        public FormParking()
        {
            InitializeComponent();
            parkingCollection = new ParkingCollection(pictureBoxParking.Width, pictureBoxParking.Height);
            logger = LogManager.GetCurrentClassLogger();

        }
        private void ReloadLevels()
        {
            int index = listBoxParking.SelectedIndex;

            listBoxParking.Items.Clear();
            for (int i = 0; i < parkingCollection.Keys.Count; i++)
            {
                listBoxParking.Items.Add(parkingCollection.Keys[i]);
            }

            if (listBoxParking.Items.Count > 0 && (index == -1 || index >= listBoxParking.Items.Count))
            {
                listBoxParking.SelectedIndex = 0;
            }
            else if (listBoxParking.Items.Count > 0 && index > -1 && index < listBoxParking.Items.Count)
            {
                listBoxParking.SelectedIndex = index;
            }
        }

        private void Draw()
        {
            if (listBoxParking.SelectedIndex > -1)
            {
                Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
                Graphics gr = Graphics.FromImage(bmp);
                parkingCollection[listBoxParking.SelectedItem.ToString()].Draw(gr);
                pictureBoxParking.Image = bmp;

            }
        }


        private void buttonAddParking_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNewLevelName.Text))
            {
                MessageBox.Show("Введите название парковки", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                logger.Warn("Не введено название парковки");
                return;
            }

            logger.Info($"Добавили парковку {textBoxNewLevelName.Text}");
            parkingCollection.AddParking(textBoxNewLevelName.Text);
            ReloadLevels();
            textBoxNewLevelName.Text = "";
        }

        private void buttonDelParking_Click(object sender, EventArgs e)
        {
            if (listBoxParking.SelectedIndex > -1)
            {
                if (MessageBox.Show($"Удалить парковку { listBoxParking.SelectedItem.ToString()}?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    logger.Info($"Удалили парковку {listBoxParking.SelectedItem.ToString()}");
                    parkingCollection.DelParking(listBoxParking.SelectedItem.ToString());
                    ReloadLevels();
                }
            }
        }



        private void buttonTakeCar_Click(object sender, EventArgs e)
        {
            if (listBoxParking.SelectedIndex > -1 && maskedTextBoxNumber.Text != "")
            {
                try
                {
                    var crane = parkingCollection[listBoxParking.SelectedItem.ToString()] - Convert.ToInt32(maskedTextBoxNumber.Text);
                    if (crane != null)
                    {
                        FormCrane form = new FormCrane();
                        form.SetCrane(crane);
                        form.ShowDialog();

                        logger.Info($"Изъят кран {crane} с места {maskedTextBoxNumber.Text}");
                    }
                    Draw();
                }

                catch (CraneNotFoundException ex)
                {
                    MessageBox.Show(ex.Message, "Не найдено", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn("Не найдено");
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn("Неизвестная ошибка");
                }
            }

        }

        private void listBoxParking_SelectedIndexChanged(object sender, EventArgs e)
        {
            logger.Info($"Перешли на парковку {listBoxParking.SelectedItem.ToString()}");
            Draw();
        }
        private void buttonSetCrane_Click(object sender, EventArgs e)
        {
            var formCraneConfig = new FormCraneConfig();
            formCraneConfig.AddEvent(AddCrane);
            formCraneConfig.Show();
        }

        private void AddCrane(Vehicle crane)
        {
            if (crane != null && listBoxParking.SelectedIndex > -1)
            {
                try
                {
                    if ((parkingCollection[listBoxParking.SelectedItem.ToString()]) +
                   crane)
                    {
                        Draw();
                        logger.Info($"Добавлен кран {crane}");
                    }
                    else
                    {
                        MessageBox.Show("Кран не удалось поставить");
                    }
                    Draw();
                }
                catch (ParkingOverflowException ex)
                {
                    MessageBox.Show(ex.Message, "Переполнение", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    parkingCollection.SaveData(saveFileDialog.FileName);
                    MessageBox.Show("Сохранение прошло успешно", "Результат",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Сохранено в файл " + saveFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    parkingCollection.LoadData(openFileDialog.FileName);
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    logger.Info("Загружено из файла " + openFileDialog.FileName);
                    ReloadLevels();
                    Draw();
                }              
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}